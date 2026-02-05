//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Linq;
//using System.Runtime.Intrinsics.X86;
//using System.Text;
//using System.Threading.Tasks;
//using static System.Runtime.InteropServices.JavaScript.JSType;

//namespace Csharp_new
//{
//    internal class List_collection
//    {
//        static void Main(string[] args)
//        {
//           //program1: creating a list of collection with string declaration and modify(replace) with a method upper.
//           List<string> names = ["<name>", "Ana", "Felipe"];
//            foreach (var name in names)
//            {
//                Console.WriteLine($"Hello {name.ToUpper()}!");   //the method upper defines the names variable will be changed to upper case in console.
//            }

//            //program2: modify list content with methods and loop.

//            Console.WriteLine();
//            names.Add("Maria");
//            names.Add("Bill");
//            names.Remove("Ana");
//            foreach (var name in names)
//            {
//                Console.WriteLine($"Hello {name.ToUpper()}!");
//            }

//            //program3:You access items using the [ and ] tokens by its index location.

//            Console.WriteLine($"My name is {names[0]}.");
//            Console.WriteLine($"I've added {names[2]} and {names[3]} to the list.");

//            //program4: using method(.count) [using count property]

//            Console.WriteLine($"The list has {names.Count} people in it");   //method .count name is an variable so it counts how many variabea are present and gives the resukt.

//            //program5: Search and sort list 

//            //This is to search
//            var index = names.IndexOf("Felipe");
//            if (index == -1)
//            {
//                Console.WriteLine($"When an item is not found, IndexOf returns {index}"); //if element is not found then it returns this sentence.
//            }
//            else
//            {
//                Console.WriteLine($"The name {names[index]} is at index {index}");
//            }

//            index = names.IndexOf("Not Found");
//            if (index == -1)
//            {
//                Console.WriteLine($"When an item is not found, IndexOf returns {index}");
//            }
//            else
//            {
//                Console.WriteLine($"The name {names[index]} is at index {index}");
//            }

//            //this is to sort
//            names.Sort();
//            foreach (var name in names)
//            {
//                Console.WriteLine($"Hello {name.ToUpper()}!");
//            }


//            // list of other types apart from string function using.
//            List<int> fibonacciNumbers = [1, 1];
//            var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
//            var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

//            fibonacciNumbers.Add(previous + previous2);

//            foreach (var item in fibonacciNumbers)
//            {
//                Console.WriteLine(item);
//            }


//            //Challenge
//            //See if you can put together some of the concepts from this and earlier lessons.Expand on what you built so far with Fibonacci Numbers.
//            //Try to write the code to generate the first 20 numbers in the sequence. (As a hint, the 20th Fibonacci number is 6765.)

//            int num1 = 0;
//            int num2 = 1;

//            Console.WriteLine(" Fibonacci numbers:");

//            Console.Write(num1 + " ");
//            Console.Write(num2 + " ");

//            for (int i = 3; i <= 20; i++)
//            {
//                int num3 = num1 + num2;
//                Console.Write(" " +num3);

//                num1 = num2;
//                num2 = num3;
//            }



//        }
//    }
//}
