using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerForCreatingBestTour
{
    public class BinaryTree 
    {
        private Node root;
        public int Count { get; set; }

        public BinaryTree(int weightAmountPeopless, int weightAmountPeoplesLes20s)
        {
            this.root = null;
            Count = 0;
            this.weightAmountPeoples = weightAmountPeopless;
            this.weightAmountPeoplesLes20 = weightAmountPeoplesLes20s;
        }
        private const int constant = 31;
        private int weightAmountPeoples;
        private int weightAmountPeoplesLes20;

        public bool IsEmpty()
        {
            return (root == null);
        }

        public void Insert(City value)
        {
            Hideninsert(GetHash(value),value);
        }

        private void Hideninsert(int key , City value)
        {
            if (IsEmpty())
            {
                this.root = new Node (key , value);
            }
            else
            {
                this.root.InsertValue(ref this.root, key, value);
            }

            Count++;
        }

        public bool Search(City city)
        {
            return (HidenSearch(GetHash(city)));
        }

        private bool HidenSearch(int key)
        {
            return (root.Search(root, key));
        }

        public void show()
        {
            if (!IsEmpty())
            {
                root.show(root);
            }
        }
        //code imported from Tree.cs (and changed by sany_nikonov)
        
        

        public int GetHash(City city)
        {
            int toReturn = city.AmountPeople * constant * weightAmountPeoples + city.AmountPeopleYoungerTwenty * constant* weightAmountPeoplesLes20;
            return toReturn;
        }

        public TwoWayLinkedList BestCitiesByPopulation(int minPopulation, int maxPopulation, int citiesQuantity)
        {
            TwoWayLinkedList cities = new TwoWayLinkedList();
            HiddenBestCitiesByPopulation(minPopulation, maxPopulation, ref citiesQuantity, cities, root);
            return cities;
        }

        private void HiddenBestCitiesByPopulation(int minPopulation, int maxPopulation, ref int citiesQuantity, TwoWayLinkedList cities, Node node)
        {
            if (node.IsLeaf())
            {
                if (node.value.AmountPeople >= minPopulation && node.value.AmountPeople <= maxPopulation)
                {
                    if (citiesQuantity != 0)
                    {
                        cities.PushLast(node.value);
                        citiesQuantity--;
                    }
                    else
                    {
                        return;
                    }
                }
            }
            else
            {
                if (node.rightLeaf != null)
                {
                    HiddenBestCitiesByPopulation(minPopulation, maxPopulation, ref citiesQuantity, cities, node.rightLeaf);
                }
                if (node.value.AmountPeople >= minPopulation && node.value.AmountPeople <= maxPopulation)
                {
                    if (citiesQuantity != 0)
                    {
                        cities.PushLast(node.value);
                        citiesQuantity--;
                    }
                    else
                    {
                        return;
                    }
                }
                if (node.leftLeaf != null)
                {
                    HiddenBestCitiesByPopulation(minPopulation, maxPopulation, ref citiesQuantity, cities, node.leftLeaf);
                }
            }
        }

        public TwoWayLinkedList BestCitiesByPopulationYounger20(int minPopulation, int maxPopulation, int citiesQuantity)
        {
            TwoWayLinkedList cities = new TwoWayLinkedList();
            HiddenBestCitiesByPopulationYounger20(minPopulation, maxPopulation, ref citiesQuantity, cities, root);
            return cities;
        }

        private void HiddenBestCitiesByPopulationYounger20(int minPopulation, int maxPopulation, ref int citiesQuantity, TwoWayLinkedList cities, Node node)
        {
            if (node.IsLeaf())
            {
                if (node.value.AmountPeopleYoungerTwenty >= minPopulation && node.value.AmountPeopleYoungerTwenty <= maxPopulation)
                {
                    if (citiesQuantity != 0)
                    {
                        cities.PushLast(node.value);
                        citiesQuantity--;
                    }
                    else
                    {
                        return;
                    }
                }
            }
            else
            {
                if (node.rightLeaf != null)
                {
                    HiddenBestCitiesByPopulationYounger20(minPopulation, maxPopulation, ref citiesQuantity, cities, node.rightLeaf);
                }
                if (node.value.AmountPeopleYoungerTwenty >= minPopulation && node.value.AmountPeopleYoungerTwenty <= maxPopulation)
                {
                    if (citiesQuantity != 0)
                    {
                        cities.PushLast(node.value);
                        citiesQuantity--;
                    }
                    else
                    {
                        return;
                    }
                }
                if (node.leftLeaf != null)
                {
                    HiddenBestCitiesByPopulationYounger20(minPopulation, maxPopulation, ref citiesQuantity, cities, node.leftLeaf);
                }
            }
        }

        public TwoWayLinkedList GetBestCities(int citiesQuantity)
        {
            TwoWayLinkedList cities = new TwoWayLinkedList();
            HidddenRMLTraversal(ref citiesQuantity, cities, root);
            return cities;
        }

        private void HidddenRMLTraversal(ref int citiesQuantity, TwoWayLinkedList cities, Node node)
        {
            if (node.IsLeaf())
            {
                if (citiesQuantity != 0)
                {
                    cities.PushLast(node.value);
                    citiesQuantity--;
                }
                else
                {
                    return;
                }
            }
            else
            {
                if (node.rightLeaf != null)
                {
                    HidddenRMLTraversal(ref citiesQuantity, cities, node.rightLeaf);
                }
                if (citiesQuantity != 0)
                {
                    cities.PushLast(node.value);
                    citiesQuantity--;
                    if (node.leftLeaf != null)
                    {
                        HidddenRMLTraversal(ref citiesQuantity, cities, node.leftLeaf);
                    }
                }
                else
                {
                    return;
                }
            }
        }

        class Node
        {
            private int key;
            public City value;
            public Node leftLeaf, rightLeaf;

            public Node (int key , City value)
            {
                this.key = key;
                this.value = value;
                leftLeaf = null;
                rightLeaf = null;
            }

            public bool IsLeaf()
            {
                return (rightLeaf == null && leftLeaf == null);
            }

            public void InsertValue(ref Node node , int key , City value)
            {
                if(node == null)
                {
                    node = new Node(key,value);
                }
                else if (node.key < key)
                {
                    InsertValue(ref node.rightLeaf, key, value);
                }
                else if (node.key > key)
                {
                    InsertValue(ref node.leftLeaf, key , value);
                }
            }

            public bool Search(Node node , int toSearch)
            {
                if(node == null)
                {
                    return false;
                }
                else if (node.key < toSearch)
                {
                    return (Search(node.rightLeaf, toSearch));
                }
                else if  (node.key > toSearch)
                {
                    return (Search(node.leftLeaf, toSearch));
                }
                else //if (node.key == toSearch)
                {
                    return (true);
                }
            }

            public void show(Node node)
            {
                if(node == null)
                {
                    return;
                }

                show(node.leftLeaf);
                Console.Write(" " + node.key);
                show(node.rightLeaf);
            }

        }
        
    }
}
