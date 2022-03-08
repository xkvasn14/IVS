///-------------------------------------------------------------------------------------------------
/// file:	Math.cs
/// <author> Jaroslav Kvasnicka </author>
/// <date> 20.4.2020 </date>
/// <summary>Implements the mathematics class</summary>	
///-------------------------------------------------------------------------------------------------

using System;

namespace Mathematics
{
    ///-------------------------------------------------------------------------------------------------
    /// <summary> A mathematics Library </summary>
    ///-------------------------------------------------------------------------------------------------

    public class Math
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary> Addition or summary function</summary>
        ///
        /// <param name="summand1"> First Summand.</param>
        /// <param name="summand2"> Second Summand</param>
        ///
        /// 
        ///-------------------------------------------------------------------------------------------------

        public double Sum(double summand1, double summand2)
        {
            return (summand1 + summand2);
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> Substraction function </summary>
        ///
        /// <param name="minuend">    The minuend.</param>
        /// <param name="subtrahend"> The subtrahend.</param>
        ///
        ///
        ///-------------------------------------------------------------------------------------------------

        public double Sub(double minuend, double subtrahend)
        {
            return (minuend - subtrahend);
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> Multiplikation function </summary>
        ///
        /// <param name="multiplicant"> The multiplicant.</param>
        /// <param name="multiplier">   The multiplier.</param>
        ///
        ///
        ///-------------------------------------------------------------------------------------------------

        public double Mul(double multiplicant, double multiplier)
        {
            return (multiplicant * multiplier);
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> Flooring function</summary>
        ///
        /// <param name="floorize"> The number to be floorize</param>
        ///
        /// <returns> A double without decimal point.</returns>
        ///-------------------------------------------------------------------------------------------------

        public double Floor(double floorize)
        {
            return System.Math.Floor(floorize);
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> Division function.</summary>
        ///
        /// <param name="divident"> The divident.</param>
        /// <param name="divisor">  The divisor.</param>
        ///
        ///
        ///-------------------------------------------------------------------------------------------------

        public double Div(double divident, double divisor)
        {
            if (divisor == 0 && divident > 0)
                return Double.PositiveInfinity;
            if (divisor == 0 && divident < 0)
                return Double.NegativeInfinity;
            if (divisor == 0 && divident == 0)
                return Double.NaN;
            return (divident / divisor);
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> Modulo function.</summary>
        ///
        /// <param name="divident"> The divident.</param>
        /// <param name="divisor">  The divisor.</param>
        ///
        ///
        ///-------------------------------------------------------------------------------------------------

        public double Mod(double divident, double divisor)
        {
            if (divisor == 0)
                return Double.NaN;
            return (divident % divisor);
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> Power function</summary>
        ///
        /// <param name="basis">    The basis.</param>
        /// <param name="exponent"> The exponent.</param>
        ///
        ///
        ///-------------------------------------------------------------------------------------------------

        public double Pow(double basis, double exponent)
        {
            return System.Math.Pow(basis, exponent);
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> Square function.</summary>
        ///
        /// <param name="basis">    The basis.</param>
        /// <param name="exponent"> The exponent.</param>
        ///
        ///
        ///-------------------------------------------------------------------------------------------------

        public double Sqrt(double basis, double exponent)
        {
            if (basis < 0)
                return Double.NaN;
            if (exponent == 0)
                return (System.Math.Sqrt(basis));
            else
            {
                exponent = 1 / exponent;
                return (System.Math.Pow(basis, exponent));
            }
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> Factorial function.</summary>
        ///
        /// <param name="factorial"> The factorial.</param>
        ///
        /// 
        ///-------------------------------------------------------------------------------------------------

        public double Fac(double factorial)
        {
            if ((factorial % 1) != 0)
                return Double.NaN;
            if (factorial < 0)
                return Double.NaN;

            if (factorial == 0)
                return 1.0;
            if (factorial > 10000)
                return double.PositiveInfinity;
            
            double result = factorial;
            for (double i = 1; i < factorial; i++)
                result = result * (factorial - i);
            return result;
        }


        ///////////////
        //PROFILING
        ///////////////
        

        ///-------------------------------------------------------------------------------------------------
        /// <summary> Counts the given array.</summary>
        ///
        /// <param name="arr"> The array of arguments</param>
        ///
        /// <returns> A double a single number</returns>
        ///-------------------------------------------------------------------------------------------------

        public double X_count(double[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
                sum = sum + arr[i];
            double result = (1 / Convert.ToDouble(arr.Length)) * sum;
            return result;
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> Counts Standard deviation</summary>
        ///
        /// <param name="x">   Single number of function X_count</param>
        /// <param name="arr"> The array of arguments</param>
        ///
        /// <returns> A double, a Standard deviation number</returns>
        ///-------------------------------------------------------------------------------------------------

        public double S_count(double x, double[] arr)
        {
            double counter = 0;
            ///SUM
            for(int i = 0; i<arr.Length;i++)
            {
                counter = counter + (System.Math.Pow(arr[i],2) - (Convert.ToDouble(arr.Length) * System.Math.Pow(x,2)));
            }
            double result = System.Math.Sqrt((1 / (Convert.ToDouble(arr.Length) - 1)) * counter);
            return result;
        }

    }
}
