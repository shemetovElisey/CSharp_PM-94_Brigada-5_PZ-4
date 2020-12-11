// using System;
// using System.Collections.Generic;

// using static System.Math;
// namespace CSharp_Lab_3
// {
//    class Program
//    {
//       static void Main()
//       {
//          var x = new Variable("x");
//          var y = new Variable("y");

//          Console.WriteLine("f(x,y) = (x + y) * Sin(x / 2)");
//          var expr = (x + y) * new Sin(x/2);

//          Console.WriteLine("f(5, 3) = {0:F3}", expr.Compute(new Dictionary<string, double> { ["x"] = 5, ["y"] = 3 }));

//          Console.WriteLine("f(pi/6, 7) = {0:F3}", expr.Compute(new Dictionary<string, double> { ["x"] = PI / 6, ["y"] = 7 }));

//          expr = new Pow(new Tan(x/2), 2/3) + new Cot(x/2) * (1/3)/y;

//          Console.WriteLine("f(0,3) = {0:F3}", expr.Compute(new Dictionary<string, double> { ["x"] = 0, ["y"] = 3 }));

//          Console.WriteLine("f(7pi/3, 6) = {0:F3}", expr.Compute(new Dictionary<string, double> { ["x"] = PI / 3, ["y"] = 6 }));
//          Console.ReadKey();
//       }
//    }
// }
