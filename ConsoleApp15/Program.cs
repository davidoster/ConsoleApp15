using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {

        Print print = delegate (string msg)
        {
            Console.WriteLine(msg);
        };

        static void Main(string[] args)
        {
            //string input = "A10";
            //bool succeeded = int.TryParse(input, out int j);
            //Console.WriteLine(j);
            //int k = 20;
            //int l = k + 40;
            //l += j;
            //Console.WriteLine(l);

            //int result = DivideTwoIntegers(2, 3, out int remainder);
            //Console.WriteLine($"Result: {result} Remainder: {remainder}");

            //Console.WriteLine(DivideTwoIntegers(2,3));
            //int times = 0;
            //string s = null;
            //DummyMethod("Some message", ref times, ref s, out bool done);
            //Console.WriteLine(times);

            //decimal dec = 100.1234567m;
            //Console.WriteLine("{0:N4}", dec);

            //string root  = @"C:\Root";
            //string root2 = @"C:\root";
            //var comparison = root.Equals(root2);
            //Console.WriteLine(comparison);
            //var comparison2 = root.Equals(root2, StringComparison.OrdinalIgnoreCase);
            //Console.WriteLine(comparison2);
            //var comparison3 = root == root2;
            //Console.WriteLine(comparison3);

            //var x = 10;
            //var s = "sdfdsf";
            //x = s;
            Program p = new Program();
            //p.DivideTwoIntegers(2, 3, out int remainder);
            Program p2 = new Program();
            ////DivideTwoIntegers(1, 2, out int remainders2);
            //CalcInts mySum = p.Sum;
            //mySum(1, 2);

            //CalcInts myDiv = p.Div;
            //myDiv(1, 2);

            //CalcInts mySub = p.Sub;
            //mySub(1, 2);

            //CalcInts myCalcs1 = p.Div;
            //CalcInts myCalcs2 = p.Sub;
            //CalcInts myCalcs3 = p.Sum;
            //CalcInts AllCalcs = myCalcs1 + myCalcs2 + myCalcs3;
            //Console.WriteLine(AllCalcs(1, 2));

            //myCalcs(1, 2);
            //myCalcs = p.GreaterThanZero;
            //myCalcs(1, 2);
            //p.DummyMethod2(myCalcs);

            //Print print = delegate (string msg)
            //{
            //    Console.WriteLine(msg);
            //};
            //p.print("AAAA");

            Del x; //
            x = i => i * 10 - 2 + 1;
            Console.WriteLine(x(5));
            x = i => i - 20;
            Console.WriteLine(x(5));

            Del2 del2;
            del2 = (i, j) => i + j;
            Console.WriteLine(del2(1,2));


        }

        public delegate void PrintHome(Home home);

        public delegate int Del2(int i, int j);
        public delegate int Del(int i);
        public delegate void Print(string msg);

        public delegate int CalcInts(int i, int j);
       
        public void DummyMethod2(CalcInts calc)
        {
            Console.WriteLine(calc(1,2));
        }
        public int Sum(int i, int j)
        {
            Console.WriteLine(i + j);
            return (i + j);
        }

        public int Div(int i, int j)
        {
            Console.WriteLine(i / j);
            return (i / j);
        }

        public int Sub(int i, int j)
        {
            Console.WriteLine(i - j);
            return (i - j);
        }

        public int GreaterThanZero(int i, int j)
        {
            return (i);
        }

        // procedure
        public int DivideTwoIntegers(int i, int j, out int remainder)
        {
            remainder = i % j;
            return (i / j); 
        }

        // function
        static int DivideTwoIntegers(int i, int j)
        {
            return (i / j);
        }

        // procedure
        static string DummyMethod(string msg, ref int times, ref string s, out bool done)
        {
            string result = "";
            for (int i = 0; i < times; i++)
            {
                result += msg + "\n";
                Console.WriteLine(msg);
            }
            times = 10;
            done = false;
            return(result);
        }


        /*
         * Delegates: 
         * 1. define the actual delegate, e.g. public delegate int CalculateInts(int i, int j)
         * 2. define the method(s) that work with a same method signature, e.g.
         *    public int SumTwoIntegers(int i, int j)
         *    public int DivTwoIntegers(int i, int j)
         * 3. define a name for the delegate type that is well understood what this thing does, e.g.
         *    CalculateInts IntegerCalculations;
         * 4. Initialize the delegate with the appropriate body method, e.g.
         *    IntegerCaclulations = SumTwoIntegers, which means that:
         *    IntegerCaclulations(1,2) the result will be an addition of the two integers 1 + 2 = 3
         * 5. Initialize the delegate with the appropriate body method, e.g.
         *    IntegerCaclulations = DivTwoIntegers, which means that:
         *    IntegerCaclulations(1,2) the result will be an division of the two integers 1 / 2 = 0
         *    
         */ 




    }
}
