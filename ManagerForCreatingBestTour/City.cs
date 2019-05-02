using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerForCreatingBestTour
{
    class City
    {
        public City(string name, int amountPeople, int amountPeopleYoungerTwenty)
        {
            Name = name;
            AmountPeople = amountPeople;
            AmountPeopleYoungerTwenty = amountPeopleYoungerTwenty;
        }

        public string Name { get; set; }
        public int AmountPeople { get; set; }
        public int AmountPeopleYoungerTwenty { get; set; }
    }
}
