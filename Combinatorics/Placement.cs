using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combinatorics
{
    public class Placement
    {
        private static List<string> listPlacement = new List<string>();

        public List<string> CreatePlacement(string str, int count)
        {
            for (int i = 0; i < str.Length; i++)
                AddPlacement(str, str[i].ToString(), count);
            return listPlacement;
        }

        private static void AddPlacement(string str, string current, int count)
        {
            string placement;
            int counter = 0;
            while (counter < str.Length)
            {
                placement = current;
                var res = placement.Any(x => x == str[counter]);
                if (res == false)
                    placement += str[counter++];
                else
                {
                    ++counter;
                    continue;
                }
                if (placement.Length == count)                
                    listPlacement.Add(placement);
                if (placement.Length < count)
                    AddPlacement(str, placement, count);
            }
        }
    }
}
