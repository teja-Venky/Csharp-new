//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Csharp_new
//{
//    internal class Asyncprog
//    {
//        //        //program1: 
//        //        // These classes are intentionally empty for the purpose of this example. They are simply marker classes for the purpose of demonstration, contain no properties, and serve no other purpose.
//        //        //internal class HashBrown { }
//        //        //internal class Coffee { }
//        //        //internal class Egg { }
//        //        //internal class Juice { }
//        //        //internal class Toast { }

//        //        //class Program
//        //        //{
//        //        //    static void Main(string[] args)
//        //        //    {
//        //        //        Coffee cup = PourCoffee();
//        //        //        Console.WriteLine("coffee is ready");

//        //        //        Egg eggs = FryEggs(2);
//        //        //        Console.WriteLine("eggs are ready");

//        //        //        HashBrown hashBrown = FryHashBrowns(3);
//        //        //        Console.WriteLine("hash browns are ready");

//        //        //        Toast toast = ToastBread(2);
//        //        //        ApplyButter(toast);
//        //        //        ApplyJam(toast);
//        //        //        Console.WriteLine("toast is ready");

//        //        //        Juice oj = PourOJ();
//        //        //        Console.WriteLine("oj is ready");
//        //        //        Console.WriteLine("Breakfast is ready!");
//        //        //    }

//        //        //    private static Juice PourOJ()
//        //        //    {
//        //        //        Console.WriteLine("Pouring orange juice");
//        //        //        return new Juice();
//        //        //    }

//        //        //    private static void ApplyJam(Toast toast) =>
//        //        //        Console.WriteLine("Putting jam on the toast");

//        //        //    private static void ApplyButter(Toast toast) =>
//        //        //        Console.WriteLine("Putting butter on the toast");

//        //        //    private static Toast ToastBread(int slices)
//        //        //    {
//        //        //        for (int slice = 0; slice < slices; slice++)
//        //        //        {
//        //        //            Console.WriteLine("Putting a slice of bread in the toaster");
//        //        //        }
//        //        //        Console.WriteLine("Start toasting...");
//        //        //        Task.Delay(3000).Wait();
//        //        //        Console.WriteLine("Remove toast from toaster");

//        //        //        return new Toast();
//        //        //    }

//        //        //    private static HashBrown FryHashBrowns(int patties)
//        //        //    {
//        //        //        Console.WriteLine($"putting {patties} hash brown patties in the pan");
//        //        //        Console.WriteLine("cooking first side of hash browns...");
//        //        //        Task.Delay(3000).Wait();
//        //        //        for (int patty = 0; patty < patties; patty++)
//        //        //        {
//        //        //            Console.WriteLine("flipping a hash brown patty");
//        //        //        }
//        //        //        Console.WriteLine("cooking the second side of hash browns...");
//        //        //        Task.Delay(3000).Wait();
//        //        //        Console.WriteLine("Put hash browns on plate");

//        //        //        return new HashBrown();
//        //        //    }

//        //        //    private static Egg FryEggs(int howMany)
//        //        //    {
//        //        //        Console.WriteLine("Warming the egg pan...");
//        //        //        Task.Delay(3000).Wait();
//        //        //        Console.WriteLine($"cracking {howMany} eggs");
//        //        //        Console.WriteLine("cooking the eggs ...");
//        //        //        Task.Delay(3000).Wait();
//        //        //        Console.WriteLine("Put eggs on plate");

//        //        //        return new Egg();
//        //        //    }

//        //        //    private static Coffee PourCoffee()
//        //        //    {
//        //        //        Console.WriteLine("Pouring coffee");
//        //        //        return new Coffee();
//        //        //    }
//        //        //}

//        //     //   program2: await Asynchronous program


//        //        // These classes are intentionally empty for the purpose of this example. They are simply marker classes for the purpose of demonstration, contain no properties, and serve no other purpose.
//        //        internal class HashBrown { }
//        //        internal class Coffee { }
//        //        internal class Egg { }
//        //        internal class Juice { }
//        //        internal class Toast { }

//        //        class Program
//        //        {
//        //            static async Task Main(string[] args)
//        //            {
//        //                Coffee cup = PourCoffee();
//        //                Console.WriteLine("coffee is ready");

//        //                var eggsTask = FryEggsAsync(2);
//        //                var hashBrownTask = FryHashBrownsAsync(3);
//        //                var toastTask = MakeToastWithButterAndJamAsync(2);

//        //                var breakfastTasks = new List<Task> { eggsTask, hashBrownTask, toastTask };
//        //                while (breakfastTasks.Count > 0)
//        //                {
//        //                    Task finishedTask = await Task.WhenAny(breakfastTasks);
//        //                    if (finishedTask == eggsTask)
//        //                    {
//        //                        Console.WriteLine("eggs are ready");
//        //                    }
//        //                    else if (finishedTask == hashBrownTask)
//        //                    {
//        //                        Console.WriteLine("hash browns are ready");
//        //                    }
//        //                    else if (finishedTask == toastTask)
//        //                    {
//        //                        Console.WriteLine("toast is ready");
//        //                    }
//        //                    await finishedTask;
//        //                    breakfastTasks.Remove(finishedTask);
//        //                }

//        //                Juice oj = PourOJ();
//        //                Console.WriteLine("oj is ready");
//        //                Console.WriteLine("Breakfast is ready!");
//        //            }

//        //            static async Task<Toast> MakeToastWithButterAndJamAsync(int number)
//        //            {
//        //                var toast = await ToastBreadAsync(number);
//        //                ApplyButter(toast);
//        //                ApplyJam(toast);

//        //                return toast;
//        //            }

//        //            private static Juice PourOJ()
//        //            {
//        //                Console.WriteLine("Pouring orange juice");
//        //                return new Juice();
//        //            }

//        //            private static void ApplyJam(Toast toast) =>
//        //                Console.WriteLine("Putting jam on the toast");

//        //            private static void ApplyButter(Toast toast) =>
//        //                Console.WriteLine("Putting butter on the toast");

//        //            private static async Task<Toast> ToastBreadAsync(int slices)
//        //            {
//        //                for (int slice = 0; slice < slices; slice++)
//        //                {
//        //                    Console.WriteLine("Putting a slice of bread in the toaster");
//        //                }
//        //                Console.WriteLine("Start toasting...");
//        //                await Task.Delay(3000);
//        //                Console.WriteLine("Remove toast from toaster");

//        //                return new Toast();
//        //            }

//        //            private static async Task<HashBrown> FryHashBrownsAsync(int patties)
//        //            {
//        //                Console.WriteLine($"putting {patties} hash brown patties in the pan");
//        //                Console.WriteLine("cooking first side of hash browns...");
//        //                await Task.Delay(3000);
//        //                for (int patty = 0; patty < patties; patty++)
//        //                {
//        //                    Console.WriteLine("flipping a hash brown patty");
//        //                }
//        //                Console.WriteLine("cooking the second side of hash browns...");
//        //                await Task.Delay(3000);
//        //                Console.WriteLine("Put hash browns on plate");

//        //                return new HashBrown();
//        //            }

//        //            private static async Task<Egg> FryEggsAsync(int howMany)
//        //            {
//        //                Console.WriteLine("Warming the egg pan...");
//        //                await Task.Delay(3000);
//        //                Console.WriteLine($"cracking {howMany} eggs");
//        //                Console.WriteLine("cooking the eggs ...");
//        //                await Task.Delay(3000);
//        //                Console.WriteLine("Put eggs on plate");

//        //                return new Egg();
//        //            }

//        //            private static Coffee PourCoffee()
//        //            {
//        //                Console.WriteLine("Pouring coffee");
//        //                return new Coffee();
//        //            }
//        //        }

//       // own code , program3: car service program

      

////     internal class CarWash { }
////    internal class OilChange { }
////    internal class EngineCheck { }
////    internal class TireInflation { }

////    class Program
////    {
////        static async Task Main(string[] args)
////        {
////            Console.WriteLine("Car service started\n");

////            var washTask = WashCarAsync();
////            var oilTask = ChangeOilAsync();
////            var engineTask = CheckEngineAsync();
////            var tireTask = InflateTiresAsync();

////            var serviceTasks = new List<Task> { washTask, oilTask, engineTask, tireTask };

////            while (serviceTasks.Count > 0)
////            {
////                Task finishedTask = await Task.WhenAny(serviceTasks);

////                if (finishedTask == washTask)
////                    Console.WriteLine("Car wash completed!");
////                else if (finishedTask == oilTask)
////                    Console.WriteLine("Oil change completed!");
////                else if (finishedTask == engineTask)
////                    Console.WriteLine("Engine check completed!");
////                else if (finishedTask == tireTask)
////                    Console.WriteLine("Tire inflation completed!");

////                await finishedTask;
////                serviceTasks.Remove(finishedTask);
////            }

////            Console.WriteLine("\nCar service is fully completed!");
////        }

////        private static async Task<CarWash> WashCarAsync()
////        {
////            Console.WriteLine("Washing the car...");
////            await Task.Delay(3000);
////            Console.WriteLine("Drying the car...");
////            await Task.Delay(2000);

////            return new CarWash();
////        }

////        private static async Task<OilChange> ChangeOilAsync()
////        {
////            Console.WriteLine("Draining old oil...");
////            await Task.Delay(2000);
////            Console.WriteLine("Adding new oil...");
////            await Task.Delay(2000);

////            return new OilChange();
////        }

////        private static async Task<EngineCheck> CheckEngineAsync()
////        {
////            Console.WriteLine("Checking engine diagnostics...");
////            await Task.Delay(4000);

////            return new EngineCheck();
////        }

////        private static async Task<TireInflation> InflateTiresAsync()
////        {
////            Console.WriteLine("Inflating tires...");
////            await Task.Delay(2500);

////            return new TireInflation();
////        }
////    }
////}
////}


