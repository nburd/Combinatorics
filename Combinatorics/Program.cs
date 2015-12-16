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
            string str = "1234";

            Placement pl = new Placement();
            var listPl = pl.CreatePlacement(str, 3);

            Combinations cmb = new Combinations();
            var listCmb = cmb.CreateCombinations(str);

            Permutation prm = new Permutation();
            var listPrm = prm.CreatePermutation(str);

            Console.WriteLine("Количество размещений:" + listPl.Count);
            Console.WriteLine();

            Console.WriteLine("Количество сочетаний:" + listCmb.Count);
            Console.WriteLine();

            Console.WriteLine("Количество перестановок:" + listPrm.Count);
            Console.WriteLine();
          
            Console.ReadKey();
        }
    }
}
