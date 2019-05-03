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
        static void Main(string[] args)
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
            Console.ReadLine();
        }
    }
}
