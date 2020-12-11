using System.Collections.Generic;
using System.Linq;

namespace CSharp_Lab_3
{
   abstract public class BinaryOperation : Expr
   {
      public override IEnumerable<string> Variables 
        {
            get
            {
                if (variables == null)
                    variables = LhsArg.Variables.Union(RhsArg.Variables);
                    
                return variables;
            }
            protected set => variables = value; 
        }
        public BinaryOperation(Expr operand1, Expr operand2)
        {
            LhsArg = operand1;
            RhsArg = operand2;
        }
      protected IEnumerable<string> variables = null;
      protected Expr LhsArg;
      protected Expr RhsArg;
   }
}