using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp2.Tools
{
    public static class SimpleDateConverter
    {
        static string[] date = new string[3];
        static string dd;
        static string mm;
        static string yyyy;
        public static string Convert(string inputdate)
        {
            try
            {
                date = inputdate.Split('.');
                dd = date[0];
                mm = date[1];
                yyyy = date[2];
                return yyyy + "-" + mm + "-" + dd;
            }
            catch (Exception e) { }
            return inputdate;
        }
        public static string ConvertBack(string inputdate)
        {
            try
            {
                date = inputdate.Split('-');
                dd = date[2];
                mm = date[1];
                yyyy = date[0];
                return dd + "." + mm + "." + yyyy;
            }
            catch(Exception e) { }
            return inputdate;
        }
    }
}