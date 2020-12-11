using System.Collections.Generic;

namespace CSharp_Lab_3
{
    abstract public class UnaryOperation : Expr
    {
        protected IEnumerable<string> variables = null; 
        public override IEnumerable<string> Variables { get => variables; protected set => variables = value; }
        public UnaryOperation(Expr operand)
        {
            _operand = operand;
        }
        protected Expr _operand;
    }
}