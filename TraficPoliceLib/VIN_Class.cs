using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TraficPoliceLib.CountriesClass;
using static TraficPoliceLib.GeoAreaClass;

namespace TraficPoliceLib
{
    public class VIN_Class
    {

        public static string allowedChars = "ABCDEFGHJKLMNPRSTUVWXYZ0123456789";

        public static Boolean CheckVin(String vin)
        {
            foreach (var @char in vin)
            {
                if (!allowedChars.Contains(@char))
                    return false;
            }

            if (vin[0] == '0')
                return false;

            Country country = CountriesList.FirstOrDefault(i =>  i.GeoAreaCode == vin[0] 
            && i.IsActive == true && ExpandedCode(i.CodeInterval).Contains(vin[1].ToString()));

            if (country == null)
                return false;
 
            return true;
        }

        public static string ExpandedCode(string codeInterval)
        {
            string result = "";
            string[] codeArray = codeInterval.Split('-');

            foreach (var item in allowedChars)
            {
                if (!string.IsNullOrWhiteSpace(result))
                {
                    if (codeArray[1] != item.ToString())
                    {
                        result += item.ToString();
                        continue;
                    }
                    else
                    {
                        result += item.ToString();
                        break;
                    }
                }
                if (codeArray[0] == item.ToString())
                {
                    result += item.ToString();
                }
            }
            return result;
        }
    }
}
