using GasStationOnly.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasStationOnly.Views
{
    public interface IMainView
    {
        EventHandler<EventArgs> PayButtonClicked { get; set; }
        EventHandler<EventArgs> LoadPaymentButtonClicked { get; set; }
        List<GassStation> GassStations { set; }
        string GasolineText { get; set; }
        string PriceText { get; set; }
        string TimeText { get; set; }
        string AmountText { get; set; }
        string SumText { get; set; }
        string PrePriceText { get; set; }
    }
}
