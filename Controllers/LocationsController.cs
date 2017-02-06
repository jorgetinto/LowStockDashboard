using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using LowStockDashboard.Models;

namespace LowStockDashboard.Controllers
{
    public class LocationsController : ApiController
    {
        [HttpGet()]
        [ActionName("GetLocations")]
        public IEnumerable<Location> GetLocations()
        {
            System.Threading.Thread.Sleep(1000);

            List<Location> locations = new List<Location>();

            locations = new List<Location>();

            locations.Add(new Location()
            {
                LocationId = "1",

                LocationName = "Warehouse 1"
            });

            locations.Add(new Location()
            {
                LocationId = "2",

                LocationName = "US Warehouse 2"
            });

            locations.Add(new Location()
            {
                LocationId = "3",
                LocationName = "East Asia"
            });

            return locations;
        }
    }
}
