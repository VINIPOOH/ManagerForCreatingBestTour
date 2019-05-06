using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerForCreatingBestTour
{
    public class Tree
    {
        private int AmountPeopleYoungerTwenty;
        private int AmountPeople;
        private int constant = 31;

        public void BTree(int people, int peopleTwenty)
        {
            AmountPeopleYoungerTwenty = peopleTwenty;
            AmountPeople = people;
        }
        public int GetHash(City city)
        {
            int toReturn = city.AmountPeople * this.AmountPeople * constant + city.AmountPeopleYoungerTwenty * this.AmountPeopleYoungerTwenty * constant;
            return toReturn;
        }
            

    }
}
