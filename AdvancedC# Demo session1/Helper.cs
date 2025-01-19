using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedC__Demo_session1
{
    internal static class Helper
    {


        public static void Swap(ref int x, ref int y)
        {
            Console.WriteLine("========Swap========");

            int temp = x;
            x = y;
            y = temp;
        }


    }
}
