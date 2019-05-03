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
                new City("Berlin", 3000000, 0),
                new City("Kiev", 2000000, 0),
                new City("Minsk", 500000, 0),
                new City("Vien", 1000000, 0),
                new City("Prague", 700000, 0),
                new City("Warsaw", 1500000, 0),
                new City("Budapesht", 600000, 0)
            };

            return cities;
        }

        public static int[,] Distances()
        {
            int inf = int.MaxValue;
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
