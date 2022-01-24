using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParserAPI.Model
{
    public class City
    {
        public string CityName { get; set; }
        public string CityCode { get; set; }
        public List<District> Districts { get; set; }
    }
}