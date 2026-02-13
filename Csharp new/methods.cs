//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection;
//using System.Text;
//using System.Threading.Tasks;

//namespace Csharp_new
//{
//    internal class methods
//    {
        //        //program1: method call passes.
        //        //public static class SquareExample
        //        //{
        //        //    public static void Main()
        //        //    {
        //        //        // Call with an int variable.
        //        //        int num = 4;
        //        //        int productA = Square(num);

        //        //        // Call with an integer literal.
        //        //        int productB = Square(12);

        //        //        // Call with an expression that evaluates to int.
        //        //        int productC = Square(productA * 3);


        //        //    //    Console.WriteLine(productA);
        //        //    //    Console.WriteLine(productB);
        //        //    //    Console.WriteLine(productC);
        //        //    }

        //        //    static int Square(int i)
        //        //    {
        //        //        // Store input argument in a local variable.
        //        //        int input = i;

        //        //        return input * input;

        //        //    }
        //        //}

        //        //program2:two arguments that 


        //        //   namespace NamedMotorCycle;
        //        //class TestMotorcycle : Motorcycle
        //        //{
        //        //    public override int Drive(int miles, int speed) =>
        //        //        (int)Math.Round((double)miles / speed, 0);
        //        //    public override double GetTopSpeed() => 108.4;


        //        //}
        //        // The example displays the following output:
        //        //    //      Travel time: approx. 3 hours
        //        //}
        //        //}



        //        //program2: methods Inherited and overridden methods
        //        //public class Person
        //        //{
        //        //    public string FirstName = default!;
        //        //}

        //        //public static class ClassTypeExample
        //        //{
        //        //    public static void Main()
        //        //    {
        //        //        Person p1 = new() { FirstName = "John" };
        //        //        Person p2 = new() { FirstName = "John" };
        //        //        Console.WriteLine($"p1 = p2: {p1.Equals(p2)}");
        //        //    }
        //        //}
        //        // The example displays the following output:
        //        //      p1 = p2: False

        //        //program3: Inherited and overridden methods
        //        //        public class Person
        //        //        {
        //        //            public string FirstName = default!;

        //        //            public override bool Equals(object? obj) =>
        //        //                obj is Person p2 &&
        //        //                FirstName.Equals(p2.FirstName);

        //        //            public override int GetHashCode() => FirstName.GetHashCode();
        //        //        }

        //        //        public static class Example
        //        //        {
        //        //            public static void Main()
        //        //            {
        //        //                Person p1 = new() { FirstName = "John" };
        //        //                Person p2 = new() { FirstName = "John" };
        //        //                Console.WriteLine($"p1 = p2: {p1.Equals(p2)}");
        //        //            }
        //        //  }


        //        // program4: Passing parameters by value
        //        //public static class ByValueExample
        //        //{
        //        //    public static void Main()
        //        //    {
        //        //        var value = 20;
        //        //        Console.WriteLine("In Main, value = {0}", value);
        //        //        ModifyValue(value);
        //        //        Console.WriteLine("Back in Main, value = {0}", value);
        //        //    }

        //        //    static void ModifyValue(int i)
        //        //    {
        //        //        i = 30;
        //        //        Console.WriteLine("In ModifyValue, parameter value = {0}", i);
        //        //        return;
        //        //    }
        //        //}
        //        // The example displays the following output:
        //        //      In Main, value = 20
        //        //      In ModifyValue, parameter value = 30
        //        //      Back in Main, value = 20


        //        //program5: Passing parameters by value

        //        //public class SampleRefType
        //        //{
        //        //    public int value;
        //        //}

        //        //public static class ByRefTypeExample
        //        //{
        //        //    public static void Main()
        //        //    {
        //        //        var rt = new SampleRefType { value = 44 };
        //        //        ModifyObject(rt);
        //        //        Console.WriteLine(rt.value);
        //        //    }

        //        //    static void ModifyObject(SampleRefType obj) => obj.value = 33;
        //        //}


        //        //program6: Passing parameters by reference

        //        //public static class RefSwapExample
        //        //{
        //        //    static void Main()
        //        //    {
        //        //        int i = 2, j = 3;
        //        //        Console.WriteLine($"i = {i}  j = {j}");

        //        //        Swap(ref i, ref j);

        //        //        Console.WriteLine($"i = {i}  j = {j}");
        //        //    }

        //        //    static void Swap(ref int x, ref int y) =>
        //        //        (y, x) = (x, y);
        //        //}
        //        // The example displays the following output:
        //        //      i = 2  j = 3
        //        //      i = 3  j = 2



        //        //program7:Parameter collections

        //        //static class ParamsExample
        //        //{
        //        //    static void Main()
        //        //    {
        //        //        string fromArray = GetVowels(["apple", "banana", "pear"]);
        //        //        Console.WriteLine($"Vowels from collection expression: '{fromArray}'");

        //        //        string fromMultipleArguments = GetVowels("apple", "banana", "pear");
        //        //        Console.WriteLine($"Vowels from multiple arguments: '{fromMultipleArguments}'");

        //        //        string fromNull = GetVowels(null);
        //        //        Console.WriteLine($"Vowels from null: '{fromNull}'");

        //        //        string fromNoValue = GetVowels();
        //        //        Console.WriteLine($"Vowels from no value: '{fromNoValue}'");
        //        //    }

        //        //    static string GetVowels(params IEnumerable<string>? input)
        //        //    {
        //        //        if (input == null || !input.Any())
        //        //        {
        //        //            return string.Empty;
        //        //        }

        //        //        char[] vowels = ['A', 'E', 'I', 'O', 'U'];
        //        //        return string.Concat(
        //        //            input.SelectMany(
        //        //                word => word.Where(letter => vowels.Contains(char.ToUpper(letter)))));
        //        //    }
        //        //}

        //        // The example displays the following output:
        //        //     Vowels from array: 'aeaaaea'
        //        //     Vowels from multiple arguments: 'aeaaaea'
        //        //     Vowels from null: ''
        //        //     Vowels from no value: ''



        //        //program8: Optional parameters and arguments

        //        //public class Options
        //        //{
        //        //    public void ExampleMethod(int required, int optionalInt = default,
        //        //                              string? description = default)
        //        //    {
        //        //        var msg = $"{description ?? "N/A"}: {required} + {optionalInt} = {required + optionalInt}";
        //        //        Console.WriteLine(msg);

        //        //    }
        //        //}


        //        //program9: return value..

        //        //class SimpleMath
        //        //{
        //        //    public int AddTwoNumbers(int number1, int number2) =>
        //        //        number1 + number2;

        //        //    public int SquareANumber(int number) =>
        //        //        number * number;
        //        //}
        //        //class SimpleMathExtension
        //        //{
        //        //    public int DivideTwoNumbers(int number1, int number2)
        //        //    {
        //        //        return number1 / number2;
        //        //    }
        //        //}



        //        //program10: Double valued method
        //        //public static class ArrayValueExample
        //        //{
        //        //    static void Main()
        //        //    {
        //        //        int[] values = [2, 4, 6, 8];
        //        //        DoubleValues(values);
        //        //        foreach (var value in values)
        //        //        {
        //        //            Console.Write("{0}  ", value);
        //        //        }
        //        //    }

        //        //    public static void DoubleValues(int[] arr)
        //        //    {
        //        //        for (var ctr = 0; ctr <= arr.GetUpperBound(0); ctr++)
        //        //        {
        //        //            arr[ctr] *= 2;
        //        //        }
        //        //    }
        //        //}
        //        //// The example displays the following output:
        //        //       4  8  12  16

        //own code:    program1:Method Overloading (Different Way of Passing Arguments)

        //        class MathExample
        //{
        //    static void Main()
        //    {
        //        Console.WriteLine(Add(5, 3));
        //        Console.WriteLine(Add(5.5, 2.3));
        //        Console.WriteLine(Add(10, 20, 30));
        //    }

        //    static int Add(int a, int b) => a + b;

        //    static double Add(double a, double b) => a + b;

        //    static int Add(int a, int b, int c) => a + b + c;
        //}

        //   program2: Passing by out Parameter
       
//class OutExample
//    {
//        static void Main()
//        {
//            int number = 5;
//            Square(number, out int result);

//            Console.WriteLine($"Square is {result}");
//        }

//        static void Square(int num, out int output)
//        {
//            output = num * num;
//        }
//    }

        //program3: Overriding Method

        
//class Animal
//    {
//        public virtual void Speak()
//        {
//            Console.WriteLine("Animal makes sound");
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
//            Animal myAnimal = new Dog();
//            myAnimal.Speak();
//        }
//    }

        //   program 4: Optional Parameters + Return Value

       
//class Calculator
//    {
//        static void Main()
//        {
//            Console.WriteLine(Multiply(5));
//            Console.WriteLine(Multiply(5, 4));
//        }

//        static int Multiply(int number, int multiplier = 2)
//        {
//            return number * multiplier;
//        }
//    }

//}
//}