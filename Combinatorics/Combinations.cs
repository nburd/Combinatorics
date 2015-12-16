using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combinatorics
{
    public class Combinations
    {
        private static List<string> listCombinations = new List<string>();

        public List<string> CreateCombinations(string str)
        {
            for (int i = 0; i < str.Length; i++)
                AddCombination(str, str[i].ToString(), i + 1);
            return SortList(listCombinations, str.Length);
        }

        private static void AddCombination(string str, string current, int counter)
        {
            string combination;
            while (counter < str.Length)
            {
                combination = current;
                combination += str[counter++];
                listCombinations.Add(combination);
                if (combination.Length < str.Length + 1)
                    AddCombination(str, combination, counter);
            }
        }

        private List<string> SortList(List<string> curList, int length)
        {
            List<string> resultList = new List<string>();
            for (int i = 2; i < length + 1; i++)
            {
                var res = curList.FindAll(x => x.Length == i);
                foreach (var cur in res)
                    resultList.Add(cur);
            }
            return resultList;
        }
    }
}
