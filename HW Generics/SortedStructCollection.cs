using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Generics
{
    class SortedStructCollection<T> where T : struct
    {
        private T[] structArray;

        public void Add(T[] argArray)
        {
            structArray = argArray;
            Array.Sort(structArray);
        }
    }
}
