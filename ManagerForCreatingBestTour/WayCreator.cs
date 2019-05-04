using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerForCreatingBestTour
{
    public class WayCreator
    {
        int[,] matrix = CitiesInfo.Distances();

        public int[] Dijkstra(int[,] matrix, int startCityIndex)
        {
            int citiesNumber = matrix.GetLength(0);

            int[] weight = new int[citiesNumber];

            bool[] isValid = new bool[citiesNumber];

            for (int i = 0; i < citiesNumber; i++)
            {
                isValid[i] = true;
            }
            for (int i = 0; i < citiesNumber; i++)
            {
                weight[i] = int.MaxValue/2;
            }

            weight[startCityIndex] = 0;

            int minWeight;
            int minVortex;
            for (int i = 0; i < citiesNumber; i++)
            {
                minWeight = int.MaxValue/2;
                minVortex = -1;
                for (int j = 0; j < citiesNumber; j++)
                {
                    if (weight[j] < minWeight && isValid[j])
                    {
                        minWeight = weight[j];
                        minVortex = j;
                    }
                }
                for (int j = 0; j < citiesNumber; j++)
                {
                    if (weight[minVortex] + matrix[minVortex, j] < weight[j])
                    {
                        weight[j] = weight[minVortex] + matrix[minVortex, j];
                    }
                }
                isValid[minVortex] = false;
            }
            return weight;
        }

        private int MinDistanceIndex(int[] array, TwoWayLinkedList chosenCities)
        {
            int minValue = int.MaxValue;
            int minIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < minValue && array[i] != 0 && chosenCities.Contains(CitiesInfo.Cities()[i]))
                {
                    minIndex = i;
                    minValue = array[i];
                }
            }
            return minIndex;
        }

        public TwoWayLinkedList GetRoute(TwoWayLinkedList chosenCities, City startPoint)
        {
            /*
             * LIST chosenCities SHOULDN'T CONTAIN STARTPOINT
             */
            City currentCity = startPoint;

            int currentCityIndex = 0;

            int[] distanceFromCurrentCity;

            City nearestNeighbour;

            int nearestNeighbourIndex;

            TwoWayLinkedList route = new TwoWayLinkedList();

            while (chosenCities.GetSize() != 0)
            {
                for (int i = 0; i < CitiesInfo.Cities().Length; i++)
                {
                    if (currentCity.Name == CitiesInfo.Cities()[i].Name)
                    {
                        currentCityIndex = i;
                    }
                }
                distanceFromCurrentCity = Dijkstra(CitiesInfo.Distances(), currentCityIndex);
                nearestNeighbourIndex = MinDistanceIndex(distanceFromCurrentCity, chosenCities);
                nearestNeighbour = CitiesInfo.Cities()[nearestNeighbourIndex];
                route.PushLast(nearestNeighbour);
                chosenCities.DelMidle(chosenCities.IndexOf(nearestNeighbour));
                currentCity = nearestNeighbour;
            }
            route.PushFirst(startPoint);
            return route;
        }
    }
}
