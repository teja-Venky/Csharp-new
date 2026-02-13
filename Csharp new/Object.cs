//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Csharp_new
//{
//    internal class Object
//    {
        //        //program1: Person is the type and person1 and person2 are instances, or objects, of that type.
        //        //Struct Instances vs. Class Instances
        //        //public class Person(string name, int age)
        //        //{
        //        //    public string Name { get; set; } = name;
        //        //    public int Age { get; set; } = age;
        //        //    // Other properties, methods, events...
        //        //}

        //        //class Program
        //        //{
        //        //    static void Main()
        //        //    {
        //        //        Person person1 = new("Leopold", 6);
        //        //        Console.WriteLine($"person1 Name = {person1.Name} Age = {person1.Age}");

        //        //        // Declare new person, assign person1 to it.
        //        //        Person person2 = person1;

        //        //        // Change the name of person2, and person1 also changes.
        //        //        person2.Name = "Molly";
        //        //        person2.Age = 16;

        //        //        Console.WriteLine($"person2 Name = {person2.Name} Age = {person2.Age}");
        //        //        Console.WriteLine($"person1 Name = {person1.Name} Age = {person1.Age}");


        //        //    }
        //        //}

        //        //program2: Instances of structs can also be created by using the new operator, but this isn't required, as shown in the following example:


        //        //Struct Instances vs. Class Instances


        //        public struct Person
        //        {
        //            public string Name;
        //            public int Age;
        //            public Person(string name, int age)
        //            {
        //                Name = name;
        //                Age = age;
        //            }
        //        }

        //        public class Application
        //        {
        //            static void Main()
        //            {
        //                // Create  struct instance and initialize by using "new".
        //                // Memory is allocated on thread stack.
        //                //Person p1 = new("Alex", 9);
        //                //Console.WriteLine($"p1 Name = {p1.Name} Age = {p1.Age}");

        //                //// Create  new struct object. Note that  struct can be initialized
        //                //// without using "new".
        //                //Person p2 = p1;

        //                //// Assign values to p2 members.
        //                //p2.Name = "Spencer";
        //                //p2.Age = 7;
        //                //Console.WriteLine($"p2 Name = {p2.Name} Age = {p2.Age}");

        //                //// p1 values remain unchanged because p2 is  copy.
        //                //Console.WriteLine($"p1 Name = {p1.Name} Age = {p1.Age}");




        //                //program3: Object Identity vs. Value Equality...call the method directly on your object as shown in the following example:

        //                // Person is defined in the previous example.

        //                //public struct Person(string name, int age)
        //                //{
        //                //    public string Name { get; set; } = name;
        //                //    public int Age { get; set; } = age;
        //                //}

        //                Person p1 = new("Wallace", 75);
        //                Person p2 = new("", 42);
        //                p2.Name = "Wallace";
        //                p2.Age = 75;

        //                if (p2.Equals(p1))
        //                    Console.WriteLine("p2 and p1 have the same values.");

        //            }
        //        } 

        //program1:    Class Example Showing Reference Behavior Clearly


    //    class Person
    //{
    //    public string Name;
    //    public int Age;
    //}

    //class Program
    //{
    //    static void Main()
    //    {
    //        Person person1 = new Person { Name = "John", Age = 25 };
    //        Person person2 = person1;   // Reference copy

    //        person2.Age = 30;

    //        Console.WriteLine($"person1 Age = {person1.Age}");
    //        Console.WriteLine($"person2 Age = {person2.Age}");
    //    }
    //}

        //program2:  Struct Passed to Method (Value Copy Behavior)

       

//struct Person
//    {
//        public string Name;
//        public int Age;
//    }

//    class Program
//    {
//        static void Main()
//        {
//            Person p1 = new Person { Name = "Anna", Age = 20 };

//            ModifyPerson(p1);

//            Console.WriteLine($"After method call: {p1.Name}, {p1.Age}");
//        }

//        static void ModifyPerson(Person p)
//        {
//            p.Name = "Changed";
//            p.Age = 99;
//        }
//    }

        // program3: struct passed using ref
       
//struct Person
//    {
//        public string Name;
//        public int Age;
//    }

//    class Program
//    {
//        static void Main()
//        {
//            Person p1 = new Person { Name = "David", Age = 40 };

//            ModifyPerson(ref p1);

//            Console.WriteLine($"After method call: {p1.Name}, {p1.Age}");
//        }

//        static void ModifyPerson(ref Person p)
//        {
//            p.Name = "Updated";
//            p.Age = 50;
//        }
////    }
//}
//}

