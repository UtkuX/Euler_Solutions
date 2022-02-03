using System.Threading.Channels;
using System;

namespace Question2
{
    class Program
    { 
        static void Main(string[] args)
        { 
            long first = 1;
            long second = 1;
            long no3 = 0;
            long ciftler = 0;
            bool rules = true;
            while (rules)
            {
                no3 = first + second;
                first = second;
                second = no3;
                if (second % 2 == 0)
                {
                    ciftler += second;
                }

                if (no3 >= 4000000)
                {
                    rules = false;
                }
            }
            Console.WriteLine(ciftler);
        }
    }
}


