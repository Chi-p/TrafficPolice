using System.Collections.Generic;

namespace TraficPoliceLib
{
    class GeoArea
    {
        public string CodeInterval { get; set; }
        public string Name { get; set; }

        public static List<GeoArea> GeoAreaList = new List<GeoArea>
        {
            new GeoArea { CodeInterval = "A-H", Name = "Африка"},
            new GeoArea { CodeInterval = "J-R", Name = "Азия"},
            new GeoArea { CodeInterval = "S-Z", Name = "Европа"},
            new GeoArea { CodeInterval = "1-5", Name = "Северная Америка"},
            new GeoArea { CodeInterval = "6-7", Name = "Океания"},
            new GeoArea { CodeInterval = "8-9", Name = "Южная Америка"}
        };
    }
}