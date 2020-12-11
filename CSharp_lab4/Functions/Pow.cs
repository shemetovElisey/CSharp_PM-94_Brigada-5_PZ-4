using System;
using System.Collections.Generic;

using static System.Math;

namespace CSharp_Lab_3
{
   public class Pow : Function
   {
      public Pow(Expr x, double power) : base(x)
      {
         Power = power;
         X = x;
      }

      private Expr X;
      private double Power;

      public override bool IsPolynom 
      {
         get 
         {
            return X.IsPolynom;
         }
      }

      public override bool IsConstant 
      {
         get 
         {
            return X.IsConstant || (Power == 0.0);
         }
      }

      public override double Compute(IReadOnlyDictionary<string, double> variableValues)
      {
         return Pow(_operand.Compute(variableValues), Power);
      } 
   }  
}