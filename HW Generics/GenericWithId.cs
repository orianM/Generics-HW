using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Generics
{
    class GenericWithId<T> where T : IId, new()
    {
        private int Id { get; set; }

        public static T CreatClassWithId(T classType)
        {
            T newInstance = new T();

            Random generateId = new Random();
            newInstance.Id = generateId.Next(100000000, 999999999);
            return newInstance;
        }
    }

    class Person : IId
    {
        public int Id { get; set; }
    }

    class Student : Person
    {

    }

    class Teacher : Person
    {

    }
}
