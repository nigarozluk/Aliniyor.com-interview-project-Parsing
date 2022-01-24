using ParserAPI.Model;
using ParserAPI.Parser.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;

namespace ParserAPI.Parser.Concrete
{
    public class XmlParser : IParser
    {
        public List<City> GetAllCities()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("Data/sample_data.xml");

            List<City> cityList = new List<City>();

            foreach (XmlNode node in doc.DocumentElement)
            {
                var city = node.Attributes[0].Value; //şehir isimlerini getiriyor
                var cityCode = node.Attributes[1].Value; //şehir plaka kodlarını getiriyor

                List<District> districtList = new List<District>();

                foreach (XmlNode childNode in node.ChildNodes)
                {
                    var disName = childNode.Attributes[0].Value; //ilçe isimlerini getiriyor
                    List<string> zipCodes = new List<string>();

                    foreach (XmlNode childNode_ in childNode.ChildNodes)
                    {
                        zipCodes.Add(childNode_.Attributes[0].Value); //zip kodları getiriyor
                    }

                    districtList.Add(new District { DistrictName = disName, ZipCodes = zipCodes });
                }

                cityList.Add(new City { CityCode = cityCode, CityName = city, Districts = districtList });

            }

            return cityList;
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