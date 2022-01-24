using Newtonsoft.Json;
using ParserAPI.Model;
using ParserAPI.Parser.Abstract;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace ParserAPI.Parser.Concrete
{
    public class JsonParser : IParser
    {
        public List<City> GetAllCities()
        {
            string json = File.ReadAllText("Data/sample_data.json");
            List<CityForJson> items = JsonConvert.DeserializeObject<List<CityForJson>>(json);
            List<City> data = new List<City>();
            foreach (var item in items)
            {
                var cityName = item.CityName;
                var cityCode = item.CityCode;
                var districtName = item.DistrictName;
                var zipcode = item.ZipCode;


                // City defalarca eklenmesin
                if (data.Count(k => k.CityName == cityName) == 0)
                    data.Add(new City { CityName = cityName, CityCode = cityCode, Districts = new List<District>() });

                // District defalarca eklenmesin
                if (data.Count(k => k.CityName == cityName && k.Districts.Any(z => z.DistrictName == districtName)) == 0)
                {
                    var _city = data.FirstOrDefault(k => k.CityName == cityName);
                    _city.Districts.Add(new District { DistrictName = districtName, ZipCodes = new List<string> { zipcode } });
                }
                else
                {
                    var _city = data.FirstOrDefault(k => k.CityName == cityName);
                    var _district = _city.Districts.FirstOrDefault(k => k.DistrictName == districtName);
                    _district.ZipCodes.Add(zipcode);
                }
            }
            return data;
        }

        public List<District> GetAllDistricts()
        {
            return this.GetAllCities().SelectMany(k => k.Districts).ToList();
        }

        public City GetCityByCityCode(string cityCode)
        {
            return this.GetAllCities().Where(k => k.CityCode == cityCode).FirstOrDefault();
        }

        public City GetCityByCityName(string cityName)
        {
            return this.GetAllCities().Where(k => k.CityName == cityName).FirstOrDefault();
        }

        public List<District> GetDistrictsByCityCode(string cityCode)
        {
            return this.GetAllCities().Where(k => k.CityCode == cityCode).FirstOrDefault().Districts;
        }

        public List<District> GetDistrictsByCityName(string cityName)
        {
            return this.GetAllCities().Where(k => k.CityName == cityName).FirstOrDefault().Districts;
        }
    }
}