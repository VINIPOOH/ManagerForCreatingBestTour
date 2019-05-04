using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerForCreatingBestTour
{

    public class TwoWayLinkedList : IEnumerable<City>
    {

        public class Node
        {

            public City data;
            public Node pNext;
            public Node pPrev;

            public Node(City data, Node pNext = null, Node pPrev = null)
            {
                this.data = data;
                this.pNext = pNext;
                this.pPrev = pPrev;
            }

        }
        public TwoWayLinkedList()
        {
            Size = 0;
            head = null;
            last = null;
        }
        //добавление элемента в начало списка
        public void PushFirst(City data)
        {
            if (head == null)
            {
                head = new Node(data, null, null);
                last = head; 
                Size++;
            }
            else
            {
                Node link = new Node(data, head, null);//в сылку мы передаем голову	
                head.pPrev = link;
                head = link;
                //last = link.pNext;
                Size++;
                //if (Size == 2 )
                //{
                    
                //    last = link.pNext;
                //}
            }

        }

        //добавление элемента в список по указанному индексу
        public void PushMidle(City data, int index)
        {
            if (index == 0)
            {
                PushFirst(data);
            }
            else if (index == Size)
            {
                PushLast(data);
            }
            else if ((Size - 1) / 2 >= index)
            {
                Node link = this.head;
                for (int i = 0; i < index - 1; i++)
                {

                    link = link.pNext;
                }
                Node newNode = new Node(data, link.pNext, link);
                Node link2 = link.pNext;
                link.pNext = newNode;
                link2.pPrev = newNode;
                Size++;
            }

            else
            {
                Node link = this.last;
                for (int i = Size - 1; i > (index); i--)
                {
                    link = link.pPrev;
                }
                Node newNode = new Node(data, link, link.pPrev);
                Node link2 = link.pPrev;
                link.pPrev = newNode;
                link2.pNext = newNode;
                Size++;
            }
        }

        //добавление элемента в конец списка
        public void PushLast(City data)
        {

            if (head == null && last == null)
            {
                PushFirst(data);
            }
            else if (last == null)
            {
                Node link = new Node(data, null, head);
                head.pNext = link;
                last = link;
                Size++;
                Console.WriteLine("das;dasdad");
               
            }
            else
            {
                //Node<T> *link = this->last;
                last.pNext = new Node(data, null, last);
                last = last.pNext;
                Size++;
            }
        }

        //удаление первого элемента в списке
        public void DelFirst()
        {
            Node link = head;
            head = link.pNext;
            Size--;
        }

        //удаление элемента в списке по указанному индексу
        public void DelMidle(int index)
        {
            if (index == 0)
            {
                DelFirst();
            }
            else if (index == (Size - 1))
            {
                DelLast();
            }
            else if ((Size - 1) / 2 >= index)
            {
                Node link = this.head;
                for (int i = 0; i < index - 1; i++)
                {
                    link = link.pNext;

                }
                Node toDelete = link.pNext;
                Node link2 = toDelete.pNext;
                link.pNext = link2;
                link2.pPrev = link;
                Size--;
            }
            else
            {
                Node link = this.last;

                for (int i = Size - 1; i > index + 1; i--)
                {
                    link = link.pPrev;
                }
                Node toDelete = link.pPrev;
                Node link2 = toDelete.pPrev;
                link.pPrev = link2;
                link2.pNext = link;
                Size--;
            }
        }

        //удаление последнего элемента в списке
        public void DelLast()
        {

            if (Size == 1)
            {
                head = null;
                last = null;
                Size--;
            }
            else
            {
                Node link = last;
                last = link.pPrev;
                last.pNext = null;
                Size--;
            }
        }

        public int IndexOf(City city)
        {
            int index = 0;
            Node node = head;
            while (index != Size)
            {
                if (city.Name == node.data.Name) return index;
                node = node.pNext;
                index++;
            }
            throw new Exception("There is no such element");
        }

        public bool Contains(City city)
        {
            Node node = head;
            int index = 0;
            while (index != Size)
            {
                if (city.Name == node.data.Name) return true;
                node = node.pNext;
                index++;
            }
            return false;
        }

        //заменить первый
        public void ReplaceFirst(City data)
        {
            head.data = data;
        }

        //заменить средний
        public void ReplaceMidle(City data, int index)
        {
            if (index == (Size - 1))
            {
                last.data = data;
            }
            else if (index == 0)
            {
                head.data = data;
            }
            else if ((Size - 1) / 2 >= index)
            {

                Node previous = this.head;
                for (int i = 0; i < index; i++)
                {
                    previous = previous.pNext;
                }
                previous.data = data;
            }
            else
            {
                Node previous = this.last;
                for (int i = Size - 1; i > index; i--)
                {
                    previous = previous.pPrev;
                }
                previous.data = data;
            }
        }

        //заменить последний
        public void ReplaceLast(City data)
        {
            last.data = data;
        }
        // очистить список
        public void Clear() {
            while (Size > 0)
            {
                Node link = head;
                head = link.pNext;

                Size--;
            }
        }

        public City Find(string data)
        {

            Node link = this.head;

            for (int i = 0; i < Size; i++)
            {
                if (link.data.Name == data)
                {
                    return link.data;
                }
                link = link.pNext;
            }
            return new City(null, 0, 0);//почемуто возвращает -112. решено....
        }

        public IEnumerable<City> BackEnumerator()
        {
            Node current = last;
            while (current != null)
            {
                yield return current.data;
                current = current.pPrev;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<City> IEnumerable<City>.GetEnumerator()
        {
            Node current = head;
            while (current != null)
            {
                yield return current.data;
                current = current.pNext;
            }
        }
      
        public void Concatenation(TwoWayLinkedList secondList)/// В этот метод передаёться список который надо добавить к 
            ///самому себе лист.конкатенация(лист2) 
        {
            // secondHead =  secondList.head;
            //Node secondTail = secondList.last;
            if(secondList.Size == 0)
            {
                
                return;
            }
            else if(this.Size == 0)
            {
                head = secondList.head;
                last = secondList.last;
            }
            this.last.pNext = secondList.head;
            this.last = secondList.last;
        }

        public void QuickSort()
        {
            Node pivot = this.last;
            //Node first = this.head;
            if(this.Size > 1)
            {
                TwoWayLinkedList listMorePivot = new TwoWayLinkedList();
                TwoWayLinkedList listLessPivot = new TwoWayLinkedList();
                foreach (City city in this)
                {
                    if (city == this.last.data)
                    {
                        break;
                    }
                    if (city.AmountPeople >= pivot.data.AmountPeople)
                    {
                        listMorePivot.PushFirst(city);
                    }
                    else
                    {
                        listLessPivot.PushFirst(city);
                    }
                }

                listMorePivot.QuickSort();
                listLessPivot.QuickSort();
                
                listLessPivot.PushLast(pivot.data);
                listLessPivot.Concatenation(listMorePivot);
                 
                this.head = listLessPivot.head;
                this.last = listLessPivot.last; // присваевается концу списка меньших за опорный ибо после конкатенации в списке меньших за опроный 
                // находится уже сума списков больших и меньших за опроных, а список больших остаеться быть таким же и иногода он может  быть пустым.
                
            }
        }

        // получить количество елементов в списке
        public int GetSize() { return Size; }
        public City Getlast() { return last.data; }
        public City GetFirst() { return head.data; }
        // перегруженный оператор [] 
        //City& operator[] (const int index);
        int Size;
        public Node head;
        public Node last;
    }
}


        
        

       
       






  


     


