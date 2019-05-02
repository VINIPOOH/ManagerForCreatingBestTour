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

            City city1 = new City("1", 10, 4);
            City city2 = new City("2", 13, 8);
            City city3 = new City("3", 16, 2);
            City city4 = new City("4", 22, 4);
            TwoWayLinkedList tl = new TwoWayLinkedList();
            tl.PushLast(city1);
            tl.PushFirst(city3);
            tl.PushFirst(city4);
            tl.PushMidle(city2, 3);
            
            //tl.DelFirst();
            //tl.DelLast();
            
            foreach (var item in tl)
            {
                Console.WriteLine(item.Name);
            }

            //Console.WriteLine(tl.head.data.Name);
            Console.ReadLine();




         
        }
    }
}
