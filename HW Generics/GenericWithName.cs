using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Generics
{
    interface IName
    {
        string Name { get; set; }
    }

    class GenericWithName<T> where T : IName
    {

        public static void PrintTypeAndName(T someClass)
        {
            Console.WriteLine(someClass.GetType());
            Console.WriteLine(someClass.Name);
            Console.WriteLine();
        }
    }

    class myPetDog : IName
    {
        public string Name { get; set; }

        public myPetDog(string name)
        {
            this.Name = name;
        }
    }
    class myPetCat : IName
    {
        public string Name { get; set; }

        public myPetCat(string name)
        {
            this.Name = name;
        }
    }
    class myPetFish : IName
    {
        public string Name { get; set; }

        public myPetFish(string name)
        {
            this.Name = name;
        }
    }
}
