
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

using static System.Math;

namespace CSharp_Lab_3
{

    [TestClass]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    public class UnitTests
    {
        private double error = 0.01;
        [TestMethod]
        public void Add2ConstantsTest()
        {
            var const1 = new Constant(1);
            var const2 = new Constant(2);
            var res = const1 + const2;
            Assert.AreEqual(3, res.Compute(null));
        }
        [TestMethod]
        public void Add2VariablesTest()
        {
            var var1 = new Variable("x");
            var var2 = new Variable("y");
            var res = var1 + var2;
            Assert.AreEqual(3, res.Compute(new Dictionary<string, double>() { ["x"] = 1, ["y"] = 2 }));
        }


        [TestMethod]
        public void Subtract2ConstantsTest()
        {
            var const1 = new Constant(1);
            var const2 = new Constant(2);
            var res = const1 - const2;
            Assert.AreEqual(-1, res.Compute(null));
        }
        [TestMethod]
        public void Subtract2VariablesTest()
        {
            var var1 = new Variable("x");
            var var2 = new Variable("y");
            var res = var1 - var2;
            Assert.AreEqual(-1, res.Compute(new Dictionary<string, double>() { ["x"] = 1, ["y"] = 2 }));
        }

        
        [TestMethod]
        public void Multiply2ConstantsTest()
        {
            var const1 = new Constant(4);
            var const2 = new Constant(2);
            var res = const1 * const2;
            Assert.AreEqual(8, res.Compute(null));
        }
        [TestMethod]
        public void Multiply2VariablesTest()
        {
            var var1 = new Variable("x");
            var var2 = new Variable("y");
            var res = var1 * var2;
            Assert.AreEqual(8, res.Compute(new Dictionary<string, double>() { ["x"] = 4, ["y"] = 2 }));
        }


        [TestMethod]
        public void Divide2ConstantsTest()
        {
            var const1 = new Constant(4);
            var const2 = new Constant(2);
            var res = const1 / const2;
            Assert.AreEqual(2, res.Compute(null));
        }
        [TestMethod]
        public void Divide2VariablesTest()
        {
            var var1 = new Variable("x");
            var var2 = new Variable("y");
            var res = var1 / var2;
            Assert.AreEqual(2, res.Compute(new Dictionary<string, double>() { ["x"] = 4, ["y"] = 2 }));
        }

        
        [TestMethod]
        public void Power2ConstantsTest()
        {
            var const1 = new Constant(4);
            var const2 = 2.0;
            var res = new Pow(const1, const2);
            Assert.AreEqual(16, res.Compute(null));
        }
        [TestMethod]
        public void PowerVariableConstantTest()   
        {
            var var1 = new Variable("x");
            var var2 = 2.0;
            var res = new Pow(var1, var2);
            Assert.AreEqual(16, res.Compute(new Dictionary<string, double>() { ["x"] = 4 }));
        }


        [TestMethod]
        public void ArctanConstantTest()
        {
            var const1 = new Constant(4);
            var res = new Arctan(const1);
            Assert.AreEqual(1.32, res.Compute(null), error);
        }
        [TestMethod]
        public void ArctanVariableTest()
        {
            var var1 = new Variable("x");
            var res = new Arctan(var1);
            Assert.AreEqual(1.32, res.Compute(new Dictionary<string, double>() { ["x"] = 4 }), error);
        }


        [TestMethod]
        public void ArccotConstantTest()
        {
            var const1 = new Constant(4);
            var res = new Arctan(const1);
            Assert.AreEqual(1.32, res.Compute(null), error);
        }
       
       
        [TestMethod]
        public void AddIsPolynom()
        {
            var var1 = new Variable("x");
            var var2 = new Variable("y");
            var res = ((Sum)(var1 + var2)).IsPolynom;
            Assert.AreEqual(true, res);
        }
        [TestMethod]
        public void AddIsConst2Vars()
        {
            Variable var1 = new Variable("x");
            Variable var2 = new Variable("y");
            var res = ((Sum)(var1 + var2)).IsConstant;
            Assert.AreEqual(false, res);
        }
        [TestMethod]
        public void AddIsConst2Const()
        {
            Constant var1 = 2;
            Constant var2 = 2;
            var res = ((Sum)(var1 + var2)).IsPolynom;
            Assert.AreEqual(true, res);
        }
        [TestMethod]
        public void AddIsConstConstVar()
        {
            Variable var1 = new Variable("x");
            Constant var2 = 2;
            var res = ((Sum)(var1 + var2)).IsConstant;
            Assert.AreEqual(false, res);
        }
        [TestMethod]
        public void AddIsConstConstVar2()
        {
            Variable var1 = new Variable("x");
            Constant var2 = 2;
            var res = ((Sum)(var2 + var1)).IsConstant;
            Assert.AreEqual(false, res);
        }
        [TestMethod]
        public void AddIsPolynomVarAndNonpolynom()
        {
            Variable var1 = new Variable("x");
            var e = new Arcsin("t");
            var res = ((Sum)(var1 + e)).IsPolynom;
            Assert.AreEqual(false, res);
        }
        [TestMethod]
        public void AddIsPolynomPolAndNonPol ()
        {
            var var1 = new Arcsin("x");
            Variable e =new Variable("t");
            var res = ((Sum)(var1 + e)).IsPolynom;
            Assert.AreEqual(false, res);
        }

        
        [TestMethod]
        public void SubIsPolynom()
        {
            Variable var1 = new Variable("x");
            Variable var2 = new Variable("y");
            var res = (var1 - var2).IsPolynom;
            Assert.AreEqual(true, res);
        }

        
        [TestMethod]
        public void MulIsPolynom()
        {
            var var1 = new Variable("x");
            var var2 = new Variable("y");
            var res = (var1 * var2).IsPolynom;
            Assert.AreEqual(true, res);
        }
        [TestMethod]
        public void MulIsPolynomPolAndNonpol()
        {
            var var1 = new Arcsin("x");
            var var2 = new Variable("y");
            var res = (var1 * var2).IsPolynom;
            Assert.AreEqual(false, res);
        }

        
        [TestMethod]
        public void PowIsConst2Const()
        {
            var const1 = new Constant(1);
            var const2 = 1.0;
            var res = new Pow(const1, const2).IsConstant;
            Assert.AreEqual(true, res);
        }
        [TestMethod]
        public void PowIsPolynom2Const()
        {
            var const1 = new Constant(1);
            var const2 = 1.0;
            var res = new Pow(const1, const2).IsPolynom;
            Assert.AreEqual(true, res);
        }
        [TestMethod]
        public void PowIsPolynomPolPowerConst()
        {
            var const1 = new Variable("x");
            var const2 = 1.0;
            var res = new Pow(const1, const2).IsPolynom;
            Assert.AreEqual(true, res);
        }
        [TestMethod]
        public void PowIsPolynom2nonPol()
        {
            var const1 = new Arcsin("x");
            var const2 = 2.0;
            var res = new Pow(const1, const2).IsPolynom;
            Assert.AreEqual(false, res);
        }

        
        [TestMethod]
        public void MulIsConst2Vars()
        {
            var var1 = new Variable("x");
            var var2 = new Variable("y");
            var res = (var1 * var2).IsConstant;
            Assert.AreEqual(false, res);
        }
        [TestMethod]
        public void MulIsConst2Const()
        {
            Constant var1 =3;
            Constant var2 =3;
            var res = (var1 * var2).IsConstant;
            Assert.AreEqual(true, res);
        }

        
        [TestMethod]
        public void DivIsPolynom()
        {
            var var1 = new Variable("x");
            var var2 = new Variable("y");
            var res = (var1 / var2).IsPolynom;
            Assert.AreEqual(false, res);
        }
        [TestMethod]
        public void DivIsPolynomPolynomAndConst()
        {
            var var1 = new Variable("x");
            Constant const1 = 1;
            var res = (var1 / 1).IsPolynom;
            Assert.AreEqual(true, res);
        }
        [TestMethod]
        public void DivIsPolynomSameVars()
        {
            var var1 = new Variable("x");
            var var2 = new Variable("x");
            var res = (var1 / var2).IsPolynom;
            Assert.AreEqual(false, res);
        }
        [TestMethod]
        public void DivIsPolynomFuncAndVar()
        {
            var var1 = new Arcsin("x");
            var var2 = new Variable("x");
            var res = (var1 / var2).IsPolynom;
            Assert.AreEqual(false, res);
        }
        [TestMethod]
        public void DivIsConstantDifferentVars()
        {
            var var1 = new Variable("x");
            var var2 = new Variable("y");
            var res = (var1 / var2).IsConstant;
            Assert.AreEqual(false, res);
        }
        [TestMethod]
        public void DivIsConstantVarAndFunction()
        {
            var var1 = new Variable("x");
            var var2 = new Arcsin("y");
            var res = (var1 / var2).IsConstant;
            Assert.AreEqual(false, res);
        }
        [TestMethod]
        public void DivIsConstant2()
        {
            Constant const1 = 1;
            Constant const2 = 2;
            var res = (const1 / const2).IsConstant;
            Assert.AreEqual(true, res);
        }
        [TestMethod]
        public void DivIsConstantAndVar()
        {
            Constant const1 = 1;
            var const2 = new Variable("x");
            var res = (const1 / const2).IsConstant;
            Assert.AreEqual(false, res);
        }


        [TestMethod]
        public void ArccotVariableTest()
        {
            var var1 = new Variable("x");
            var res = new Arctan(var1);
            Assert.AreEqual(1.32, res.Compute(new Dictionary<string, double>() { ["x"] = 4 }), error);
        }


        [TestMethod]
        public void ArccosConstantTest()
        {
            var const1 = new Constant(0.7);
            var res = new Arccos(const1);
            Assert.AreEqual(0.79, res.Compute(null), error);
        }


        [TestMethod]
        public void ArccosVariableTest()
        {
            var var1 = new Variable("x");
            var res = new Arccos(var1);
            Assert.AreEqual(0.79, res.Compute(new Dictionary<string, double>() { ["x"] = 0.7 }), error);
        }


        [TestMethod]
        public void ArcsinConstantTest()
        {
            var const1 = new Constant(0.7);
            var res = new Arcsin(const1);
            Assert.AreEqual(0.77, res.Compute(null), error);
        }


        [TestMethod]
        public void ArcsinVariableTest()
        {
            var var1 = new Variable("x");
            var res = new Arcsin(var1);
            Assert.AreEqual(0.77, res.Compute(new Dictionary<string, double>() { ["x"] = 0.7 }), error);
        }


        [TestMethod]
        public void IsPolynom_Arccos()
        {
            var var1 = new Variable("x");
            var res = new Arccos(var1).IsPolynom;
            Assert.AreEqual(false, res);
        }


        [TestMethod]
        public void IsPolynom_Arccot()
        {
            var var1 = new Variable("x");
            var res = new Arccot(var1).IsPolynom;
            Assert.AreEqual(false, res);
        }


        [TestMethod]
        public void IsPolynom_Arctan()
        {
            var var1 = new Variable("x");
            var res = new Arccot(var1).IsPolynom;
            Assert.AreEqual(false, res);
        }
        [TestMethod]
        public void IsPolynom_Pow()
        {
            var var1 = new Variable("x");
            var const1 = 4.0;
            var res = new Pow(var1, const1).IsPolynom;
            Assert.AreEqual(true, res);
        }


        [TestMethod]
        public void IsPolynom_Const()
        {
            var res = new Constant(4).IsPolynom;
            Assert.AreEqual(true, res);
        }
        [TestMethod]
        public void IsPolynom_Variable()
        {
            var res = new Variable("x").IsPolynom;
            Assert.AreEqual(true, res);
        }
        [TestMethod]
        public void IsPolynomXAddX()
        {
            var var1 = new Variable("x");
            var res = (Sum)( var1 + var1);
            Assert.AreEqual(true, res.IsPolynom);
        }
        [TestMethod]
        public void IsPolynom1AddX()
        {
            var var1 = new Variable("x");
            var const1 = new Arcsin("е");
            var res = var1 + const1;
            Assert.AreEqual(false, res.IsPolynom);
        }
        [TestMethod]
        public void IsPolynomArccot()
        {
            var const1 = new Arctan("е");
            Assert.AreEqual(false, const1.IsPolynom);
        }
        [TestMethod]
        public void IsPolynomArcsinX()
        {
            var var1 = new Variable("x");
            var res = new Arcsin(var1);
            Assert.AreEqual(false, res.IsPolynom);
        }
        [TestMethod]
        public void IsPolynomArctanX()
        {
            var var1 = new Variable("x");
            var res = new Arccot(var1);
            Assert.AreEqual(false, res.IsPolynom);
        }
        [TestMethod]
        public void IsConstantAdd()
        {
            var var1 = new Variable("x");
            var res = var1 + var1;
            Assert.AreEqual(false, res.IsConstant);
        }
        [TestMethod]
        public void IsConstantDiv()
        {
            var var1 = new Variable("x");
            var res = var1 / var1;
            Assert.AreEqual(true, res.IsConstant);
        }
        
        
        [TestMethod]
        public void IsConstantMul()
        {
            var var1 = new Variable("x");
            var res = var1 * var1;
            Assert.AreEqual(false, res.IsConstant);
        }
        [TestMethod]
        public void IsConstantSub()
        {
            var var1 = new Variable("x");
            var res = (var1 - var1).IsConstant;
            Assert.AreEqual(true, res);
        }
        [TestMethod]
        public void IsConstantPow()
        {
            Constant const1 = 1;
            var const2 = 2.0;
            var res = new Pow(const1, const2);
            Assert.AreEqual(true, res.IsConstant);
        }


        [TestMethod]
        public void VariablesAdd()
        {
            var var1 = new Variable("x");
            var res = var1 + var1;
            Assert.AreEqual(false, new List<string>{"x"}.SequenceEqual( res.Variables));
        }
        [TestMethod]
        public void VariablesConstant()
        {
            Constant const1 = 2;
            Assert.AreEqual(0, const1.Variables.Count());
        }
        
        
        [TestMethod]
        public void SubIsPolynom2()
        {
            var var1 = new Variable("x");
            var var2 = new Variable("y");
            var res = (var1 - var2).IsPolynom;
            Assert.AreEqual(true, res);
        }
        [TestMethod]
        public void SubIsPolynomPolAndNonpol()
        {
            var var1 = new Variable("x");
            var var2 = new Arcsin("y");
            var res = var1 - var2;
            Assert.AreEqual(false, res.IsPolynom);
        }
        [TestMethod]
        public void SubIsPolynom2Nonpol()
        {
            var var1 = new Arcsin("x");
            var var2 = new Arcsin("y");
            var res = var1 - var2;
            Assert.AreEqual(false, res.IsPolynom);
        }

        
        [TestMethod]
        public void ComputeVariable()
        {
            var var1 = new Variable("x");
            Assert.AreEqual(3, var1.Compute(new Dictionary<string, double> { ["x"] = 3 }));
        }
    }
}