//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Csharp_new
//{
//    internal class Classes
//    {
//        //program 1: program based on base class, derived, interface, abstract and sealed class.

////// Base class
////public class Employee
////        {
////            // Field
////            public int Id;

////            // Property
////            public string Name;

////            // Virtual method (can be overridden)
////            public virtual void Work()
////            {
////                Console.WriteLine("Employee is working");
////            }
////        }

////        // Derived class (inherits Employee)
////        public class Manager : Employee
////        {
////            // New property
////            public int TeamSize;

////            // Override base class method
////            public override void Work()
////            {
////                Console.WriteLine("Manager is managing the team");
////            }
////        }

////        // Interface
////        public interface IBonus
////        {
////            void CalculateBonus();
////        }

////        // Class implementing interface
////        public class Developer : Employee, IBonus
////        {
////            public void CalculateBonus()
////            {
////                Console.WriteLine("Bonus calculated for developer");
////            }
////        }

////        // Abstract class
////        public abstract class Vehicle
////        {
////            // Abstract method (no implementation)
////            public abstract void Start();
////        }

////        // Derived class implementing abstract method
////        public class Car : Vehicle
////        {
////            public override void Start()
////            {
////                Console.WriteLine("Car started");
////            }
////        }

////        // Sealed class (cannot be inherited)
////        public sealed class Company
////        {
////            public void ShowName()
////            {
////                Console.WriteLine("Company Name: Tech Corp");
////            }
////        }

////        // Main program
////        class Program
////        {
////            static void Main()
////            {
////                // Creating Employee object
////                Employee emp = new Employee();
////                emp.Name = "Alice";
////                emp.Work();

////                // Creating Manager object
////                Manager mgr = new Manager();
////                mgr.Name = "Bob";
////                mgr.TeamSize = 5;
////                mgr.Work();

////                // Creating Developer object
////                Developer dev = new Developer();
////                dev.Name = "Charlie";
////                dev.CalculateBonus();

////                // Creating Car object
////                Vehicle car = new Car();
////                car.Start();

////                // Creating Company object
////                Company company = new Company();
////                company.ShowName();
////            }
////        }

//     //   program2: constructor in classes
            
//// Base class
//public class Employee
//    {
//        // Field
//        public string Name;

//        // Constructor to initialize Name
//        public Employee(string name)
//        {
//            Name = name;
//        }

//        // Virtual method that can be overridden
//        public virtual void Work()
//        {
//            Console.WriteLine($"{Name} is working.");
//        }
//    }

//    // Derived class
//    public class Manager : Employee
//    {
//        // Additional field
//        public int TeamSize;

//        // Constructor for Manager, calls base class constructor
//        public Manager(string name, int teamSize) : base(name)
//        {
//            TeamSize = teamSize;
//        }

//        // Override the Work method
//        public override void Work()
//        {
//            Console.WriteLine($"{Name} is managing a team of {TeamSize} employees.");
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {
//            // Create an Employee object
//            Employee emp = new Employee("Alice");
//            emp.Work();  // Output: Alice is working.

//            // Create a Manager object
//            Manager mgr = new Manager("Bob", 5);
//            mgr.Work();  // Output: Bob is managing a team of 5 employees.

//            // Reference example
//            Employee empRef = mgr; // empRef points to the Manager object
//            empRef.Work();          // Output: Bob is managing a team of 5 employees.
//        }
//    }
//}
//   }

