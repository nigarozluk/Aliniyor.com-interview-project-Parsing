using ParserAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserAPI.Parser.Abstract
{
   public interface IParser
    {
        List<City> GetAllCities();
        City GetCityByCityName(string cityName);
        City GetCityByCityCode(string cityCode);
        List<District> GetDistrictsByCityName(string cityName);
        List<District> GetDistrictsByCityCode(string cityCode);
        List<District> GetAllDistricts();
    }
}

