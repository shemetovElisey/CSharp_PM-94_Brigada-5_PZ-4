using System.Collections.Generic;

namespace CSharp_Lab_3
{

    class Divide : BinaryOperation
    {
        public Divide(Expr left, Expr right) : base(left, right) { }

        public override double Compute(IReadOnlyDictionary<string, double> variableValues)
           => LhsArg.Compute(variableValues) / RhsArg.Compute(variableValues);
        public override bool IsConstant { get => LhsArg.IsConstant && RhsArg.IsConstant || LhsArg.Equals(RhsArg); }
        public override bool IsPolynom { get => LhsArg.IsPolynom && RhsArg.IsConstant && !LhsArg.Equals(RhsArg); }
    }
}