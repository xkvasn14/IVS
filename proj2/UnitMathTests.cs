///-------------------------------------------------------------------------------------------------
/// file:	UnitMathTests.cs
/// <author>Jaroslav Kvasnicka</author>
/// <date> 20.4.2020 </date>
/// summary:	Implements the unit mathematics tests class
///-------------------------------------------------------------------------------------------------

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace MathLibTests
{
    ///-------------------------------------------------------------------------------------------------
    /// <summary> Unit mathematics tests.</summary>
    ///-------------------------------------------------------------------------------------------------

    [TestClass]
    public class UnitMathTests
    {
        /// <summary> The mathematics library.</summary>
        Mathematics.Math Math = new Mathematics.Math();

        ///-------------------------------------------------------------------------------------------------
        /// <summary> SUM - Testing positive + positive number</summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void positive_positive_Sum()
        {
            double positive;
            positive = 1000.00;
            Assert.AreEqual(positive * 2, Math.Sum(positive, positive));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> SUM - Testing positive + negative number</summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void positive_negative_Sum()
        {
            double negative, positive;
            negative = -1000;
            positive = 1000;
            Assert.AreEqual(positive*0,Math.Sum(positive,negative));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> SUM - Testing negative + positive number</summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void negative_positive_Sum()
        {
            double negative, positive;
            negative = -1000.000;
            positive = 1000;
            Assert.AreEqual(negative * 0, Math.Sum(negative, positive));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> SUM - Testing negative + negative number</summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void negative_negative_Sum()
        {
            double negative;
            negative = -1000.000;
            Assert.AreEqual(negative * 2, Math.Sum(negative, negative));
        }

        
        ///-------------------------------------------------------------------------------------------------
        /// <summary> SUB - Testing positive - positive number </summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void positive_positive_Sub()
        {
            double positive;
            positive = 1000;
            Assert.AreEqual(0, Math.Sub(positive, positive));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> SUB - Testing negative - negative number </summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void negative_negative_Sub()
        {
            double negative;
            negative = -1000.001;
            Assert.AreEqual(negative*0, Math.Sub(negative,negative));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> SUB - Testing positive - negative number </summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void positive_negative_Sub()
        {
            double positive,negative;
            positive = 1000;
            negative = -1000;
            Assert.AreEqual(2000, Math.Sub(positive, negative));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> SUB - Testing negative - positive number </summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void negative_positive_Sub()
        {
            double positive,negative;
            positive = 1000.000;
            negative = -1000.000;
            Assert.AreEqual(-2000, Math.Sub(negative, positive));
        }

       
        ///-------------------------------------------------------------------------------------------------
        /// <summary> MUL -Testing positive x positive number</summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void positive_positive_Mul()
        {
            double positive;
            positive = 1000.000;
            Assert.AreEqual(1000*1000, Math.Mul(positive, positive));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> MUL - Testing negative x negative number</summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void negative_negative_Mul()
        {
            double negative;
            negative = -1000.000;
            Assert.AreEqual(1000000, Math.Mul(negative, negative));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> MUL - Testing negative x positive number</summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void negative_positive_Mul()
        {
            double positive, negative;
            positive = 1000.000;
            negative = -1000.000;
            Assert.AreEqual(positive*negative, Math.Mul(negative, positive));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> MUL - Testing positive x negative number </summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void positive_negative_Mul()
        {
            double positive, negative;
            positive = 1000.000;
            negative = -1000.000;
            Assert.AreEqual(-1000000, Math.Mul(positive,negative));
        }

    
        ///-------------------------------------------------------------------------------------------------
        /// <summary> DIV - Testing positive / positive number</summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void positive_positive_Div()
        {
            double positive;
            positive = 1000.000;
            Assert.AreEqual(1, Math.Div(positive, positive));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> DIV - Testing negative / negative number</summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void negative_negative_Div()
        {
            double negative;
            negative = -1000.000;
            Assert.AreEqual(1, Math.Div(negative, negative));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> DIV - Testing negative / positive number</summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void negative_positive_Div()
        {
            double positive, negative;
            positive = 1000.000;
            negative = -1000.000;
            Assert.AreEqual(positive / negative, Math.Div(negative, positive));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> DIV - Testing positive / negative number </summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void positive_negative_Div()
        {
            double positive, negative;
            positive = 1000.000;
            negative = -1000.000;
            Assert.AreEqual(-1, Math.Div(positive, negative));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> DIV - Testing positive number / 0 </summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void divByZero_Positive()
        {
            double number = 10;
            Assert.AreEqual(Double.PositiveInfinity, Math.Div(number, 0));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> DIV - Testing negative number / 0 </summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void divByZero_Negative()
        {
            double number = -10;
            Assert.AreEqual(Double.NegativeInfinity, Math.Div(number, 0));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> DIV - Testing devision zero by zero </summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void divByZero_NaN()
        {
            double number = 0;
            Assert.AreEqual(Double.NaN, Math.Div(number, 0));
        }

       
        ///-------------------------------------------------------------------------------------------------
        /// <summary> MOD - Testing positive % positive number </summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void positive_positive_Mod()
        {
            double positive;
            positive = 1000.000;
            Assert.AreEqual(0, Math.Mod(positive, positive));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> MOD - Testing negative % negative number </summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void negative_negative_Mod()
        {
            double negative;
            negative = -1000.000;
            Assert.AreEqual(0, Math.Mod(negative, negative));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> MOD - Testing negative % positive number </summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void negative_positive_Mod()
        {
            double positive, negative;
            positive = 1000.000;
            negative = -1000.000;
            Assert.AreEqual(positive % negative, Math.Mod(negative, positive));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> MOD - Testing positive % negative number </summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void positive_negative_Mod()
        {
            double positive, negative;
            positive = 1000.000;
            negative = -1000.000;
            Assert.AreEqual(0, Math.Mod(positive, negative));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> MOD - Testing positive number % 0 </summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void divByZero()
        {
            double number = 10;
            Assert.AreEqual(Double.NaN, Math.Mod(number, 0));
        }

       
        ///-------------------------------------------------------------------------------------------------
        /// <summary> FAC - Testing decimal point in number </summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void decPoint_Fac()
        {
            double number = 10.5;
            Assert.AreEqual(Double.NaN, Math.Fac(number));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> FAC - Testing negative number</summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void Negative_Fac()
        {
            double number = -10;
            Assert.AreEqual(Double.NaN, Math.Fac(number));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> FAC - Testing zero number </summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void Zero_Fac()
        {
            double number = 0;
            Assert.AreEqual(1, Math.Fac(number));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> FAC - Testing positive number without decimal point </summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void Positive_Fac()
        {
            double number = 7;
            Assert.AreEqual(7*6*5*4*3*2*1, Math.Fac(number));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> FAC - Testing overflow </summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void Overflow_Fac()
        {
            double number = 1000;
            Assert.AreEqual(Double.PositiveInfinity, Math.Fac(number));
        }

       
        ///-------------------------------------------------------------------------------------------------
        /// <summary> FLOOR - Testing decimal point in number</summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void decPoint_Floor()
        {
            double number = 10.05;
            Assert.AreEqual(10.00, Math.Floor(number));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> FLOOR - Testing decimal point in number</summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void decPoint2_Floor()
        {
            double number = 10.1489655;
            Assert.AreEqual(10.00, Math.Floor(number));
        }

        
        ///-------------------------------------------------------------------------------------------------
        /// <summary> POW - Testing positive powered by positive number</summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void positive_positive_Pow()
        {
            double positive;
            positive = 3.00;
            Assert.AreEqual(positive * positive * positive, Math.Pow(positive, positive));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> POW - Testing positive powered by negative number</summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void positive_negative_Pow()
        {
            double negative, positive;
            negative = -5;
            positive = 5;
            Assert.AreEqual(0.00032, Math.Pow(positive, negative));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> POW - Testing negative powered by positive number </summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void negative_positive_Pow()
        {
            double negative, positive;
            negative = -5;
            positive = 5;
            Assert.AreEqual(-3125, Math.Pow(negative, positive));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> POW - Testing negative powered by negative number </summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void negative_negative_Pow()
        {
            double negative;
            negative = -4;
            Assert.AreEqual(0.003906, Math.Pow(negative, negative),0.000001);
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> POW - Testing positive number powered by zero </summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void OnZero_Pow()
        {
            double number = 256826;
            Assert.AreEqual(1, Math.Pow(number, 0));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> POW - Testing zero number powered by positive number </summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void Zero_Pow()
        {
            double number = 0;
            Assert.AreEqual(0, Math.Pow(number, 55));
        }

        
        ///-------------------------------------------------------------------------------------------------
        /// <summary> SQRT - Testing sqrt positive number</summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void Positive_Sqrt()
        {
            double number;
            number = 100;
            Assert.AreEqual(10, Math.Sqrt(number, 2));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> SQRT - Testing sqrt negative number </summary>
        ///-------------------------------------------------------------------------------------------------

        public void Negative_Sqrt()
        {
            double number;
            number = -100;
            Assert.AreEqual(Double.NaN, Math.Sqrt(number, 2));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> SQRT - Testing sqrt zero number </summary>
        ///-------------------------------------------------------------------------------------------------

        public void Zero_Sqrt()
        {
            double number;
            number = 0;
            Assert.AreEqual(0, Math.Sqrt(number, 2));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> SQRT - Testing Positive number squared by zero </summary>
        ///-------------------------------------------------------------------------------------------------

        public void OnZero_Sqrt()
        {
            double number;
            number = 100;
            Assert.AreEqual(10, Math.Sqrt(number, 0));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> SQRT - Testing positive number squared by negative number </summary>
        ///-------------------------------------------------------------------------------------------------

        public void OnNegative_Sqrt()
        {
            double number;
            number = 10;
            Assert.AreEqual(100,Math.Sqrt(number,-2));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> SQRT - Testing positive number squared by positive number </summary>
        ///-------------------------------------------------------------------------------------------------

        public void OnPositive_Sqrt()
        {
            double number;
            number = 1000;
            Assert.AreEqual(10,Math.Sqrt(number,3));
        }

      
        ///-------------------------------------------------------------------------------------------------
        /// <summary> X_count - Testing with all positive numbers </summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void positive_xcount()
        {
            double[] arr = { 1, 2, 3, 4, 5.00 };
            Assert.AreEqual(3, Math.X_count(arr));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> X_count - Testing with all negative numbers </summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void negative_xcount()
        {
            double[] arr = { -1.00, -2, -3, -4.00, -5 };
            Assert.AreEqual(-3, Math.X_count(arr),0.01);
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> X_count - Testing with mix positive and negative numbers </summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void mix_xcount()
        {
            double[] arr = { 1, -2.5, 3, 4.4, -5 };
            Assert.AreEqual(0.18, Math.X_count(arr),0.01);
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> S_count - Testing with all positive numbers </summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void positive_scount()
        {
            double[] arr = { 1.00, 2, 3, 4, 5 };
            double x = 2;
            Assert.AreEqual(Double.NaN, Math.S_count(x, arr));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> S_count - Testing with all negative numbers and positive constant </summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void negative_scount()
        {
            double[] arr = { -1.00, -2.00, -3.00, -4, -5 };
            double x = 2;
            Assert.AreEqual(Double.NaN, Math.S_count(x, arr));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> S_count - Testing with mixed numbers and negative constant </summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void mix_scount()
        {
            double[] arr = { 1, 2, 3, -4, 5 };
            double x = -1;
            Assert.AreEqual(2.738612, Math.S_count(x, arr),0.000001);
        }

    }
}
