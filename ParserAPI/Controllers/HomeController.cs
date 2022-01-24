using ParserAPI.Model;
using ParserAPI.Parser.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ParserAPI.Controllers
{
    
    //[Route("api/[action]")]
    public class HomeController : Controller
    {
        private readonly IParser parser;

        public HomeController()
        {
          this.parser = ParserFactory.Create();
        }
        [Route("api/cities")]
        [HttpGet]
        public ActionResult Cities(string cityName, string cityCode)
        {
            // burada HttpStatusCode =200 döndümek için  Ok(.net core) yerine json döndür
            if (string.IsNullOrEmpty(cityCode) && !string.IsNullOrEmpty(cityName))
                return Json(parser.GetCityByCityName(cityName));
            else if (!string.IsNullOrEmpty(cityCode) && string.IsNullOrEmpty(cityName))
                return Json(parser.GetCityByCityCode(cityCode));
            else
                return Json(parser.GetAllCities());
        }

        [HttpGet]
        public ActionResult Districts(string cityName, string cityCode)
        {
            if (!string.IsNullOrEmpty(cityCode) && string.IsNullOrEmpty(cityName))
                return Json(parser.GetDistrictsByCityCode(cityCode));
            else if (string.IsNullOrEmpty(cityCode) && !string.IsNullOrEmpty(cityName))
                return Json(parser.GetDistrictsByCityName(cityName));
            else
                return Json(parser.GetAllDistricts());
        }
    }
}