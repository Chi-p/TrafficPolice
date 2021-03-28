using System.Collections.Generic;
using System.Linq;
using static TraficPoliceLib.GeoArea;

namespace TraficPoliceLib
{
    public class Country
    {
        public string CodeInterval { get; set; }
        public bool IsActive { get; set; }
        public string Name { get; set; }
        public char GeoAreaCode { get; set; }
        public GeoArea GeoArea { get; set; }

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
            #region European countries
            new Country { CodeInterval = "A-M", GeoAreaCode = 'S', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Европа"), IsActive = true, Name = "Великобритания" },
            new Country { CodeInterval = "N-T", GeoAreaCode = 'S', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Европа"), IsActive = true, Name = "Германия" },
            new Country { CodeInterval = "U-Z", GeoAreaCode = 'S', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Европа"), IsActive = true, Name = "Польша" },
            new Country { CodeInterval = "1-4", GeoAreaCode = 'S', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Европа"), IsActive = true, Name = "Латвия" },
            new Country { CodeInterval = "A-H", GeoAreaCode = 'T', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Европа"), IsActive = true, Name = "Швейцария" },
            new Country { CodeInterval = "J-P", GeoAreaCode = 'T', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Европа"), IsActive = true, Name = "Чехия" },
            new Country { CodeInterval = "R-V", GeoAreaCode = 'T', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Европа"), IsActive = true, Name = "Венгрия" },
            new Country { CodeInterval = "W-1", GeoAreaCode = 'T', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Европа"), IsActive = true, Name = "Португалия" },
            new Country { CodeInterval = "2-0", GeoAreaCode = 'T', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Европа"), IsActive = false, Name = "Не используется" },
            new Country { CodeInterval = "A-G", GeoAreaCode = 'U', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Европа"), IsActive = false, Name = "Не используется" },
            new Country { CodeInterval = "H-M", GeoAreaCode = 'U', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Европа"), IsActive = true, Name = "Дания" },
            new Country { CodeInterval = "N-T", GeoAreaCode = 'U', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Европа"), IsActive = true, Name = "Ирландия" },
            new Country { CodeInterval = "U-Z", GeoAreaCode = 'U', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Европа"), IsActive = true, Name = "Румыния" },
            new Country { CodeInterval = "1-4", GeoAreaCode = 'U', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Европа"), IsActive = false, Name = "Не используется" },
            new Country { CodeInterval = "5-7", GeoAreaCode = 'U', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Европа"), IsActive = true, Name = "Словакия" },
            new Country { CodeInterval = "8-0", GeoAreaCode = 'U', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Европа"), IsActive = false, Name = "Не используется" },
            new Country { CodeInterval = "A-E", GeoAreaCode = 'V', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Европа"), IsActive = true, Name = "Австрия" },
            new Country { CodeInterval = "F-R", GeoAreaCode = 'V', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Европа"), IsActive = true, Name = "Франция" },
            new Country { CodeInterval = "S-W", GeoAreaCode = 'V', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Европа"), IsActive = true, Name = "Испания" },
            new Country { CodeInterval = "X-2", GeoAreaCode = 'V', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Европа"), IsActive = true, Name = "Сербия" },
            new Country { CodeInterval = "3-5", GeoAreaCode = 'V', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Европа"), IsActive = true, Name = "Хорватия" },
            new Country { CodeInterval = "6-0", GeoAreaCode = 'V', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Европа"), IsActive = true, Name = "Эстония" },
            new Country { CodeInterval = "A-0", GeoAreaCode = 'W', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Европа"), IsActive = true, Name = "Германия" },
            new Country { CodeInterval = "A-E", GeoAreaCode = 'X', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Европа"), IsActive = true, Name = "Болгария" },
            new Country { CodeInterval = "F-K", GeoAreaCode = 'X', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Европа"), IsActive = true, Name = "Греция" },
            new Country { CodeInterval = "L-R", GeoAreaCode = 'X', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Европа"), IsActive = true, Name = "Нидерланды" },
            new Country { CodeInterval = "S-W", GeoAreaCode = 'X', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Европа"), IsActive = true, Name = "СССР/СНГ" },
            new Country { CodeInterval = "X-2", GeoAreaCode = 'X', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Европа"), IsActive = true, Name = "Люксембург" },
            new Country { CodeInterval = "3-0", GeoAreaCode = 'X', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Европа"), IsActive = true, Name = "Россия" },
            new Country { CodeInterval = "A-E", GeoAreaCode = 'Y', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Европа"), IsActive = true, Name = "Бельгия" },
            new Country { CodeInterval = "F-K", GeoAreaCode = 'Y', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Европа"), IsActive = true, Name = "Финляндия" },
            new Country { CodeInterval = "L-R", GeoAreaCode = 'Y', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Европа"), IsActive = true, Name = "Мальта" },
            new Country { CodeInterval = "S-W", GeoAreaCode = 'Y', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Европа"), IsActive = true, Name = "Швеция" },
            new Country { CodeInterval = "X-2", GeoAreaCode = 'Y', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Европа"), IsActive = true, Name = "Норвегия" },
            new Country { CodeInterval = "3-5", GeoAreaCode = 'Y', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Европа"), IsActive = true, Name = "Беларусь" },
            new Country { CodeInterval = "6-0", GeoAreaCode = 'Y', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Европа"), IsActive = true, Name = "Украина" },
            new Country { CodeInterval = "A-R", GeoAreaCode = 'Z', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Европа"), IsActive = true, Name = "Италия" },
            new Country { CodeInterval = "S-W", GeoAreaCode = 'Z', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Европа"), IsActive = false, Name = "Не используется" },
            new Country { CodeInterval = "X-2", GeoAreaCode = 'Z', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Европа"), IsActive = true, Name = "Словения" },
            new Country { CodeInterval = "3-5", GeoAreaCode = 'Z', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Европа"), IsActive = true, Name = "Литва" },
            new Country { CodeInterval = "6-0", GeoAreaCode = 'Z', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Европа"), IsActive = true, Name = "Россия" },
            #endregion
            #region North American countries
            new Country { CodeInterval = "A-0", GeoAreaCode = '1', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Северная Америка"), IsActive = true, Name = "США" },
            new Country { CodeInterval = "A-0", GeoAreaCode = '2', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Северная Америка"), IsActive = true, Name = "Канада" },
            new Country { CodeInterval = "A-W", GeoAreaCode = '3', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Северная Америка"), IsActive = true, Name = "Мексика" },
            new Country { CodeInterval = "X-7", GeoAreaCode = '3', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Северная Америка"), IsActive = true, Name = "Коста Рика" },
            new Country { CodeInterval = "8-0", GeoAreaCode = '3', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Северная Америка"), IsActive = true, Name = "Каймановы острова"},
            new Country { CodeInterval = "A-0", GeoAreaCode = '4', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Северная Америка"), IsActive = true, Name = "США" },
            new Country { CodeInterval = "A-0", GeoAreaCode = '5', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Северная Америка"), IsActive = true, Name = "США" },
            #endregion
            #region Oceania countries
            new Country { CodeInterval = "A-W", GeoAreaCode = '6', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Океания"), IsActive = true, Name = "Австралия" },
            new Country { CodeInterval = "X-0", GeoAreaCode = '6', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Океания"), IsActive = false, Name = "Не используется" },
            new Country { CodeInterval = "A-E", GeoAreaCode = '7', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Океания"), IsActive = true, Name = "Новая Зеланидя" },
            new Country { CodeInterval = "F-0", GeoAreaCode = '7', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Океания"), IsActive = false, Name = "Не используется" },
            #endregion
            #region South American countries
            new Country { CodeInterval = "A-E", GeoAreaCode = '8', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Южная Америка"), IsActive = true, Name = "Аргентина" },
            new Country { CodeInterval = "F-K", GeoAreaCode = '8', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Южная Америка"), IsActive = true, Name = "Чили" },
            new Country { CodeInterval = "L-R", GeoAreaCode = '8', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Южная Америка"), IsActive = true, Name = "Эквадор" },
            new Country { CodeInterval = "S-W", GeoAreaCode = '8', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Южная Америка"), IsActive = true, Name = "Перу" },
            new Country { CodeInterval = "X-2", GeoAreaCode = '8', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Южная Америка"), IsActive = true, Name = "Венесуэла"},
            new Country { CodeInterval = "3-0", GeoAreaCode = '8', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Южная Америка"), IsActive = false, Name = "Не используется" },
            new Country { CodeInterval = "A-E", GeoAreaCode = '9', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Южная Америка"), IsActive = true, Name = "Бразилия" },
            new Country { CodeInterval = "F-K", GeoAreaCode = '9', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Южная Америка"), IsActive = true, Name = "Колумбия" },
            new Country { CodeInterval = "L-R", GeoAreaCode = '9', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Южная Америка"), IsActive = true, Name = "Парагвай" },
            new Country { CodeInterval = "S-W", GeoAreaCode = '9', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Южная Америка"), IsActive = true, Name = "Уругвай" },
            new Country { CodeInterval = "X-2", GeoAreaCode = '9', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Южная Америка"), IsActive = true, Name = "Тринидад и Тобаго" },
            new Country { CodeInterval = "3-9", GeoAreaCode = '9', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Южная Америка"), IsActive = true, Name = "Бразилия" },
            new Country { CodeInterval = "0-0", GeoAreaCode = '9', GeoArea = GeoAreaList.FirstOrDefault(i=>i.Name=="Южная Америка"), IsActive = false, Name = "Не используется" },
            #endregion
        };
    }
}
