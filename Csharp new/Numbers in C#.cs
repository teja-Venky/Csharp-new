//using Microsoft.VisualBasic;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.Intrinsics.X86;
//using System.Text;
//using System.Threading.Tasks;


//namespace Csharp_new
//{
//    internal class Numbers_in_C_
    //{
       // static void Main(string[] args)
        //{
            //  //Program1: numbers operations in an integers.


            //            //int a = 18;
            //            //int b = 6;
            //            //int c = a + b;
            //            //int d = a - b;
            //            //int e = a * b;
            //            //int f = a / b;
            //            //Console.WriteLine(c);
            //            //Console.WriteLine(d);
            //            //Console.WriteLine(e);
            //            //Console.WriteLine(f);
            //            ////mixed variable operation 
            //            //int g = a + b - 12 * 17;  //calculate with BODMAS rule
            //            //Console.WriteLine(g);


            //            //       //OR (two differnt methods to work with integers/numbers)

            //            //WorkWithIntegers();   //this is an method and runs the inside code with the workwithinteger method.
            //            //void WorkWithIntegers() //Workwithinteger(): this line calls the method name and void: doesnot return anything
            //            //{
            //            //    int a = 18;
            //            //    int b = 6;
            //            //    int c = a + b;
            //            //    Console.WriteLine(c);
            //            //    c = a - b;   // subtraction
            //            //    Console.WriteLine(c);
            //            //    c = a * b;    // multiplication
            //            //    Console.WriteLine(c);
            //            //    c = a / b;   // division
            //            //    Console.WriteLine(c);



            //                //Explore order of operations
            //  //Program2: Mixed Variable Operations
            //                int a = 5;
            //                int b = 4;
            //                int c = 2;
            //                int d = a + b * c;
            //                Console.WriteLine(d);
            //                int x = (a + b) * c;
            //                Console.WriteLine(x);

            //                int e = 7;
            //                int f = 4;
            //                int g = 3;
            //                int h = (e + f) / g;
            //                Console.WriteLine(h);

            //              //OR(orderprecedence)
            ////WorkWithIntegers();   //this is a method
            //OrderPrecedence();    //It is an order in which C# decides to do calculations.

            //void WorkWithIntegers()
            //{
            //    int a = 18;
            //    int b = 6;
            //    int c = a + b;
            //    Console.WriteLine(c);
            //    c = a - b; // subtraction
            //    Console.WriteLine(c);
            //    c = a * b; // multiplication
            //    Console.WriteLine(c);
            //    c = a / b; // division
            //    Console.WriteLine(c);
            //}

            //void OrderPrecedence()
            //{
            //    int a = 5;
            //    int b = 4;
            //    int c = 2;
            //    int d = a + b * c;
            //    Console.WriteLine(d);

            //    d = (a + b) * c;
            //    Console.WriteLine(d);

            //    d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
            //    Console.WriteLine(d);

            //    int e = 7;
            //    int f = 4;
            //    int g = 3;
            //    int h = (e + f) / g;
            //    Console.WriteLine(h);
            //}

            //        //Explore integer precision and limits
            //   program3:integer division truncates the result get reminder.
            //            code after the method call to OrderPrecedence()
            //int a = 7;
            //int b = 4;
            //int c = 3;
            //int d = (a + b) / c;  //( this is an division)
            //int e = (a + b) % c;    //(this gives the remainder for the division)
            //Console.WriteLine($"quotient: {d}");
            //Console.WriteLine($"remainder: {e}");


            //Program4: Working with MIN and MAX limits.
            //int max = int.MaxValue;    //method (.MaxValue)
            //int min = int.MinValue;    //method(.MinValue)
            //Console.WriteLine($"The range of integers is {min} to {max}");


            //Program5:  Working with Overflow and underflow in integers.

            //overflow=this is the max value of the integer 2,147,483,647(not exceed) if we are adding any number even +1 then it becomes overflow.
            //underflow=this is the min value of the integer -2,147,483,648( if we are removing any number -1 then it will be underflow.
            //Not exceeding (valid range):-2,147,483,648 to 2,147,483,647
            //Exceeding(overflow / underflow): Less than -2,147,483,648 or greater than 2,147,483,647

            //overflow:
            //int what = max + 3;
            //Console.WriteLine($"An example of overflow: {what}"); // result will be -2147483646(ans in negative is because of overflow)
            //underflow:
            //int why = min - 3;
            //Console.WriteLine($"An example of underflow: {why}"); //result will be 2147483645


            //Work with the double type
            //program6: Working with integers in substraction and increasing complexity of the programs.

            //double a = 5;
            //double b = 4;
            //double c = 2;
            //double d = (a + b) / c;
            //Console.WriteLine(d);

            //double a = 19;
            //double b = 23;
            //double c = 8;
            //double d = (a + b) / c; 
            //Console.WriteLine(d);    //5.25





            //program7:  Working with the Double in MAX and MIN Value.

            // double max = double.MaxValue;   //max in double is -1.7976931348623157E+308 
            //double min = double.MinValue;   //min in double is 1.7976931348623157E+308
            // Console.WriteLine($"The range of double is {min} to {max}");  //in double precision number has a twice of the single precision(binary single is declared by float)the largest number will be considered.


            //double third = 1.0 / 3.0; //3/10=0.3 ,33/100=0.33, it is not same as 1/3=0.3333333333.....till infinity.so rounding error may occur in double values.
            //Console.WriteLine(third);  //doubles in C# can have rounding errors. it gives the accurate decimal values will be showen.





            //Work with decimal types
            //The decimal type has a smaller range but greater precision than double.In decimal the range will be smaller than the double.
            //program 8:Working with Decimal in MIN and MAX value.
            //decimal min = decimal.MinValue;     // Decimal MIN: -79228162514264337593543950335 
            //decimal max = decimal.MaxValue;    //Decimal MAX: 79228162514264337593543950335
            //Console.WriteLine($"The range of the decimal type is {min} to {max}");

            //program 9: Working with greater precision with the decimal type by trying the following code:
            // double a = 1.0;
            //double b = 3.0;
            // Console.WriteLine(a / b); //output:0.3333333333333333

            // decimal c = 1.0M;  //M suffix is used to define decimal literals / constant  decimal type in c#.
            // decimal d = 3.0M;
            // Console.WriteLine(c / d);  //0.3333333333333333333333333333(output will be more than double type because of greater precision in decimal type)






            //Challenge

            // Now that you know the different numeric types, write code that calculates the area of a circle whose radius is 2.50 centimeters.Remember that the area of a circle is the radius squared multiplied by PI. One hint: .NET contains a constant for PI, Math.PI that you can use for that value. Math.PI, like all constants declared in the System.Math namespace, is a double value.For that reason, you should use double instead of decimal values for this challenge.
            //You should get an answer between 19 and 20.

            // double radius = 2.50;
            // double area = radius * radius * Math.PI;
            // Console.WriteLine("The area of a circle is:" + area);    


            // OWN CODING 

            //PROGRAM1:
           // double d = 0;
           // for (int i = 0; i < 10; i++)
           //     d = d + 0.1;

           // Console.WriteLine(d);

           // decimal m = 0;
           // for (int i = 0; i < 10; i++)
           //     m = m + 0.1M;

           // Console.WriteLine(m);

           ////PROGRAM2: MAX AND MIN
           //Console.WriteLine($"int: {int.MinValue} to {int.MaxValue}");
           // Console.WriteLine($"double: {double.MinValue} to {double.MaxValue}");
           // Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue}");


           // // PROGRAM3: DOUBLE
           // int a = 9;
           // int b = 4;

           // Console.WriteLine(a / b); //SINGLE

           // double result = (double)a / b;
           // Console.WriteLine(result);


           // //PROGRAM4: AREA OF RECTANGLE

           // decimal l = 8.5M;
           // decimal bre = 4.2M;

           // decimal area = l * bre;

           // Console.WriteLine("The area of the rectangle is:" + area);

       // }
 //   }
//}
