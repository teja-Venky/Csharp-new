////using System;
////using System.Collections.Generic;
////using System.Linq;
////using System.Text;
////using System.Threading.Tasks;

////namespace Csharp_new
////{
////    internal class Record
////    {
//        //        //program1: defines a public record that uses positional parameters to declare and instantiate a record. It then prints the type name and property values:
//        //        //public record Person(string FirstName, string LastName);

//        //        //public static class Program
//        //        //{
//        //        //    public static void Main()
//        //        //    {
//        //        //        Person person = new("Nancy", "Davolio");
//        //        //        Console.WriteLine(person);
//        //        //                               // output: Person { FirstName = Nancy, LastName = Davolio }
//        //        //    }

//        //      //  }

//        //        //program2: demonstrates value equality in records:

//        //        //public record Person(string FirstName, string LastName, string[] PhoneNumbers);
//        //        //public static class Program
//        //        //{
//        //        //    public static void Main()
//        //        //    {
//        //        //        var phoneNumbers = new string[2];
//        //        //        Person person1 = new("Nancy", "Davolio", phoneNumbers);
//        //        //        Person person2 = new("Nancy", "Davolio", phoneNumbers);
//        //        //        Console.WriteLine(person1 == person2); // output: True

//        //        //        person1.PhoneNumbers[0] = "555-1234";
//        //        //        Console.WriteLine(person1 == person2); // output: True

//        //        //        Console.WriteLine(ReferenceEquals(person1, person2)); // output: False
//        //        //    }
//        //        //}



//        //        //program3: demonstrates use of a with expression to copy an immutable object and change one of the properties:

//        //        public record Person(string FirstName, string LastName)
//        //        {
//        //            public required string[] PhoneNumbers { get; init; }
//        //        }

//        //        public class Program
//        //        {
//        //            public static void Main()
//        //            {
//        //                Person person1 = new("Nancy", "Davolio") { PhoneNumbers = new string[1] };
//        //                Console.WriteLine(person1);
//        //                // output: Person { FirstName = Nancy, LastName = Davolio, PhoneNumbers = System.String[] }

//        //                Person person2 = person1 with { FirstName = "John" };
//        //                Console.WriteLine(person2);
//        //                // output: Person { FirstName = John, LastName = Davolio, PhoneNumbers = System.String[] }
//        //                Console.WriteLine(person1 == person2); // output: False

//        //                person2 = person1 with { PhoneNumbers = new string[1] };
//        //                Console.WriteLine(person2);
//        //                // output: Person { FirstName = Nancy, LastName = Davolio, PhoneNumbers = System.String[] }
//        //                Console.WriteLine(person1 == person2); // output: False

//        //                person2 = person1 with { };
//        //                Console.WriteLine(person1 == person2); // output: True
//        //            }
//        //        }


//        //  own code: program1: Record with Custom Property + Method
////        public record Person
////{
////    public string FirstName { get; init; }
////    public string LastName { get; init; }

////    public string FullName => $"{FirstName} {LastName}";
////}

////class Program
////{
////    static void Main()
////    {
////        var person = new Person
////        {
////            FirstName = "Maria",
////            LastName = "Shrada"
////        };

////        Console.WriteLine(person.FullName);
////    }
////}
//        //program2: Record with Deconstruction

      

////public record Person(string FirstName, string LastName);

////    class Program
////    {
////        static void Main()
////        {
////            var person = new Person("Nancy", "Davolio");

////            var (first, last) = person;   // Deconstruction

////            Console.WriteLine($"First: {first}");
////            Console.WriteLine($"Last: {last}");
////        }
////    }


//        //program3:Record vs Class Equality Comparison
        
////public record PersonRecord(string Name);

////    public class PersonClass
////    {
////        public string Name { get; set; }
////    }

////    class Program
////    {
////        static void Main()
////        {
////            var r1 = new PersonRecord("Alex");
////            var r2 = new PersonRecord("Alex");

////            Console.WriteLine(r1 == r2);   // True (value equality)

////            var c1 = new PersonClass { Name = "Alex" };
////            var c2 = new PersonClass { Name = "Alex" };

////            Console.WriteLine(c1 == c2);   // False (reference equality)
////        }
////    }
//}
//}
