using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasStationOnly.Models
{
    public class GassStation
    {
        public int GassStationId { get; set; }
        public string Gasoline { get; set; }
        public int Price { get; set; }
        public DateTime Time { get; set; }
        public int Amount { get; set; }
        public int Sum { get; set; }
        public int PrePrice { get; set; }
       
        public override string ToString()
        {
            return $"{Amount} - {PrePrice} - {Time}";
        }
    }
}
