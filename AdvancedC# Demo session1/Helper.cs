using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedC__Demo_session1
{

    internal static class Helper<T> where T : IComparable

    {

        

        public static void BubbleSort(int[] Arr)
        {
            if (Arr is null || Arr.Length == 0)
                return;

            for (int i = 0; i < Arr.Length; i++)
            {
                for (int j = 0; j < Arr.Length - 1 - i; j++)
                {
                    if ((Arr[j] .CompareTo Arr[j + 1])==1)
                        Helper<int>.Swap(ref Arr[j], ref Arr[j + 1]);
                }
            }
        }
        public static int LinearSearch(T[] Arr, T Value)
        {
            if (Arr?.Length > 0 && Value is not null)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    if (Value.Equals(Arr[i]))
                        return i;
                }
            }
            return -1;
        }

        public static void Swap(ref int x, ref int y)
        {
            Console.WriteLine("========Swap========");

            int temp = x;
            x = y;
            y = temp;
        }

        public static void Swap(ref object x, ref object y)
        {
            Console.WriteLine("========Swap========");

            object temp = x;
            x = y;
            y = temp;
        }

        public static void Swap(ref Point x, ref Point y)
        {
            Console.WriteLine("========Swap========");

            Point temp = x;
            x = y;
            y = temp;
        }

        public static void Swap<T>(ref T x, ref T y)
        {
            Console.WriteLine("========Swap========");

            T temp = x;
            x = y;
            y = temp;
        }
    }

}
