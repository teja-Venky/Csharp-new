using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_new
{
    //iteration Statements - For, Foreach, do, and While.
    internal class Loops_and_Iteration_stat
    {
        //static void Main(string[] args)
        //{
            // Program1: While loop
            //int counter = 0;
            //while (counter < 10)
            //{
            //    Console.WriteLine($"Hello World! The counter is {counter}");
            //    counter++;
            //}


            //Program2:  DoWhile Loop
            //int counter = 0;
            //do
            //{
            //    Console.WriteLine($"Hello World! The counter is {counter}");
            //    counter++;
            //} while (counter < 10);


            // Program3: for Loop
            //for (int counter = 0; counter < 10; counter++)
            //{
            //    Console.WriteLine($"Hello World! The counter is {counter}");
            //}

            ////Program4: created nested loops
            //for (int row = 1; row < 11; row++)
            //{
            //    Console.WriteLine($"The row is {row}");
            //}

            //for (char column = 'a'; column < 'k'; column++)
            //{
            //    Console.WriteLine($"The column is {column}");
            //}

            //for (int row = 1; row < 11; row++)
            //{
            //    for (char column = 'a'; column < 'k'; column++)
            //    {
            //        Console.WriteLine($"The cell is ({row}, {column})");
            //    }
            //}


            //// Program5: for Loop/Statement
            ////for (int i = 0; i < 3; i++)
            ////{
            ////    Console.Write(i);
            ////}


            ////Program6: For loop
            //int i;
            //int j = 3;
            //for (i = 0, Console.WriteLine($"Start: i={i}, j={j}"); i < j; i++, j--, Console.WriteLine($"Step: i={i}, j={j}"))
            //{
            //    //...
            //}

            ////Program7: Foreach Loop/Statement
            //List<int> fibNumbers = new() { 0, 1, 1, 2, 3, 5, 8, 13 };
            //foreach (int element in fibNumbers)
            //{
            //    Console.Write($"{element} ");
            //}


            ////Program8: Foreach Loop/Statement
            //Span<int> numbers = [3, 14, 15, 92, 6];
            //foreach (int number in numbers)
            //{
            //    Console.Write($"{number} ");
            //}

            ////Program9: Enumerator current property returns a reference value
            //Span<int> storage = stackalloc int[10];
            //int num = 0;
            //foreach (ref int item in storage)
            //{
            //    item = num++;
            //}
            //foreach (ref readonly var item in storage)
            //{
            //    Console.Write($"{item} ");
            //}

            //Program10: await foreach Statement
            //await foreach (var item in GenerateSequenceAsync())
            //{
            //    Console.WriteLine(item);
            //}

            //OWN CODE:
            //PROGRAM1: WHILE LOOP

            //int i = 1;
            //while (i <= 5)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            ////PROGRAM2: DO WHILE LOOP

            //int J = 1;

            //do
            //{
            //    Console.WriteLine(J);
            //    J++;
            //}
            //while (J <= 5);

            ////PROGRAM3: FOR LOOP 
            //// Find sum of numbers divisible by both 3 and 5 between 1 and 100

            //int sum = 0;

            //for (int k = 1; k <= 100; k++)
            //{
            //    if (k % 3 == 0 && k % 5 == 0)
            //    {
            //        sum = sum + k;
            //    }
            //}

            //Console.WriteLine("Sum is: " + sum);


            //// Reverse a number using for loop
            //int rev = 0;

            //for (int number = 12345; number > 0; number /= 10)
            //{
            //    int result = number % 10;
            //    rev = rev * 10 + result;
            //}

            //Console.WriteLine("Reversed number: " + rev);

            ////PROGRAM4: NESTED LOOPS
            //// Print number pyramid

            //int C = 5;

            //for (int A = 1; A <= C; A++)
            //{
            //    for (int B = C; B > A; B--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int num = 1; num <= A; num++)
            //    {
            //        Console.Write(num + " ");
            //    }

               // Console.WriteLine();
            }

            //PROGRAM5: AWAIT LOOP

            // Async method example
            //async Task PrintNumbersAsync()
            //{
            //    for (int i = 1; i <= 3; i++)
            //    {
            //        await Task.Delay(1000);   // wait 1 second
            //        Console.WriteLine(i);
            //    }
            //}

            //// Call the method
            //await PrintNumbersAsync();



      //  }
   //}
}
