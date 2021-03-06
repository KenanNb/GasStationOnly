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
                Price = int.Parse(_view.PriceText),
                Time = DateTime.Now,
                Amount = int.Parse(_view.AmountText),                
                PrePrice = int.Parse(_view.PriceText) * int.Parse(_view.AmountText)
                
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
                    Price = int.Parse(_view.PriceText),
                    Time = DateTime.Now,
                   Sum = int.Parse(_view.SumText),
                    Amount = int.Parse(_view.SumText) / int.Parse(_view.PriceText),
                    PrePrice = int.Parse(_view.SumText)
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
