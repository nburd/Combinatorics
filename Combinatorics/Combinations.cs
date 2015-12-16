using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combinatorics
{
    public class Combinations
    {
        private static List<string> listCombination = new List<string>();

        public List<string> CreateCombinations(string str)
        {
            for (int i = 0; i < str.Length; i++)
                AddCombination(str, str[i].ToString(), i + 1);
            return SortList(listCombination, str.Length);
        }

        private static void AddCombination(string str, string current, int lenghtCombination)
        {
            string combination;
            while (lenghtCombination < str.Length)
            {
                combination = current;
                combination += str[lenghtCombination++];
                listCombination.Add(combination);
                if (combination.Length < str.Length + 1)
                    AddCombination(str, combination, lenghtCombination);
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
