using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar
{
    internal class Program
    {
        static string Bar (string a, string b, string x, string y, string z)
        {
            int a1 = int.Parse (a);
            int b1 = int.Parse (b);
            int x1 = int.Parse (x);
            int y1 = int.Parse (y);
            int z1 = int.Parse (z);
            if ((x1 <= a1 &&  y1 <= b1) || (x1 <= b1 && y1 <= a1)  ||   (z1 <= a1 && y1 <= b1) || (z1 <= b1 && y1 <= a1)   ||   (x1 <= a1 && z1 <= b1) || (x1 <= b1 && z1 <= a1))
            {
                return "Yes";
            }
            else
            {
                return "No";
            }
        }
        static void Main(string[] args)
        {
            string result = Bar("100", "80", "100", "100", "80");
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
