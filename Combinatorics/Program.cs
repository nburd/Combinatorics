using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combinatorics
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "1234567";
            Combinations com = new Combinations();
            var list = com.CreateCombinations(str);
            foreach (var cur in list)
                Console.WriteLine(cur);
            Console.ReadKey();
        }
    }
}
