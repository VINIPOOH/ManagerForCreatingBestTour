using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerForCreatingBestTour
{
    class BinaryTree 
    {
        private Node root;
        public int count { get; set; }

        public BinaryTree()
        {
            this.root = null;
            count = 0;
        }

        public bool isEmpty()
        {
            return (root == null);
        }

        public void insert(City value)
        {
            Hideninsert(GetHash(value),value);
        }

        private void Hideninsert(int key , City value)
        {
            if (isEmpty())
            {
                this.root = new Node (key , value);
            }
            else
            {
                this.root.insertValue(ref this.root, key, value);
            }

            count++;
        }

        public bool search(City city)
        {
            return (HidenSearch(GetHash(city)));
        }

        private bool HidenSearch(int key)
        {
            return (root.search(root, key));
        }

        public void show()
        {
            if (!isEmpty())
            {
                root.show(root);
            }
        }
        //code imported from Tree.cs
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
        //


        class Node
        {
            private int key;
            private City value;
            public Node leftLeaf, rightLeaf;

            public Node (int key , City value)
            {
                this.key = key;
                this.value = value;
                leftLeaf = null;
                rightLeaf = null;
            }

            public bool isLeaf(Node node)
            {
                return (node.rightLeaf == null && node.leftLeaf == null);
            }

            public  void insertValue(ref Node node , int key , City value)
            {
                if(node == null)
                {
                    node = new Node(key,value);
                }
                else if (node.key < key)
                {
                    insertValue(ref node.rightLeaf, key, value);
                }
                else if (node.key > key)
                {
                    insertValue(ref node.leftLeaf, key , value);
                }
            }

            public bool search(Node node , int toSearch)
            {
                if(node == null)
                {
                    return false;
                }
                else if (node.key < toSearch)
                {
                    return (search(node.rightLeaf, toSearch));
                }
                else if  (node.key > toSearch)
                {
                    return (search(node.leftLeaf, toSearch));
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
