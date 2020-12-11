using System.Collections.Generic;

namespace CSharp_Lab_3
{
    class Sum : BinaryOperation
    {
        public Sum(Expr left, Expr right) : base(left, right) { }

        public override double Compute(IReadOnlyDictionary<string, double> variableValues)
             => LhsArg.Compute(variableValues) + RhsArg.Compute(variableValues);

        public override bool IsConstant { get => LhsArg.IsConstant && RhsArg.IsConstant; }
        public override bool IsPolynom { get => LhsArg.IsPolynom && RhsArg.IsPolynom; }
    }
}