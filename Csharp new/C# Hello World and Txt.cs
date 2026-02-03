//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data.SqlTypes;
//using System.Linq;
//using System.Runtime.Intrinsics.X86;
//using System.Text;
//using System.Threading.Tasks;

//namespace Csharp_new
//{
//    internal class String
   // {
      //  static void Main(string[] args)
//{
    //            //Program1:  Declaring variables
    //           // string aFriend = "Bill";
    //             string aFriend = "Maira";
    //             Console.WriteLine(aFriend);



    //            //Program2:  creating hello msg
    //            Console.WriteLine("Hello " + aFriend);
    //            Console.WriteLine($"Hello {aFriend}");  //better way to use is {} but at the begging need to add$.
    //                                                       //$ tells C# → “I will use variables inside this string”
    //                                                       // { aFriend} → C# replaces this with the value of the variable



    //            //Program3:  string function in writeline.
    //            string firstFriend = "Maria";
    //            string secondFriend = "Sage";
    //            Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");


    //            // Program4:  Adding string with the string length of that words 
    //            Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
    //            Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");




    //            //program5:  Removing whitespace from string 
    //            string greeting = "      Hello World!       ";   //trim space removing methods
    //            Console.WriteLine($"[{greeting}]");

    //            string trimmedGreeting = greeting.TrimStart();   //trim starting of the space will be removed before hello
    //            Console.WriteLine($"[{trimmedGreeting}]");

    //            trimmedGreeting = greeting.TrimEnd();    //trim ending space will be removed after world!
    //            Console.WriteLine($"[{trimmedGreeting}]");

    //            trimmedGreeting = greeting.Trim(); //only trim defines both the space will be removed at the begining and ending.
    //            Console.WriteLine($"[{trimmedGreeting}]");



    //            //program6:  Search and replace text in strings 
    //            string sayHello = "Hello World!";
    //            Console.WriteLine(sayHello);     // it prints the variable data hello world.
    //            sayHello = sayHello.Replace("Hello", "Greetings");
    //            Console.WriteLine(sayHello);     //  in this .Replace is the word which replaces the variable data variable gets updated as gretting and then prints the variable.



    //            //program7:Changing words to Intellisense (.ToUpper() and .ToLower())
    //            Console.WriteLine(sayHello.ToUpper());  //its changes all the words to upper case letters.(GREETINGS WORLD!)
    //            Console.WriteLine(sayHello.ToLower());   //it changes all the words to lower case letters.(greetings world!)



    //            //program8:Checking the words or searching words that conatins in a line (.Conatin Method)
    //            string songLyrics = "You say goodbye, and I say hello";
    //            Console.WriteLine(songLyrics.Contains("goodbye"));  //goodbye is present in the above sentence =True
    //            Console.WriteLine(songLyrics.Contains("greetings"));//greetings is not present in the above sentence =False

    //            /*Challenge Two similar methods, StartsWith and EndsWith, also search for substrings in a string.
    //             * These methods find a substring at the beginning or the end of the string.
    //             * Try to modify the previous sample to use StartsWith and EndsWith instead of Contains.
    //             * Search for "You" or "goodbye" at the beginning of a string.Search for "hello" or "goodbye" at the end of a string.*/

    //            Console.WriteLine(songLyrics.StartsWith("goodbye"));
    //            Console.WriteLine(songLyrics.StartsWith("You"));
    //            Console.WriteLine(songLyrics.EndsWith("goodbye"));
    //            Console.WriteLine(songLyrics.EndsWith("hello"));
    //


    // own coding
    //program1:
    //string name = "Maria";
    //string message = $"Hello {name}";
    //message = message.Replace("Hello", "Hi");
    //Console.WriteLine(message);

    //        //program2:
    //        string word = "   Sage   ";
    //        string trimmed = word.Trim();
    //        Console.WriteLine(trimmed.Length);


    //        //Program3:
    //        string text = "Hello World";
    //        Console.WriteLine(text.ToLower().Contains("hello"));
    //        Console.WriteLine(text.Contains("hello"));

    //        //Program4:
    //        string line = "Brackets show final string clearly";
    //        Console.WriteLine(line.StartsWith("Brackets"));
    //        Console.WriteLine(line.EndsWith("clearly"));

    //        //Program5:
    //        string read = "   Maria   ";
    //        string result = read.Trim().ToUpper();
    //        Console.WriteLine($"[{result}]");



    //    }
    //}
    //}



