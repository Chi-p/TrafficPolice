using System.Collections.Generic;

namespace TraficPoliceLib
{
    public class DictionaryClass
    {

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
