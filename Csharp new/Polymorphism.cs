//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Csharp_new
//{
//    internal class Class1
//    {

        //        //Program 1: Create a class hierarchy in which each specific shape class derives from a common base class.
        //        //public class Shape
        //        //{
        //        //    // A few example members
        //        //    public int X { get; init; }
        //        //    public int Y { get; init; }
        //        //    public int Height { get; init; }
        //        //    public int Width { get; init; }

        //        //    // Virtual method
        //        //    public virtual void Draw()
        //        //    {
        //        //        Console.WriteLine("Performing base class drawing tasks");
        //        //    }
        //        //}

        //        //public class Circle : Shape
        //        //{
        //        //    public override void Draw()
        //        //    {
        //        //        // Code to draw a circle...
        //        //        Console.WriteLine("Drawing a circle");
        //        //        base.Draw();
        //        //    }
        //        //}
        //        //public class Rectangle : Shape
        //        //{
        //        //    public override void Draw()
        //        //    {
        //        //        // Code to draw a rectangle...
        //        //        Console.WriteLine("Drawing a rectangle");
        //        //        base.Draw();
        //        //    }
        //        //}
        //        //public class Triangle : Shape
        //        //{
        //        //    public override void Draw()
        //        //    {
        //        //        // Code to draw a triangle...
        //        //        Console.WriteLine("Drawing a triangle");
        //        //        base.Draw();
        //        //    }
        //      //  }



        //program2:(polymorphism overview) The derived member must use the override keyword to explicitly indicate that the method is intended 
        //        public class BaseClass
        //{
        //    public virtual void DoWork() { }
        //    public virtual int WorkProperty => 0;
        //}
        //public class DerivedClass : BaseClass
        //{
        //    public override void DoWork() { }
        //    public override int WorkProperty
        //    {
        //        get { return 0; }
        //    }
        //}



        //Program3: Hide base class members with new members
        //public class BaseClass
        //{
        //    public void DoWork() { WorkField++; }
        //    public int WorkField;
        //    public int WorkProperty
        //    {
        //        get { return 0; }
        //    }
        //}

        //public class DerivedClass : BaseClass
        //{
        //    public new void DoWork() { WorkField++; }
        //    public new int WorkField;
        //    public new int WorkProperty
        //    {
        //        get { return 0; }
        //    }
        //}



        //Program4: Prevent derived classes from overriding virtual members

        //public class A
        //{
        //    public virtual void DoWork() { }
        //}
        //public class B : A
        //{
        //    public override void DoWork() { }
        //}
        //public class C : B
        //{
        //    public override void DoWork() { }

        //}
        //public class D : C
        //{
        //    public new void DoWork() { }
        //}




        //program5: Access base class virtual members from derived classes

        //        public class Base
        //        {
        //            public virtual void DoWork()
        //            {
        //                Console.WriteLine("Base DoWork");
        //            }
        //        }

        //        public class Derived : Base
        //        {
        //            public override void DoWork()
        //            {
        //                Console.WriteLine("Derived DoWork");
        //                base.DoWork();   // Calls Base version
        //            }
        //        }

        // own code: 


        //        //program1 :Using Abstract Base Class (Better OOP Design)
        //        abstract class Shape
        //{
        //    public int Width { get; set; }
        //    public int Height { get; set; }

        //    public abstract double CalculateArea();   // Must override
        //}

        //class Circle : Shape
        //{
        //    public override double CalculateArea()
        //    {
        //        return Math.PI * Width * Width;
        //    }
        //}

        //class Rectangle : Shape
        //{
        //    public override double CalculateArea()
        //    {
        //        return Width * Height;
        //    }
        //}

        //class Program
        //{
        //    static void Main()
        //    {
        //        Shape c = new Circle { Width = 5 };
        //        Shape r = new Rectangle { Width = 4, Height = 6 };

        //        Console.WriteLine($"Circle Area: {c.CalculateArea()}");
        //        Console.WriteLine($"Rectangle Area: {r.CalculateArea()}");
        //    }
        //}


        //  program2: Runtime Polymorphism Using List of Base Type
        

//class Animal
//    {
//        public virtual void Speak()
//        {
//            Console.WriteLine("Animal sound");
//        }
//    }

//    class Cat : Animal
//    {
//        public override void Speak()
//        {
//            Console.WriteLine("Cat meows");
//        }
//    }

//    class Dog : Animal
//    {
//        public override void Speak()
//        {
//            Console.WriteLine("Dog barks");
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {
//            List<Animal> animals = new List<Animal>
//        {
//            new Cat(),
//            new Dog()
//        };

//            foreach (var animal in animals)
//            {
//                animal.Speak();   // Runtime polymorphism
//            }
//        }
//    }

        //program3 :Sealed Override (Prevent Further Overriding)
       
//class A
//    {
//        public virtual void Show()
//        {
//            Console.WriteLine("A Show");
//        }
//    }

//    class B : A
//    {
//        public sealed override void Show()
//        {
//            Console.WriteLine("B Show");
//        }
//    }

//    class C : B
//    {
//        // Cannot override Show() because it is sealed in B
//    }

//    class Program
//    {
//        static void Main()
//        {
//            A obj = new B();
//            obj.Show();
//        }
//    }

        //program4: Method Hiding vs Override Difference Demonstration



//class BaseClass
//    {
//        public void Display()
//        {
//            Console.WriteLine("Base Display");
//        }
//    }

//    class DerivedClass : BaseClass
//    {
//        public new void Display()
//        {
//            Console.WriteLine("Derived Display");
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {
//            BaseClass obj1 = new DerivedClass();
//            obj1.Display();   // Calls Base method

//            DerivedClass obj2 = new DerivedClass();
//            obj2.Display();   // Calls Derived method
//        }
//    }

//}
//}

