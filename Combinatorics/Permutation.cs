using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combinatorics
{
    public class Permutation
    {
        private static List<string> listPermutation = new List<string>();

        public List<string> CreatePermutation(string str)
        {
            for (int i = 0; i < str.Length; i++)
                AddPermutation(str, str[i].ToString());
            return listPermutation;
        }

        private static void AddPermutation(string str, string current)
        {
            string permutation;
            int counter = 0;
            while (counter < str.Length)
            {
                permutation = current;
                var res = permutation.Any(x => x == str[counter]);
                if (res == false)
                    permutation += str[counter++];
                else
                {
                    ++counter;
                    continue;
                }
                if (permutation.Length == str.Length)
                    listPermutation.Add(permutation);
                if (permutation.Length < str.Length)
                    AddPermutation(str, permutation);
            }
        }
    }
}
