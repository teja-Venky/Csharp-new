using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public record Rectangle(int Width, int Height)
{
    public int Area() => Width * Height;
}
    public record Point(int e, int f);
//public record Point(int X, int Y)
//{
//    public double Slope() => (double)Y / (double)X;
//}// this preceding code should be after sourefile. declare and use record type to represent a point

namespace Csharp_new
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            //            //program1 : using values from a tuple
            //            var pt = (X: 1, Y: 2);

            //            var slope = (double)pt.Y / (double)pt.X;
            //            Console.WriteLine($"A line from the origin to the point {pt} has a slope of {slope}.");

            //            //program2:  modify a tuple member:

            //            pt.X = pt.X + 5;
            //            Console.WriteLine($"The point is now at {pt}.");

            //            //program3: create a new tuple that's a modified copy of the original using a with expression.

            //            var pt2 = pt with { Y = 10 };
            //            Console.WriteLine($"The point 'pt2' is at {pt2}.");

            //            //program4: You can assign a tuple to a tuple with the same arity example:

            //            var subscript = (A: 0, B: 0);
            //            subscript = pt;
            //            Console.WriteLine(subscript);

            //            //program5: the same tuple type: a tuple containing two int members.

            //            var namedData = (Name: "Morning observation", Temp: 17, Wind: 4);    //tuples are easy to create by declare multiple members closed with parenthesis 
            //            var person = (FirstName: "", LastName: "");
            //            var order = (Product: "guitar picks", style: "triangle", quantity: 500, UnitPrice: 0.10m);

            //            //create record types

            //            //progrsm6:  code preceding the record declaration:
            //            Point pt3 = new Point(1, 1);   //(x, y)
            //            var pt4 = pt3 with { Y = 10 };  //(x=pt3(X=1), y=10)
            //            Console.WriteLine($"The two points are {pt3} and {pt4}");

            //            //Program7: Record declaration with expression.
            //            double slopeResult = pt4.Slope();
            //            Console.WriteLine($"The slope of {pt4} is {slopeResult}");



            // own code:
            //Program8: Create a tuple for a point (X, Y) and calculate its distance from the origin.

            var pt = (X: 3, Y: 4);
            double distance = Math.Sqrt(pt.X * pt.X + pt.Y * pt.Y);
            Console.WriteLine($"The distance of {pt} from origin is {distance}.");

            //program9: Create a tuple (A, B) and swap its values without using a temporary variable.

            var value = (A: 5, B: 10);
            value = (value.B, value.A);
            Console.WriteLine($"Swap tuple: {value}");

            //program10: Create a record Point with X and Y. Update both members using with.

        var point = new Point(2, 3);
        var ptUpdated = point with { e = 5, f = 7 };
        Console.WriteLine($"Original: {point}, Updated: {ptUpdated}");

            //program11:Create a tuple (Int1, Int2, Int3) and calculate the sum of its members.

            var numbers = (Int1: 4, Int2: 7, Int3: 9);
            int sum = numbers.Int1 + numbers.Int2 + numbers.Int3;
            Console.WriteLine($"Sum of tuple members: {sum}");

            //program12: Create a record Rectangle with Width and Height, and a method to calculate area.
            
        var rect = new Rectangle(5, 10);
        Console.WriteLine($"Rectangle {rect} has area: {rect.Area()}");
        }
    }
}
