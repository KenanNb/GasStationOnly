using GasStationOnly.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasStationOnly.Data
{
    public class GassStationContext:DbContext
    {
        public GassStationContext():base("GassStationDb")
        {
        }
        public DbSet<GassStation> GassStations { get; set; }
    }
}
