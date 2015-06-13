using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMovieDb.Classes
{
    public class Utility
    {
        public static string ConverToFriendlyUrlParameter(string parameter){
            string result = "";
            result = parameter.Replace(" ", "_");

            return result;
        }

        public static string UrlParamterToString(string parameter)
        {
            string result = "";
            result = parameter.Replace("_", " ");

            return result;
        }
    }
}