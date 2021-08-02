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
        public decimal Price { get; set; }
        public DateTime Time { get; set; }
        public decimal Amount { get; set; }
        public decimal Sum { get; set; }
        public decimal PrePrice { get; set; }
       
        public override string ToString()
        {
            return $"{Amount} - {PrePrice} - {Time}";
        }
        
    }
}
