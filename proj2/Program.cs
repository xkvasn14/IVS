///-------------------------------------------------------------------------------------------------
/// file:	Program.cs
/// <author> Jaroslav Kvasnička </author>
///<date> 20.4.2020 </date>
/// summary:	Implements the program class
///-------------------------------------------------------------------------------------------------

using System;
using Mathematics;

namespace Profiling
{
    ///-------------------------------------------------------------------------------------------------
    /// <summary> Standart Deviation count program </summary>
    ///-------------------------------------------------------------------------------------------------

    class Program
    {
        /// <summary> The mathematics library </summary>
        static Mathematics.Math Math = new Mathematics.Math();

        ///-------------------------------------------------------------------------------------------------
        /// <summary> Count of a Standart Deviation </summary>
        ///
        /// <param name="args"> Input are used arguments at stdin</param>
        ///-------------------------------------------------------------------------------------------------

        static void Main(string[] args)
        {
            double s = 0;
            double[] arr = new double[args.Length];

            if (arr.Length != 0)
            {
                for (int i = 0; i < args.Length; i++)
                    arr[i] = Convert.ToDouble(args[i]);
                double x = Math.X_count(arr);
                s = Math.S_count(x, arr);
            }
            else
                s = 0;
            Console.WriteLine(s);
        }
    }
}
