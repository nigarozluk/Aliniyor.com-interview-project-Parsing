using ParserAPI.Parser.Abstract;
using ParserAPI.Parser.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParserAPI.Model
{
    public class ParserFactory
    {
        public static IParser Create()
        {
            return new XmlParser();
            //return new CsvParser();
            //return new JsonParser();
        }
    }
}