using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerForCreatingBestTour
{
    public class City
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
        // Повторение 10-ой лабки 
        // Повторение мать учения
        public static bool operator true(City city)
        {
            if (city.Name == null && city.AmountPeople == 0 && city.AmountPeopleYoungerTwenty == 0)
                return true;
            return false;
        }   
        
        public static bool operator false(City city)
        {
            if (city.Name == null && city.AmountPeople != 0 && city.AmountPeopleYoungerTwenty != 0)
                return true;
            return false;
        }
        public string DeadCity(City city)
        {
            if (city) { return "Это город мёртвых! АААААААА"; }
            else return " Нормальненький такой город)";
        } 
    }
}
