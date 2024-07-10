using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_7_generic
{
    public class MySelfCreatedList<T>
    {
        private T[] MyArray { get; set; }
        private int Index = 0;
        private int Size = 1;

        public MySelfCreatedList()
        {
            MyArray = new T[Size];
        }

        public void AddElement(T element)
        {
            if (CheckIfFull())
            {
                MyArray = IncreaseListSize();
            }
            if (element != null)
            {
                MyArray[Index] = element;
                Index++;
            }
            else
            {
                throw new ArgumentNullException(nameof(element));
            }
        }
        public void RemoveElement(T element)
        {
            if (element != null)
            {
                for (int i = 0; i < MyArray.Length; i++)
                {
                    if (MyArray[i].Equals(element))
                    {
                        MyArray[i] = default(T);
                        MyArray = DecreaseListSize();
                        Index--;
                    }
                }
            }
            else
            {
                throw new ArgumentNullException(nameof(element));
            }
        }
        public bool CheckIfFull()
        {
            if (Index == Size)
            {
                return true;
            }
            else 
                return false;
        }
        private T[] IncreaseListSize()
        {
            Size += 1 ;
            var newArray = new T[Size];
            MyArray.CopyTo(newArray, 0);
            return newArray;
        }
        private T[] DecreaseListSize()
        {
            Size -= 1;
            var newArray = new T[Size];
            int newArrayIndex = 0;
            for (int i = 0; i < MyArray.Length; i++)
            {
                if (MyArray[i] != null)
                {
                    newArray[newArrayIndex] = MyArray[i];
                    newArrayIndex++;
                }
            }
            return newArray;
        }
    }
}
