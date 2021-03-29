using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TraficPoliceLib.Dictionaries;

namespace TraficPoliceLib
{
    /// <summary>
    /// Класс для проверки регистрационного знака и получения информации о нём
    /// </summary>
    public static class RegMark
    {
        #region Variables
        private static readonly string _allowedChars = "ABEKMHOPCTYX0123456789";
        private static string _mark = "";
        #endregion

        /// <summary>
        /// Метод, который принимает регистрационный знак в формате A999AA999
        /// и проверяет на правильность введённый регистрационный знак
        /// </summary>
        /// <param name="mark">Регистрационный знак</param>
        /// <returns>true - всё хорошо, false - что-то не так</returns>
        public static bool CheckMark(string mark)
        {
            string regNum = "";
            _mark = mark.ToUpper();

            if (_mark.Length < 8 || _mark.Length > 9)
                return false;

            foreach (var @char in _mark)
            {
                if (!_allowedChars.Contains(@char))
                    return false;
            }

            if (!Char.IsLetter(_mark[0]))
                return false;

            if (_mark.Substring(1, 3).Any(char.IsLetter))
                return false;

            if (_mark.Substring(4, 2).Any(char.IsDigit))
                return false;


            if (_mark.Length == 8)
            {
                regNum = _mark.Substring(6, 2);
                if (regNum.Any(char.IsLetter))
                    return false;
            }

            if (_mark.Length == 9)
            {
                regNum = _mark.Substring(6, 3);
                if (regNum.Any(char.IsLetter))
                    return false;
            }

            Region region = Region.RegionsList.FirstOrDefault(i => i.Code.Contains(regNum));
            if (region == null)
                return false;

            return true;
        }

        /// <summary>
        /// Метод, который принимает регистрационный знак в формате A999AA999 и
        /// выводит полную информацию о введённом регистрационном знаке
        /// </summary>
        /// <param name="mark">Регистрационный знак</param>
        /// <returns>Возвращает результат с ошибкой или с информацией</returns>
        public static string GetMarkInfo(string mark)
        {
            string regNum = "";
            string seria = "";
            string regCode = "";
            _mark = mark.ToUpper();

            if (_mark.Length < 8 || _mark.Length > 9)
                return "Ошибка!\nДлина регистрационного знака должна составлять от 8 до 9 знаков";

            foreach (var @char in _mark)
            {
                if (!_allowedChars.Contains(@char))
                    return "Ошибка!\nРегистрационный знак должен состоять только из латинских букв и цифр";
            }
            seria = _mark[0].ToString() + _mark.Substring(4, 2);
            regNum = _mark.Substring(1, 3);

            if (regNum.Any(char.IsLetter))
                return "Ошибка!\nРегистрационный номер должен состоять только из цифр";

            if (seria.Any(char.IsDigit))
                return "Ошибка!\nСерия должна состоять только из букв";

            if (_mark.Length == 8)
            {
                regCode = _mark.Substring(6, 2);
                if (regCode.Any(char.IsLetter))
                    return "Ошибка!\nКод региона должен состоять только из цифр";
            }

            if (_mark.Length == 9)
            {
                regCode = _mark.Substring(6, 3);
                if (regCode.Any(char.IsLetter))
                    return "Ошибка!\nКод региона должен состоять только из цифр";
            }

            Region region = Region.RegionsList.FirstOrDefault(i => i.Code.Contains(regCode));
            if (region == null)
                return "Ошибка!\nНесуществующий код региона";

            return $"Информация об указанном регистрационном знаке({_mark}):\n" +
                $"Серия: {seria}\n" +
                $"Регистрационный номер: {regNum}\n" +
                $"Регион: {region.Name}\n" +
                $"Код региона: {regCode}";
        }

        /// <summary>
        /// Метод, который принимает регистрационный знак в формате A999AA999 и 
        /// выдает следующий номер в данной серии или создает следующую серию
        /// </summary>
        /// <param name="mark">Регистрационный знак</param>
        /// <returns>Возвращает результат с ошибкой или со следующим регистрационным знаком</returns>
        public static string GetNextMarkAfter(string mark)
        {
            var info = GetMarkInfo(mark);
            if (info.Contains("Ошибка!"))
                return info;

            string seriaFirst = _mark[0].ToString();
            string seriaSeciond = _mark.Substring(4, 2);
            string regNum = _mark.Substring(1, 3);
            string regCode = _mark.Length == 8 ? _mark.Substring(6, 2) : _mark.Substring(6, 3);

            if (regNum != "999")
            {
                regNum = (int.Parse(regNum) + 1).ToString();
                for (int i = regNum.Length; i < 3; i++)
                {
                    regNum = "0" + regNum;
                }    
            }
            else
            {
                int index;
                regNum = "000";
                if (seriaSeciond[1] != 'X')
                {
                    index = _allowedChars.IndexOf(seriaSeciond[1]) + 1;
                    seriaSeciond = seriaSeciond[0].ToString() + _allowedChars[index].ToString();
                }
                else if (seriaSeciond[0] != 'X')
                {
                    index = _allowedChars.IndexOf(seriaSeciond[0]) + 1;
                    seriaSeciond = _allowedChars[index].ToString() + _allowedChars[0].ToString();
                }
                else if (seriaFirst != "X")
                {
                    index = _allowedChars.IndexOf(seriaFirst[0]) + 1;
                    seriaFirst = _allowedChars[index].ToString();
                    seriaSeciond = _allowedChars[0].ToString() + _allowedChars[0].ToString();
                }
                else
                {
                    return "Ошибка!\nЭто последний регистрационный знак";
                }
            }


            return seriaFirst + regNum + seriaSeciond + regCode;

        }
    }
}
