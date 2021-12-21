using System;

namespace Generic_List
{
    public class GenericList<T>
    {
        public T[] GenList;
        private static int itemsAdded = 0;

        public static int ItemsAdded { get => itemsAdded; set => itemsAdded = value; }
        public GenericList(int i)
        {
            GenList = new T[i];
        }
        public void AddItem(T item)
        {
            if (itemsAdded == GenList.Length)
            {
                GenericList<T> tempList = new GenericList<T>(GenList.Length + 1);
                int index = 0;
                foreach (T listItem in this.GenList)
                {
                    
                    tempList.GenList[index] = this.GenList[index];
                    index++;
                }
                this.GenList = tempList.GenList;
            }
           
            for (int i = ItemsAdded; i < GenList.Length; i++ )
            {
                if (ItemsAdded == i)
                {
                    GenList[i] = item;                                       
                    break;
                }
            }
            ItemsAdded++;
        }
        public T IndexSearch(int index)
        {
            return this.GenList[index];
        }
        public void RemoveItem(int index)
        {
            GenericList<T> templist = new GenericList<T>(GenList.Length - 1);
            int i = 0;
            int offset = 0;
            foreach (T listItem in templist.GenList)
            {
                if (i == index)
                {
                    offset++;
                    templist.GenList[i] = this.GenList[i + offset];
                }
                else
                {
                    templist.GenList[i] = this.GenList[i + offset];
                }

                i++;
            }
            this.GenList = templist.GenList;
            itemsAdded--;
        }
        public void InsertItemAtIndex(T item, int index)
        {
            GenericList<T> templist = new GenericList<T>(GenList.Length + 1);
            int i = 0;
            int offset = 0;
            foreach (T listItem in templist.GenList)
            {
                if (i == index)
                {
                    offset++;
                    templist.GenList[i] = item;
                }
                else
                {
                    templist.GenList[i] = this.GenList[i - offset];
                }

                i++;
            }
            this.GenList = templist.GenList;
            itemsAdded++;
        }
        public int ValueSearch(T item)
        {
            return Array.IndexOf(this.GenList, item);
        }
        public void ClearList()
        {
            this.GenList = new T[0];
            ItemsAdded = 0;
        }
        public override string ToString()
        {
            string itemsInList = "";
            foreach (T item in this.GenList)
            {
                itemsInList += item;
            }
            return itemsInList;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> numList = new GenericList<int>(3);
            numList.AddItem(1);
            numList.AddItem(2);
            numList.AddItem(3);
            numList.AddItem(4);
            numList.AddItem(5);
            numList.AddItem(6);
            //numList.RemoveItem(2);
            //numList.RemoveItem(5);
            numList.InsertItemAtIndex(8, 3);
            numList.ClearList();
            Console.WriteLine("List Cleared");
            numList.AddItem(1);

            foreach (int num in numList.GenList)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine(numList.ValueSearch(8));

            Console.WriteLine();
        }
    }
}
