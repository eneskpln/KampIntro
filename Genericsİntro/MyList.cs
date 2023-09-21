using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericsİntro
{
    internal class MyList<T>
    {
        T[] items;
        //Constructor yapısı
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item) 
        {
            T[] tempArray = items;//Geçici array ram içerisinde elemanların kaybolmasını engellemek için yazdık.
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            
            items[items.Length - 1] = item;
        }




    }
}
