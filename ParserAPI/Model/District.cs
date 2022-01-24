using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParserAPI.Model
{
    public class District
    {
        public string DistrictName { get; set; }
        public List<string> ZipCodes { get; set; }
    }
}