using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerForCreatingBestTour
{
    /** 
     * Stores information about cities. Includes:
     * 1. Cities
     * 2. Distances between cities
     */
    public static class CitiesInfo
    {
        public static City[] Cities()
        {
            City[] cities =
            {
                new City("Berlin", 3611000, 830530),
                new City("Kiev", 2934000, 850860),
                new City("Minsk", 1992000, 537840),
                new City("Vien", 1821000, 509880),
                new City("Prague", 1301000, 312240),
                new City("Warsaw", 1758000, 404340),
                new City("Budapesht", 1798000, 431520),
                new City("Odesa", 1011000, 242640),
                new City("Kishinev", 690000, 172500),
                new City("Lviv", 728000, 160160),
                new City("Gdansk", 467000, 126090),
                new City("Krakov", 769000, 207630),
                new City("Koshize", 240000, 55200),
                new City("Zagreb", 802000, 184460),
                new City("Venice", 261000, 75690),
                new City("Munchen", 1456000, 378560),
                new City("Zurich", 396000, 95040),
                new City("Nurnberg", 515000, 118450),
                new City("Koln", 1080000, 270000),
                new City("Bremen", 568000, 124960),
            };

            return cities;
        }

        

        public static int[,] Distances()
        {
            int inf = int.MaxValue/2;
            int[,] distances = new int[7, 7]
            {/*
                            Berlin Kiev Minsk Vien Prague Warsaw Budapesht
                Berlin
                Kiev
                Minsk
                Vien
                Prague
                Warsaw
                Budapesht

                */
                { 0, inf, inf, inf, 349, 575, inf},
                { inf, 0, 569, inf, inf, 788, 1116},
                { inf, 589, 0, inf, inf, 547, inf},
                { inf, inf, inf, 0, 333, 683, 243},
                { 349, inf, inf, 333, 0, 688, inf},
                { 575, 788, 547, 683, 688, 0, 871},
                { inf, 1116, inf, 243, inf, 871, 0}
            };

            return distances;
        }

    }
}
