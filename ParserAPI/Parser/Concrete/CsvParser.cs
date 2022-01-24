using ParserAPI.Model;
using ParserAPI.Parser.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParserAPI.Parser.Concrete
{
    public class CsvParser : IParser
    {
        public List<City> GetAllCities()
        {
            string[] parsedLines = System.IO.File.ReadAllLines("Data/sample_data.csv");
            //ilk kaydı alma
            var lines = parsedLines.ToList().GetRange(1, parsedLines.Length - 1);
            List<City> data = new List<City>();

            foreach (string line in lines)
            {
                var values = line.Split(',');

                var cityName = values[0];
                var cityCode = values[1];
                var districtName = values[2];
                var zipcode = values[3];

                // City yoksa ekle
                if (data.Count(k => k.CityName == cityName) == 0)
                    data.Add(new City { CityName = cityName, CityCode = cityCode, Districts = new List<District>() });

                // District Yoksa
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