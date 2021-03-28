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

            if (!char.IsDigit(_vin[13]) || !char.IsDigit(_vin[14]) ||
                !char.IsDigit(_vin[15]) || !char.IsDigit(_vin[16]))
                return false;

            if (_vin[8].ToString() != CalculatingChecksum(_vin))
                return false;


            return true;
        }

        public static string VinInfo(string vin)
        {
            _vin = vin.ToUpper();

            string result = $"Информация о указанном VIN ({vin}):\n";

            if (_vin.Length != 17)
                return result += "Ошибка!\nДлина VIN должна составлять 17 знаков";

            foreach (var @char in _vin)
            {
                if (!_allowedChars.Contains(@char))
                    return result += "Ошибка!\nVIN состоит из запрещённых символов";
            }

            if (_vin[0] == '0')
                return result += "Ошибка!\nПервый символ не может быть равен 0";

            Country country = CountriesList.FirstOrDefault(i => i.GeoAreaCode == _vin[0]
            && i.IsActive == true && ExpandedCode(i.CodeInterval).Contains(_vin[1].ToString()));

            if (country == null)
                return result += "Ошибка!\nНеверный всемирный индекс изготовителя (WMI)";
            else if (!country.IsActive)
                return result += $"Ошибка!\nСимвол '{_vin[1]}' не используется для какой либо страны в регионе \"{country.GeoArea.Name}\"";

            if (ModelYearDict[_vin[9]] == 0)
                return "Ошибка!\nНеверный модельный год";

            if (!char.IsDigit(_vin[13]) || !char.IsDigit(_vin[14]) ||
                !char.IsDigit(_vin[15]) || !char.IsDigit(_vin[16]))
                return "Ошибка!\nПоследние 4 знака обязательно должны быть цифрами";

            if (_vin[8].ToString() != CalculatingChecksum(_vin))
                return result += "Ошибка!\nНеверный контрольный символ";

            result += $"Регион: {country.GeoArea.Name}\nСтрана сборки: {country.Name}\n" +
                $"Фирма-производитель: неизвестно\nКолесная база: неизвестно\n" +
                $"Тип кузова: неизвестно\nДвигатель: неизвестно\n" +
                $"Тип трансмиссии: неизвестно\nГод выпуска: {ModelYearDict[_vin[9]]}\n" +
                $"Отделение завода: неизвестно\nПорядковый номер: неизвестно\n" +
                $"Контрольный символ: успешно прошёл проверку";

            return result;
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
                    if (char.IsDigit(item))
                        digitalEquivalent += item;
                    else
                        digitalEquivalent += DigitalEquivalentDict[item];
                }
            }

            for (int i = 0; i < digitalEquivalent.Length; i++)
            {
                var item = digitalEquivalent[i];

                sum += (int)char.GetNumericValue(item) * WeightOfCharactersDict[i + 1];
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
