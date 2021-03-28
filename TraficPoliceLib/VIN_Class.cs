using System;
using System.Linq;
using static TraficPoliceLib.Country;
using static TraficPoliceLib.DictionaryClass;

namespace TraficPoliceLib
{
    public class VIN_Class
    {
        #region Variables
        private static readonly string _allowedChars = "ABCDEFGHJKLMNPRSTUVWXYZ0123456789";
        private static string _vin = "";
        #endregion
      
        public static bool CheckVin(string vin)
        {
            _vin = vin.ToUpper();

            if (_vin.Length != 17)
                return false;

            foreach (var @char in _vin)
            {
                if (!_allowedChars.Contains(@char))
                    return false;
            }

            if (_vin[0] == '0')
                return false;

            Country country = CountriesList.FirstOrDefault(i => i.GeoAreaCode == _vin[0]
            && i.IsActive == true && ExpandedCode(i.CodeInterval).Contains(_vin[1].ToString()));

            if (country == null)
                return false;

            if (_vin[8].ToString() != CalculatingChecksum(_vin))
                return false;

            return true;
        }

        #region Methods with calculations
        public static string ExpandedCode(string codeInterval)
        {
            string result = "";
            string[] codeArray = codeInterval.Split('-');

            foreach (var item in _allowedChars)
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

        public static string CalculatingChecksum(string vin)
        {
            string digitalEquivalent = "";
            int sum = 0;

            for (int i = 0; i < vin.Length; i++)
            {
                var item = vin[i];
                if (i != 8)
                {
                    if (Char.IsDigit(item))
                        digitalEquivalent += item;
                    else
                        digitalEquivalent += DigitalEquivalentDict[item];
                }
            }

            for (int i = 0; i < digitalEquivalent.Length; i++)
            {
                var item = digitalEquivalent[i];

                sum += (int)Char.GetNumericValue(item) * WeightOfCharactersDict[i + 1];
            }

            int a = (int)(Math.Floor((double)sum / 11) * 11);

            string result = (sum - a).ToString();
            if (result == "10")
                result = "X";

            return result;
        }
        #endregion
    }
}
