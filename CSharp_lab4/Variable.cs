using System.Collections.Generic;
using System;

namespace CSharp_Lab_3
{
    class Variable : Expr
    {
        private string var;
        public Variable(string Var) => var = Var;
        public override bool IsConstant { get => false; }
        public override bool IsPolynom { get => true; }
        public override IEnumerable<string> Variables { get => new List<string> { }; protected set => throw new Exception(); }
        public override double Compute(IReadOnlyDictionary<string, double> variableValues) => variableValues[var];
    }
}