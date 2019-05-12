using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManagerForCreatingBestTour;

namespace ProjectForTest
{
    class TestMain
    {
        static void BinaryTree_GetBestCities_Test()
        {
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.Insert(CitiesInfo.Cities()[2]);
            binaryTree.Insert(CitiesInfo.Cities()[3]);
            binaryTree.Insert(CitiesInfo.Cities()[4]);
            binaryTree.Insert(CitiesInfo.Cities()[5]);
            
            TwoWayLinkedList cities = binaryTree.GetBestCities(2);
            foreach (City city in cities)
            {
                Console.WriteLine(city.ToString());
            }
            Console.WriteLine();

            binaryTree.Insert(CitiesInfo.Cities()[0]);
            binaryTree.Insert(CitiesInfo.Cities()[1]);

            TwoWayLinkedList cities1 = binaryTree.GetBestCities(4);
            foreach (City city in cities1)
            {
                Console.WriteLine(city.ToString());
            }
        }

        static void DijkstraTest()
        {
            WayCreator wayCreator = new WayCreator();
            City[] cities = CitiesInfo.Cities();
            int[,] distances = CitiesInfo.Distances();

            int[] citiesWeight = wayCreator.Dijkstra(distances, 3);

            for (int i = 0; i < cities.Length; i++)
            {
                Console.WriteLine(cities[i].Name + " " + citiesWeight[i]);
            }

            int index = 1;

            foreach (TwoWayLinkedList list in wayCreator.intermediateCities)
            {
                Console.Write(index++.ToString() + ". ");
                foreach (City city in list)
                {
                    Console.Write(city.Name + " ");
                }
                Console.WriteLine();
            }
        }

        static void GetRouteTest()
        {
            WayCreator wayCreator = new WayCreator();
            TwoWayLinkedList chosenCities = new TwoWayLinkedList();
            City startPoint = CitiesInfo.Cities()[0]; // Berlin
            chosenCities.PushLast(CitiesInfo.Cities()[1]); // Kiev
            chosenCities.PushLast(CitiesInfo.Cities()[6]); // Budapesht
            chosenCities.PushLast(CitiesInfo.Cities()[2]); // Minsk
            //chosenCities.PushLast(CitiesInfo.Cities()[3]); // Warsaw
            chosenCities.PushLast(CitiesInfo.Cities()[5]); // Vien
            chosenCities.PushLast(CitiesInfo.Cities()[4]); // Prague
            TwoWayLinkedList route = wayCreator.GetRoute(chosenCities, startPoint);
            int index = 1;
            foreach (City city in route)
            {
                Console.WriteLine(index++.ToString() + ". " + city.Name);
            }
        }

        static void TwoWayLinkedListTest()
        {
            City city1 = new City("1", 9, 4);
            City city2 = new City("2", 14, 8);
            City city3 = new City("3", 231, 2);
            City city4 = new City("4", 2, 4);
            TwoWayLinkedList tl = new TwoWayLinkedList();
            tl.PushLast(city1);
            //Console.WriteLine(tl.last.data.Name + "dasda");
            tl.PushLast(city2);
            //Console.WriteLine(tl.last.data.Name + "dasda");
            tl.PushLast(city3);
            //Console.WriteLine(tl.last.data.Name + "dasda");
            tl.PushLast(city4);
            //Console.WriteLine(tl.last.data.Name + "dasda");
            TwoWayLinkedList lst = new TwoWayLinkedList();
            City city5 = new City("5", 3, 4);
            City city6 = new City("6", 5, 8);
            City city7 = new City("7", 26, 2);
            City city8 = new City("8", 23, 4);
            lst.PushLast(city5);
            lst.PushLast(city6);
            lst.PushLast(city7);
            lst.PushLast(city8);
            lst.Concatenation(tl);
            //lst.PushLast(city1);

            //tl.Concatenation(lst);
            //Console.WriteLine(tl.last.data.Name + "dasda");
            //Console.WriteLine(tl.head.data.Name + "dasda");
            //tl.Concatenation(tl, lst);

            //foreach (var item in tl)
            //{ 
            //   Console.WriteLine(item.Name);
            //   Console.WriteLine(tl.last.data.Name + "dasda");
            //}
            foreach (var item in lst)
            {
                Console.WriteLine(item.AmountPeople);
            }
            Console.WriteLine("dasda");
            lst.QuickSort();
            foreach (var item in lst)
            {
                Console.WriteLine(item.AmountPeople);
            }

            Console.WriteLine(tl.IndexOf(city2));
            Console.WriteLine(tl.Contains(city2));
            Console.WriteLine(tl.Contains(new City("popopo", 111, 222)));
            //Console.WriteLine(tl.head.data.Name);
            //TwoWayLinkedList empt = new TwoWayLinkedList();
            //TwoWayLinkedList empt2 = new TwoWayLinkedList();
            //TwoWayLinkedList help = new TwoWayLinkedList();





            //lst.Concatenation(tl);
            //lst.Concatenation(empt);
            //lst.Concatenation(help);

            //foreach (City item in lst)
            //{
            //   Console.WriteLine(item.AmountPeople);
            //}
        }

        static void Main(string[] args)
        {
            TwoWayLinkedListTest();
            Console.WriteLine();
            DijkstraTest();
            Console.WriteLine();
            GetRouteTest();
            Console.WriteLine();
            BinaryTree_GetBestCities_Test();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
