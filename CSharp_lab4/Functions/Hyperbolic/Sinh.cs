using System;
using System.Collections.Generic;

using static System.Math;

namespace CSharp_Lab_3
{
    public class Sinh : Function
   {
      public Sinh(Expr x) : base(x) { }

      public override bool IsConstant { get => false; }
      public override bool IsPolynom { get => false; }

      public override double Compute(IReadOnlyDictionary<string, double> variableValues)
      {
         return Sinh(_operand.Compute(variableValues));
      }
   }
}