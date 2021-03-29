using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraficPoliceLib
{
    class Region
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public int SubjectCode { get; set; }
        public string OKATOcode { get; set; }
        public string ISO3166_2 { get; set; }

        public static List<Region> RegionsList = new List<Region>
        {
            #region Республики
            new Region { Name = "Республика Адыгея", SubjectCode = 1, Code = "01", OKATOcode = "79", ISO3166_2 = "RU-AD" },
            new Region { Name = "Республика Алтай", SubjectCode = 4, Code = "04", OKATOcode = "84", ISO3166_2 = "RU-AL" },
            new Region { Name = "Республика Башкортостан", SubjectCode = 2, Code = "02,102", OKATOcode = "80", ISO3166_2 = "RU-BA" },
            new Region { Name = "Республика Бурятия", SubjectCode = 3, Code = "03", OKATOcode = "81", ISO3166_2 = "RU-BU" },
            new Region { Name = "Республика Дагестан", SubjectCode = 5, Code = "05", OKATOcode = "82", ISO3166_2 = "RU-DA" },
            new Region { Name = "Республика Ингушетия", SubjectCode = 6, Code = "06", OKATOcode = "26", ISO3166_2 = "RU-IN" },
            new Region { Name = "Кабардино-Балкарская республика", SubjectCode = 7, Code = "07", OKATOcode = "83", ISO3166_2 = "RU-KB" },
            new Region { Name = "Республика Калмыкия", SubjectCode = 8, Code = "08", OKATOcode = "85", ISO3166_2 = "RU-KL" },
            new Region { Name = "Карачаево-Черкесская республика", SubjectCode = 9, Code = "09", OKATOcode = "91", ISO3166_2 = "RU-KC" },
            new Region { Name = "Республика Карелия", SubjectCode = 10, Code = "10", OKATOcode = "86", ISO3166_2 = "RU-KR" },
            new Region { Name = "Республика Коми", SubjectCode = 11, Code = "11,111", OKATOcode = "87", ISO3166_2 = "RU-KO" },
            new Region { Name = "Республика Крым", SubjectCode = 91, Code = "82", OKATOcode = "35", ISO3166_2 = "RU-CR" },
            new Region { Name = "Республика Марий Эл", SubjectCode = 12, Code = "12", OKATOcode = "88", ISO3166_2 = "RU-ME" },
            new Region { Name = "Республика Мордовия", SubjectCode = 13, Code = "13,113", OKATOcode = "89", ISO3166_2 = "RU-MO" },
            new Region { Name = "Республика Саха (Якутия)", SubjectCode = 14, Code = "14", OKATOcode = "98", ISO3166_2 = "RU-SA" },
            new Region { Name = "Республика Северная Осетия — Алания", SubjectCode = 15, Code = "15", OKATOcode = "90", ISO3166_2 = "RU-SE" },
            new Region { Name = "Республика Татарстан", SubjectCode = 16, Code = "16,116", OKATOcode = "89", ISO3166_2 = "RU-TA" },
            new Region { Name = "Республика Тыва", SubjectCode = 17, Code = "17", OKATOcode = "89", ISO3166_2 = "RU-TY" },
            new Region { Name = "Удмуртская республика", SubjectCode = 18, Code = "18", OKATOcode = "89", ISO3166_2 = "RU-UD" },
            new Region { Name = "Республика Хакасия", SubjectCode = 19, Code = "19", OKATOcode = "89", ISO3166_2 = "RU-KK" },
            new Region { Name = "Чеченская республика", SubjectCode = 20, Code = "95", OKATOcode = "89", ISO3166_2 = "RU-CE" },
            new Region { Name = "Чувашская республика", SubjectCode = 21, Code = "21,121", OKATOcode = "89", ISO3166_2 = "RU-CU" },
            #endregion
            #region Края
            new Region { Name = "Алтайский край", SubjectCode = 22, Code = "22", OKATOcode = "1", ISO3166_2 = "RU-ALT" },
            new Region { Name = "Забайкальский край", SubjectCode = 75, Code = "75,80", OKATOcode = "76", ISO3166_2 = "RU-ZAB" },
            new Region { Name = "Камчатский край", SubjectCode = 41, Code = "41", OKATOcode = "30", ISO3166_2 = "RU-KAM" },
            new Region { Name = "Краснодарский край", SubjectCode = 23, Code = "23,93,123", OKATOcode = "3", ISO3166_2 = "RU-KDA" },
            new Region { Name = "Красноярский край", SubjectCode = 24, Code = "24,124,84,88", OKATOcode = "4", ISO3166_2 = "RU-KYA" },
            new Region { Name = "Пермский край", SubjectCode = 59, Code = "59,81,159", OKATOcode = "57", ISO3166_2 = "RU-PER" },
            new Region { Name = "Приморский край", SubjectCode = 25, Code = "25,125", OKATOcode = "5", ISO3166_2 = "RU-PRI" },
            new Region { Name = "Ставропольский край", SubjectCode = 26, Code = "26,126", OKATOcode = "7", ISO3166_2 = "RU-STA" },
            new Region { Name = "Хабаровский край", SubjectCode = 27, Code = "27", OKATOcode = "8", ISO3166_2 = "RU-KHA" },
            #endregion
            #region Области
            new Region { Name = "Амурская область", SubjectCode = 28, Code = "28", OKATOcode = "10", ISO3166_2 = "RU-AMU" },
            new Region { Name = "Архангельская область", SubjectCode = 29, Code = "29", OKATOcode = "11", ISO3166_2 = "RU-ARK" },
            new Region { Name = "Астраханская область", SubjectCode = 30, Code = "30", OKATOcode = "12", ISO3166_2 = "RU-AST" },
            new Region { Name = "Белгородская область", SubjectCode = 31, Code = "31", OKATOcode = "14", ISO3166_2 = "RU-BEL" },
            new Region { Name = "Брянская область", SubjectCode = 32, Code = "32", OKATOcode = "15", ISO3166_2 = "RU-BRY" },
            new Region { Name = "Владимирская область", SubjectCode = 33, Code = "33", OKATOcode = "17", ISO3166_2 = "RU-VLA" },
            new Region { Name = "Волгоградская область", SubjectCode = 34, Code = "34,134", OKATOcode = "18", ISO3166_2 = "RU-VGG" },
            new Region { Name = "Вологодская область", SubjectCode = 35, Code = "35", OKATOcode = "19", ISO3166_2 = "RU-VLG" },
            new Region { Name = "Воронежская область", SubjectCode = 36, Code = "36,136", OKATOcode = "20", ISO3166_2 = "RU-VOR" },
            new Region { Name = "Ивановская область", SubjectCode = 37, Code = "37", OKATOcode = "24", ISO3166_2 = "RU-IVA" },
            new Region { Name = "Иркутская область", SubjectCode = 38, Code = "38,138,85", OKATOcode = "25", ISO3166_2 = "RU-IRK" },
            new Region { Name = "Калининградская область", SubjectCode = 39, Code = "39,91", OKATOcode = "27", ISO3166_2 = "RU-KGD" },
            new Region { Name = "Калужская область", SubjectCode = 40, Code = "40", OKATOcode = "29", ISO3166_2 = "RU-KLU" },
            new Region { Name = "Кемеровская область", SubjectCode = 42, Code = "42,142", OKATOcode = "32", ISO3166_2 = "RU-KEM" },
            new Region { Name = "Кировская область", SubjectCode = 43, Code = "43", OKATOcode = "33", ISO3166_2 = "RU-KIR" },
            new Region { Name = "Костромская область", SubjectCode = 44, Code = "44", OKATOcode = "34", ISO3166_2 = "RU-KOS" },
            new Region { Name = "Курганская область", SubjectCode = 45, Code = "45", OKATOcode = "37", ISO3166_2 = "RU-KGN" },
            new Region { Name = "Курская область", SubjectCode = 46, Code = "46", OKATOcode = "38", ISO3166_2 = "RU-KRS" },
            new Region { Name = "Ленинградская область", SubjectCode = 47, Code = "47", OKATOcode = "41", ISO3166_2 = "RU-LEN" },
            new Region { Name = "Липецкая область", SubjectCode = 48, Code = "48", OKATOcode = "42", ISO3166_2 = "RU-LIP" },
            new Region { Name = "Магаданская область", SubjectCode = 49, Code = "49", OKATOcode = "44", ISO3166_2 = "RU-MAG" },
            new Region { Name = "Московская область", SubjectCode = 50, Code = "50,90,150,190,750", OKATOcode = "46", ISO3166_2 = "RU-MOS" },
            new Region { Name = "Мурманская область", SubjectCode = 51, Code = "51", OKATOcode = "47", ISO3166_2 = "RU-MUR" },
            new Region { Name = "Нижегородская область", SubjectCode = 52, Code = "52,152", OKATOcode = "22", ISO3166_2 = "RU-NIZ" },
            new Region { Name = "Новгородская область", SubjectCode = 53, Code = "53", OKATOcode = "49", ISO3166_2 = "RU-NGR" },
            new Region { Name = "Новосибирская область", SubjectCode = 54, Code = "54,154", OKATOcode = "50", ISO3166_2 = "RU-NVS" },
            new Region { Name = "Омская область", SubjectCode = 55, Code = "55", OKATOcode = "52", ISO3166_2 = "RU-OMS" },
            new Region { Name = "Оренбургская область", SubjectCode = 56, Code = "56", OKATOcode = "53", ISO3166_2 = "RU-ORE" },
            new Region { Name = "Орловская область", SubjectCode = 57, Code = "57", OKATOcode = "54", ISO3166_2 = "RU-ORL" },
            new Region { Name = "Пензенская область", SubjectCode = 58, Code = "58", OKATOcode = "56", ISO3166_2 = "RU-PNZ" },
            new Region { Name = "Псковская область", SubjectCode = 60, Code = "60", OKATOcode = "58", ISO3166_2 = "RU-PSK" },
            new Region { Name = "Ростовская область", SubjectCode = 61, Code = "61,161", OKATOcode = "60", ISO3166_2 = "RU-ROS" },
            new Region { Name = "Рязанская область", SubjectCode = 62, Code = "62", OKATOcode = "61", ISO3166_2 = "RU-RYA" },
            new Region { Name = "Самарская область", SubjectCode = 63, Code = "63,163", OKATOcode = "36", ISO3166_2 = "RU-SAM" },
            new Region { Name = "Саратовская область", SubjectCode = 64, Code = "64,164", OKATOcode = "63", ISO3166_2 = "RU-SAR" },
            new Region { Name = "Сахалинская область", SubjectCode = 65, Code = "65", OKATOcode = "64", ISO3166_2 = "RU-SAK" },
            new Region { Name = "Свердловская область", SubjectCode = 66, Code = "66,96,196", OKATOcode = "65", ISO3166_2 = "RU-SVE" },
            new Region { Name = "Смоленская область", SubjectCode = 67, Code = "67", OKATOcode = "66", ISO3166_2 = "RU-SMO" },
            new Region { Name = "Тамбовская область", SubjectCode = 68, Code = "68", OKATOcode = "68", ISO3166_2 = "RU-TAM" },
            new Region { Name = "Тверская область", SubjectCode = 69, Code = "69", OKATOcode = "28", ISO3166_2 = "RU-TVE" },
            new Region { Name = "Томская область", SubjectCode = 70, Code = "70", OKATOcode = "69", ISO3166_2 = "RU-TOM" },
            new Region { Name = "Тульская область", SubjectCode = 71, Code = "71", OKATOcode = "70", ISO3166_2 = "RU-TUL" },
            new Region { Name = "Тюменская область", SubjectCode = 72, Code = "72", OKATOcode = "71", ISO3166_2 = "RU-TYU" },
            new Region { Name = "Тюменская область", SubjectCode = 73, Code = "73,173", OKATOcode = "73", ISO3166_2 = "RU-ULY" },
            new Region { Name = "Тюменская область", SubjectCode = 74, Code = "74,174", OKATOcode = "75", ISO3166_2 = "RU-CHE" },
            new Region { Name = "Тюменская область", SubjectCode = 76, Code = "76", OKATOcode = "78", ISO3166_2 = "RU-YAR" },
            new Region { Name = "Еврейская автономная область", SubjectCode = 79, Code = "79", OKATOcode = "99", ISO3166_2 = "RU-YEV" },
            #endregion
            #region Города
            new Region { Name = "Москва", SubjectCode = 77, Code = "77,97,99,177,197,199,777", OKATOcode = "45", ISO3166_2 = "RU-MOW" },
            new Region { Name = "Санкт-Петербург", SubjectCode = 78, Code = "78,98,178", OKATOcode = "40", ISO3166_2 = "RU-SPE" },
            new Region { Name = "Севастополь", SubjectCode = 92, Code = "92", OKATOcode = "67", ISO3166_2 = "RU-SEV" },
            #endregion
            #region Округа
            new Region { Name = "Ненецкий автономный округ", SubjectCode = 83, Code = "83", OKATOcode = "11-Aug", ISO3166_2 = "RU-NEN" },
            new Region { Name = "Ханты-Мансийский автономный округ - Югра", SubjectCode = 86, Code = "86,186", OKATOcode = "71-8", ISO3166_2 = "RU-KHM" },
            new Region { Name = "Чукотский автономный округ", SubjectCode = 87, Code = "87", OKATOcode = "77", ISO3166_2 = "RU-CHU" },
            new Region { Name = "Ямало-Ненецкий автономный округ", SubjectCode = 89, Code = "89", OKATOcode = "71-9", ISO3166_2 = "RU-YAN" },
            #endregion
            #region Другое
            new Region { Name = "Байконур (Казахстан)", Code = "94"},
            #endregion
        };
    }
}
