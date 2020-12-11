using System.Collections.Generic;
using System;

namespace CSharp_Lab_3
{
    class Constant : Expr
    {
        private double _value;

        public Constant(double value)
        {
            _value = value;
        }

        public double Value => _value;
        public static implicit operator Constant(double v) => new Constant(v);
        public override IEnumerable<string> Variables { get => new List<string> { }; protected set => throw new Exception(); }

        public override bool IsConstant => true;

        public override bool IsPolynom => true;

        public override double Compute(IReadOnlyDictionary<string, double> variableValues)
        {
            return _value;
        }
    }
}
