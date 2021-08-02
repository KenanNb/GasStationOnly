using GasStationOnly.Data;
using GasStationOnly.Models;
using GasStationOnly.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasStationOnly.Presenter
{
    public class MainPresenter
    {
        private readonly GassStationContext _db;
        private IMainView _view;
        public MainPresenter(IMainView view)
        {
            _view = view;
            _db = new GassStationContext();
            _view.PayButtonClicked += PayButtonClicked;
            _view.LoadPaymentButtonClicked += LoadPaymentsButton;                  
        }
        private void PayButtonClicked(object sender,EventArgs e)
        {
          
            if (_view.IsAmount)
            {
            GassStation gassStation = new GassStation
            {
                Gasoline = _view.GasolineText,
                Price = decimal.Parse(_view.PriceText),
                Time = DateTime.Now,
                Amount = decimal.Parse(_view.AmountText),                
                PrePrice = decimal.Parse(_view.PriceText) * decimal.Parse(_view.AmountText)
                
            };
             _view.TimeText = DateTime.Now.ToString();
            _db.GassStations.Add(gassStation);
            _db.SaveChanges(); 
            }
            else
            {
                GassStation gassStation = new GassStation
                {
                    Gasoline = _view.GasolineText,
                    Price = decimal.Parse(_view.PriceText),
                    Time = DateTime.Now,
                   Sum = decimal.Parse(_view.SumText),
                    Amount = decimal.Parse(_view.SumText) / decimal.Parse(_view.PriceText),
                    PrePrice = decimal.Parse(_view.SumText)
                };
                _view.TimeText = DateTime.Now.ToString();
                _db.GassStations.Add(gassStation);
                _db.SaveChanges();
            }
        }
        private void LoadPaymentsButton(object sender, EventArgs e)
        {
            var list = _db.GassStations.ToList();
            _view.GassStations = list;
        }
    }
}
