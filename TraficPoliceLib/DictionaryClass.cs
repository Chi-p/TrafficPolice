using System.Collections.Generic;

namespace TraficPoliceLib
{
    class DictionaryClass
    {
        /// <summary>
        /// Словарь с цифровыми эквивалентами символов VIN номера
        /// </summary>
        public static Dictionary<char, string> DigitalEquivalentDict = new Dictionary<char, string>
        {
            ['A'] = "1",
            ['B'] = "2",
            ['C'] = "3",
            ['D'] = "4",
            ['E'] = "5",
            ['F'] = "6",
            ['G'] = "7",
            ['H'] = "8",
            ['J'] = "1",
            ['K'] = "2",
            ['L'] = "3",
            ['M'] = "4",
            ['N'] = "5",
            ['P'] = "7",
            ['R'] = "9",
            ['S'] = "2",
            ['T'] = "3",
            ['U'] = "4",
            ['V'] = "5",
            ['W'] = "6",
            ['X'] = "7",
            ['Y'] = "8",
            ['Z'] = "9",
        };
        /// <summary>
        /// Словарь с модальными годами VIN номера
        /// </summary>
        public static Dictionary<char, int> ModelYearDict = new Dictionary<char, int>
        {
            ['U'] = 0,
            ['Z'] = 0,
            ['0'] = 0,
            ['N'] = 1992,
            ['P'] = 1993,
            ['R'] = 1994,
            ['S'] = 1995,
            ['T'] = 1996,
            ['V'] = 1997,
            ['W'] = 1998,
            ['X'] = 1999,
            ['Y'] = 2000,
            ['1'] = 2001,
            ['2'] = 2002,
            ['3'] = 2003,
            ['4'] = 2004,
            ['5'] = 2005,
            ['6'] = 2006,
            ['7'] = 2007,
            ['8'] = 2008,
            ['9'] = 2009,
            ['A'] = 2010,
            ['B'] = 2011,
            ['C'] = 2012,
            ['D'] = 2013,
            ['E'] = 2014,
            ['F'] = 2015,
            ['G'] = 2016,
            ['H'] = 2017,
            ['J'] = 2018,
            ['K'] = 2019,
            ['L'] = 2020,
            ['M'] = 2021
        };
        /// <summary>
        /// Словарь с весом каждого символа VIN номера
        /// </summary>
        public static Dictionary<int, int> WeightOfCharactersDict = new Dictionary<int, int>
        {
            [1] = 8,
            [2] = 7,
            [3] = 6,
            [4] = 5,
            [5] = 4,
            [6] = 3,
            [7] = 2,
            [8] = 10,
            [9] = 9,
            [10] = 8,
            [11] = 7,
            [12] = 6,
            [13] = 5,
            [14] = 4,
            [15] = 3,
            [16] = 2,
        };
    }
}
