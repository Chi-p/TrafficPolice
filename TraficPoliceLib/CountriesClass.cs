using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TraficPoliceLib.GeoAreaClass;

namespace TraficPoliceLib
{
    public class CountriesClass
    {
        public class Country
        {
            public string CodeInterval { get; set; }
            public bool IsActive { get; set; }
            public string Name { get; set; }
            public char GeoAreaCode { get; set; }
            public GeoArea GeoArea { get; set; }
        }

        public static List<Country> CountriesList = new List<Country>
        {
            #region African countries
            new Country { CodeInterval = "A-H", GeoAreaCode = 'A', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Африка"), IsActive = true, Name = "ЮАР" },
            new Country { CodeInterval = "J-N", GeoAreaCode = 'A', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Африка"), IsActive = true, Name = "Кот-д'Ивуар" },
            new Country { CodeInterval = "P-0", GeoAreaCode = 'A', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Африка"), IsActive = false, Name = "Не используется" },
            new Country { CodeInterval = "A-E", GeoAreaCode = 'B', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Африка"), IsActive = true, Name = "Ангола" },
            new Country { CodeInterval = "F-K", GeoAreaCode = 'B', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Африка"), IsActive = true, Name = "Кения" },
            new Country { CodeInterval = "L-R", GeoAreaCode = 'B', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Африка"), IsActive = true, Name = "Танзания"},
            new Country { CodeInterval = "S-0", GeoAreaCode = 'B', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Африка"), IsActive = false, Name = "Не используется" },
            new Country { CodeInterval = "A-E", GeoAreaCode = 'C', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Африка"), IsActive = true, Name = "Бенин" },
            new Country { CodeInterval = "F-K", GeoAreaCode = 'C', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Африка"), IsActive = true, Name = "Мадагаскар" },
            new Country { CodeInterval = "L-R", GeoAreaCode = 'C', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Африка"), IsActive = true, Name = "Тунис" },
            new Country { CodeInterval = "S-0", GeoAreaCode = 'C', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Африка"), IsActive = false, Name = "Не используется" },
            new Country { CodeInterval = "A-E", GeoAreaCode = 'D', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Африка"), IsActive = true, Name = "Египет" },
            new Country { CodeInterval = "F-K", GeoAreaCode = 'D', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Африка"), IsActive = true, Name = "Мароко" },
            new Country { CodeInterval = "L-R", GeoAreaCode = 'D', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Африка"), IsActive = true, Name = "Замбия" },
            new Country { CodeInterval = "S-0", GeoAreaCode = 'D', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Африка"), IsActive = false, Name = "Не используется" },
            new Country { CodeInterval = "A-E", GeoAreaCode = 'E', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Африка"), IsActive = true, Name = "Эфиопия" },
            new Country { CodeInterval = "F-K", GeoAreaCode = 'E', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Африка"), IsActive = true, Name = "Мозамбик" },
            new Country { CodeInterval = "L-0", GeoAreaCode = 'E', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Африка"), IsActive = false, Name = "Не используется" },
            new Country { CodeInterval = "A-E", GeoAreaCode = 'F', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Африка"), IsActive = true, Name = "Гана" },
            new Country { CodeInterval = "F-K", GeoAreaCode = 'F', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Африка"), IsActive = true, Name = "Нигерия" },
            new Country { CodeInterval = "L-0", GeoAreaCode = 'F', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Африка"), IsActive = false, Name = "Не используется" },
            new Country { CodeInterval = "A-0", GeoAreaCode = 'G', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Африка"), IsActive = false, Name = "Не используется" },
            new Country { CodeInterval = "A-0", GeoAreaCode = 'H', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Африка"), IsActive = false, Name = "Не используется" },
            #endregion
            #region Asian countries
            new Country { CodeInterval = "A-T", GeoAreaCode = 'J', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Азия"), IsActive = true, Name = "Япония" },
            new Country { CodeInterval = "A-E", GeoAreaCode = 'K', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Азия"), IsActive = true, Name = "Шри Ланка" },
            new Country { CodeInterval = "F-K", GeoAreaCode = 'K', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Азия"), IsActive = true, Name = "Израиль" },
            new Country { CodeInterval = "L-R", GeoAreaCode = 'K', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Азия"), IsActive = true, Name = "Южная Корея" },
            new Country { CodeInterval = "S-0", GeoAreaCode = 'K', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Азия"), IsActive = true, Name = "Казахстан"},
            new Country { CodeInterval = "A-0", GeoAreaCode = 'L', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Азия"), IsActive = true, Name = "Китай" },
            new Country { CodeInterval = "A-E", GeoAreaCode = 'M', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Азия"), IsActive = true, Name = "Индия" },
            new Country { CodeInterval = "F-K", GeoAreaCode = 'M', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Азия"), IsActive = true, Name = "Индонезия" },
            new Country { CodeInterval = "L-R", GeoAreaCode = 'M', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Азия"), IsActive = true, Name = "Таиланд" },
            new Country { CodeInterval = "S-0", GeoAreaCode = 'M', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Азия"), IsActive = false, Name = "Не используется" },
            new Country { CodeInterval = "F-K", GeoAreaCode = 'N', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Азия"), IsActive = true, Name = "Пакистан" },
            new Country { CodeInterval = "L-R", GeoAreaCode = 'N', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Азия"), IsActive = true, Name = "Турция" },
            new Country { CodeInterval = "T-0", GeoAreaCode = 'N', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Азия"), IsActive = false, Name = "Не используется" },
            new Country { CodeInterval = "A-E", GeoAreaCode = 'P', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Азия"), IsActive = true, Name = "Филиппины" },
            new Country { CodeInterval = "F-K", GeoAreaCode = 'P', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Азия"), IsActive = true, Name = "Сингапур" },
            new Country { CodeInterval = "L-R", GeoAreaCode = 'P', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Азия"), IsActive = true, Name = "Малайзия" },
            new Country { CodeInterval = "S-0", GeoAreaCode = 'P', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Азия"), IsActive = false, Name = "Не используется" },
            new Country { CodeInterval = "A-E", GeoAreaCode = 'R', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Азия"), IsActive = true, Name = "ОАЭ" },
            new Country { CodeInterval = "F-K", GeoAreaCode = 'R', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Азия"), IsActive = true, Name = "Тайвань" },
            new Country { CodeInterval = "L-R", GeoAreaCode = 'R', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Азия"), IsActive = true, Name = "Вьетнам" },
            new Country { CodeInterval = "S-0", GeoAreaCode = 'R', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Азия"), IsActive = true, Name = "Саудовская Аравия" },
            #endregion
        };
    }
}
