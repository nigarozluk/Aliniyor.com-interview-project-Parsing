using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParserAPI.Model
{
    public class CityForJson
    {
        public string CityName { get; set; }
        public string CityCode { get; set; }
        public string DistrictName { get; set; }
        public string ZipCode { get; set; }
    }
}