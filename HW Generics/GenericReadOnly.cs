using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Generics
{
    class GenericReadOnly<T>
    {
        public bool IsReadOnly { get; set; }
        private T[] Tcollection { get; set; } = new T[5];

        private static int Count = 0;

        public GenericReadOnly(bool isReadOnly)
        {
            IsReadOnly = isReadOnly;
        }

        public void Add(T someArg)
        {
            switch (IsReadOnly)
            {
                case true:
                    throw new InvalidOperationException("Not allowed to add while IsReadOnly == true");
                    break;
                case false:
                    Tcollection[Count] = someArg;
                    Count++;
                    break;
            }
        }
    }
}
