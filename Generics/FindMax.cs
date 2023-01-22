using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace Generics
{
    public  class FindMax
    {
        public int MaximumNumber(int val1,int val2, int val3)
        {
            if(val1 <= val2)
            {
                if (val2 < val3)
                    return val3;
                else
                    return val2;
            }
            else 
            {
                if (val1 < val3)
                    return val3;
                else
                    return val1;
            }
            return 0;
           
        }

        public double MaximumNumber(double val1, double val2, double val3)
        {
            if (val1 <= val2)
            {
                if (val2 < val3)
                    return val3;
                else
                    return val2;
            }
            else
            {
                if (val1 < val3)
                    return val3;
                else
                    return val1;
            }
            return 0;
        }

        public string MaximumNumber(string val1, string val2, string val3)
        {
            if (val1.Length <= val2.Length)
            {
                if (val2.Length < val3.Length)
                    return val3;
                else
                    return val2;
            }
            else
            {
                if (val1.Length < val3.Length)
                    return val3;
                else
                    return val1;
            }
            return "";

        }

        public static T maxUsingGeneric<T>(params T[] Numbers) where T : IComparable
        {
            if (Numbers == null)
                throw new ArgumentNullException();

            int n = Numbers.Length;
            if (n < 1)
                throw new ArgumentNullException();

            if (n == 1)
                return Numbers[0];

            T max = Numbers[0];
            for (int i = 1; i < n; i++)
                if (max.CompareTo(Numbers[i]) == -1)
                    max = Numbers[i];

            return max;
        }


    }
}
