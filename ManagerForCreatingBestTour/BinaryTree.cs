using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class BinaryTree <T>
    {
        private Node<T> root;
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

        public void insert(int key , T value)
        {
            if (isEmpty())
            {
                this.root = new Node<T>(key , value);
            }
            else
            {
                this.root.insertValue(ref this.root, key, value);
            }

            count++;
        }

        public T search(int key)
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


        class Node<T>
        {
            private int key;
            private T value;
            public Node<T> leftLeaf, rightLeaf;

            public Node (int key , T value)
            {
                this.key = key;
                this.value = value;
                leftLeaf = null;
                rightLeaf = null;
            }

            public bool isLeaf(Node<T> node)
            {
                return (node.rightLeaf == null && node.leftLeaf == null);
            }

            public  void insertValue(ref Node<T> node , int key , T value)
            {
                if(node == null)
                {
                    node = new Node<T>(key,value);
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

            public T search(Node<T> node , int toSearch)
            {
                if(node == null)
                {
                    return default(T);
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
                    return (node.value);
                }
            }

            public void show(Node<T> node)
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
