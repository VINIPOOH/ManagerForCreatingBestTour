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
        public static City[] Cities
        {
            get
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
        }

        public static int[,] Distances
        {
            get
            {
                int inf = int.MaxValue / 2;
                int[,] distances = new int[20, 20]
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
                { 0, inf, inf, inf, 349, 575, inf, inf, inf, inf, 600, inf, inf, inf, inf, inf, inf, inf, inf, 407},
                { inf, 0, 569, inf, inf, 788, inf, 475, 472, 541, inf, inf, inf, inf, inf, inf, inf, inf, inf, inf},
                { inf, 589, 0, inf, inf, 547, inf, inf, inf, inf, 774, inf, inf, inf, inf, inf, inf, inf, inf, inf},
                { inf, inf, inf, 0, 333, inf, 243, inf, inf, inf, inf, 464, inf, 376, 602, 435, inf, inf, inf, inf},
                { 349, inf, inf, 333, 0, 688, inf, inf, inf, inf, inf, 534, inf, inf, inf, inf, inf, 299, inf, 617},
                { 575, 788, 547, inf, 688, 0, inf, inf, inf, 399, 339, 293, inf, inf, inf, inf, inf, inf, inf, inf},
                { inf, inf, inf, 243, inf, inf, 0, inf, 966, inf, inf, inf, 260, inf, inf, inf, inf, inf, inf, inf},
                { inf, 475, inf, inf, inf, inf, inf, 0, 178, inf, inf, inf, inf, inf, inf, inf, inf, inf, inf, inf},
                { inf, 472, inf, inf, inf, inf, 966, 178, 0, 590, inf, inf, inf, inf, inf, inf, inf, inf, inf, inf},
                { inf, 541, inf, inf, inf, 399, inf, inf, 590, 0, inf, 326, 326, inf, inf, inf, inf, inf, inf, inf},
                { 600, inf, 774, inf, inf, 339, inf, inf, inf, inf, 0, inf, inf, inf, inf, inf, inf, inf, inf, inf},
                { inf, inf, inf, 464, 534, 293, inf, inf, inf, 326, inf, 0, 247, inf, inf, inf, inf, inf, inf, inf},
                { inf, inf, inf, inf, inf, inf, 260, inf, inf, 326, inf, 247, 0, inf, inf, inf, inf, inf, inf, inf},
                { inf, inf, inf, 376, inf, inf, inf, inf, inf, inf, inf, inf, inf, 0, 374, inf, inf, inf, inf, inf},
                { inf, inf, inf, 602, inf, inf, inf, inf, inf, inf, inf, inf, inf, 374, 0, 544, 541, inf, inf, inf},
                { inf, inf, inf, 435, inf, inf, inf, inf, inf, inf, inf, inf, inf, inf, 544, 0, 316, 169, inf, inf},
                { inf, inf, inf, inf, inf, inf, inf, inf, inf, inf, inf, inf, inf, inf, 541, 316, 0, inf, 573, inf},
                { inf, inf, inf, inf, 299, inf, inf, inf, inf, inf, inf, inf, inf, inf, inf, 169, inf, 0, 407, inf},
                { inf, inf, inf, inf, inf, inf, inf, inf, inf, inf, inf, inf, inf, inf, inf, inf, 573, 407, 0, 329},
                { 407, inf, inf, inf, 617, inf, inf, inf, inf, inf, inf, inf, inf, inf, inf, inf, inf, inf, 329, 0}
                };

                return distances;
            }
        }
    }
}
