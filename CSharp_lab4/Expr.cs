using System.Collections.Generic;

namespace CSharp_Lab_3
{
    public abstract class Expr
    {
        public abstract double Compute(IReadOnlyDictionary<string, double> variableValues);
        public abstract IEnumerable<string> Variables { get; protected set; }
        public abstract bool IsConstant { get; }
        public abstract bool IsPolynom { get; }
        public static Expr operator /(Expr l, Expr r) => new Divide(l, r);
        public static Expr operator -(Expr l, Expr r) => new Subtract(l, r);
        public static Expr operator *(Expr l, Expr r) => new Multiply(l, r);
        public static Expr operator +(Expr l, Expr r) => new Sum(l, r);
        public static Expr operator -(Expr e) => new Multiply(-1, e);
        public static implicit operator Expr (double v) => new Constant(v);
        public static implicit operator Expr (string v) => new Variable(v);
    }
}
