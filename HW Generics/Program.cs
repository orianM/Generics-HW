using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 1

            //int[] intArr1 = { 2, 6, 8, 10 };
            //int[] intArr2 = { 12, 14, 16, 18 };

            //string[] stringArr1 = { "Hello", "There" };
            //string[] stringArr2 = { "What's", "The time" }; 

            //Combine<int>(intArr1, intArr2);

            //Combine<string>(stringArr1, stringArr2);

            #endregion

            #region Exercise 2

            //GenericReadOnly<int> myInt1 = new GenericReadOnly<int>(true); // throws InvalidOperationException
            ////myInt1.Add(3);
            //GenericReadOnly<int> myInt2 = new GenericReadOnly<int>(false); // gets added to collection
            //myInt2.Add(5);

            //GenericReadOnly<string> myString1 = new GenericReadOnly<string>(false); // gets added to collection
            //myString1.Add("Hello");
            //GenericReadOnly<string> myString2 = new GenericReadOnly<string>(true); // throws InvalidOperationException
            //myString2.Add("Goodbye");



            #endregion

            #region Exercise 3

            //char[] myCharArr = { 'D', 'A', 'H', 'G', 'F' };
            //double[] myDoubleArr = { 2.0, 7.84, 4.5, 9.99, 8.7 };

            //SortedStructCollection<char> sortMyCharArr = new SortedStructCollection<char>();
            //sortMyCharArr.Add(myCharArr);
            //SortedStructCollection<double> sortMyDoubleArr = new SortedStructCollection<double>();
            //sortMyDoubleArr.Add(myDoubleArr);

            #endregion

            #region Exercise 4

            //Person p1 = new Person(); // creates a person
            //p1 = GenericWithId<Person>.CreatClassWithId(p1); // assigns id to person

            //Student s1 = new Student(); // creates a student
            //s1 = GenericWithId<Student>.CreatClassWithId(s1); // assigns id to student

            //Teacher t1 = new Teacher(); // creates a teacher
            //t1 = GenericWithId<Teacher>.CreatClassWithId(t1); // assigns id to teacher

            #endregion

            #region Exercise 7

            //myPetCat cat = new myPetCat("Steve");
            //myPetDog dog = new myPetDog("Kevin");
            //myPetFish fish = new myPetFish("Josh");

            //GenericWithName<myPetCat>.PrintTypeAndName(cat);
            //GenericWithName<myPetDog>.PrintTypeAndName(dog);
            //GenericWithName<myPetFish>.PrintTypeAndName(fish);

            #endregion
        }

        #region Exercise 1 method

        /// <summary>
        /// Merges two arrays of the same type into one array
        /// And returns the combined array
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="param1"></param>
        /// <param name="param2"></param>
        public static void Combine<T>(T[] param1, T[] param2)
        {
            T[] combined = new T[param1.Length + param2.Length];
            param1.CopyTo(combined, 0);
            param2.CopyTo(combined, param1.Length);

            foreach (T arrayElement in combined)
            {
                Console.Write($"{arrayElement}\t");
            }
            Console.WriteLine("\n");
        }

        #endregion
    }
}
