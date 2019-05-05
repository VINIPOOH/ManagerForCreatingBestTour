using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerForCreatingBestTour
{
    public class WayCreator
    {
        public readonly TwoWayLinkedList[] intermediateCities = new TwoWayLinkedList[CitiesInfo.Cities().Length];

        private class Vertex
        {
            public int Weight { get; set; }
            public TwoWayLinkedList Route { get; set; }
            public bool IsValid { get; set; }
            public Vertex(int weight, bool isValid)
            {
                Weight = weight;
                IsValid = isValid;
                Route = new TwoWayLinkedList();
            }
        }

        private TwoWayLinkedList CopyList(TwoWayLinkedList list)
        {
            TwoWayLinkedList copy = new TwoWayLinkedList();
            foreach (City city in list)
            {
                copy.PushLast(city);
            }
            return copy;
        }

        public int[] Dijkstra(int[,] matrix, int startCityIndex)
        {
            int citiesNumber = matrix.GetLength(0);

            Vertex[] vertices = new Vertex[citiesNumber];

            for (int i = 0; i < citiesNumber; i++)
            {
                vertices[i] = new Vertex(int.MaxValue / 2, true);
                vertices[i].Route.PushFirst(CitiesInfo.Cities()[startCityIndex]);
            }

            vertices[startCityIndex].Weight = 0;
            //vertices[startCityIndex].Route.PushFirst(CitiesInfo.Cities()[startCityIndex]);

            int minWeight;

            int minVertex;

            for (int i = 0; i < citiesNumber; i++)
            {
                minWeight = int.MaxValue/2;
                minVertex = -1;
                for (int j = 0; j < citiesNumber; j++)
                {
                    if (vertices[j].Weight < minWeight && vertices[j].IsValid)
                    {
                        minWeight = vertices[j].Weight;
                        minVertex = j;
                    }
                }
                for (int j = 0; j < citiesNumber; j++)
                {
                    if (vertices[minVertex].Weight + matrix[minVertex, j] < vertices[j].Weight)
                    {
                        vertices[j].Weight = vertices[minVertex].Weight + matrix[minVertex, j];
                        if (vertices[j].Route.GetSize() != 0) vertices[j].Route = CopyList(vertices[minVertex].Route);
                        if (minVertex != startCityIndex) vertices[j].Route.PushLast(CitiesInfo.Cities()[minVertex]);
                    }
                }
                vertices[minVertex].IsValid = false;
            }

            int[] weight = new int[citiesNumber];

            for (int i = 0; i < citiesNumber; i++)
            {
                weight[i] = vertices[i].Weight;
                intermediateCities[i] = vertices[i].Route;
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

        private int FindCurrentCityIndex(City currentCity)
        {
            for (int i = 0; i < CitiesInfo.Cities().Length; i++)
            {
                if (currentCity.Name == CitiesInfo.Cities()[i].Name)
                {
                    return i;
                }
            }
            throw new Exception("Index wasn't found");
        }

        private TwoWayLinkedList ClearRepetitions(TwoWayLinkedList listWithRepetetives)
        {
            /*
             * Unfortunately, GetRoute method has some issues. It creates necessary list, it's already good,
             * but also contains some repetetive cities. This problem isn't fatal, so this method was created
             * to fix it.
             */
            TwoWayLinkedList list = new TwoWayLinkedList();
            City tmp = new City(".", 0, 0);
            foreach (City city in listWithRepetetives)
            {
                if (tmp.Name != city.Name)
                {
                    list.PushLast(city);
                    tmp = city;
                }
            }
            return list;
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
                currentCityIndex = FindCurrentCityIndex(currentCity);
                distanceFromCurrentCity = Dijkstra(CitiesInfo.Distances(), currentCityIndex);
                nearestNeighbourIndex = MinDistanceIndex(distanceFromCurrentCity, chosenCities);
                nearestNeighbour = CitiesInfo.Cities()[nearestNeighbourIndex];
                route.Concatenation(intermediateCities[nearestNeighbourIndex]);
                route.PushLast(nearestNeighbour);
                chosenCities.DelMidle(chosenCities.IndexOf(nearestNeighbour));
                currentCity = nearestNeighbour;
            }
            return ClearRepetitions(route);
        }

        public int[] DijkstraSave(int[,] matrix, int startCityIndex)
        {
            int citiesNumber = matrix.GetLength(0);

            Vertex[] vertices = new Vertex[citiesNumber];

            int[] weight = new int[citiesNumber];

            bool[] isValid = new bool[citiesNumber];

            for (int i = 0; i < citiesNumber; i++)
            {
                vertices[i] = new Vertex(int.MaxValue / 2, true);
            }

            vertices[startCityIndex].Weight = 0;
            weight[startCityIndex] = 0;

            int minWeight;
            int minVortex;
            for (int i = 0; i < citiesNumber; i++)
            {
                minWeight = int.MaxValue / 2;
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
    }
}
