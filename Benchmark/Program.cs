using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Combinatorics;

namespace Benchmark
{
    public class Times
    {
        public string Name { get; set; }
        public TimeSpan Time { get; set; }

        public Times(string name, TimeSpan time)
        {
            Name = name;
            Time = time;
        }
        
    }

    public class Program
    {
       
        static void Main(string[] args)
        {
            DateTime start, stop;
            Times time;
            List<Times> timeList = new List<Times>();
            string str = "1234567890";

            start = DateTime.Now;
            Combinations combinations = new Combinations();
            combinations.CreateCombinations(str);
            stop = DateTime.Now;
            time = new Times("Сочетания", (stop - start));
            timeList.Add(time);

            start = DateTime.Now;
            Permutation permutation = new Permutation();
            permutation.CreatePermutation(str);
            stop = DateTime.Now;
            time = new Times("Перестановки", (stop - start));
            timeList.Add(time);

            start = DateTime.Now;
            Placement placement = new Placement();
            placement.CreatePlacement(str, 6);
            stop = DateTime.Now;
            time = new Times("Размещения", (stop - start));
            timeList.Add(time);

            timeList.Sort(delegate (Times t1, Times t2)
            {
                return t1.Time.CompareTo(t2.Time);
            });

            foreach (var cur in timeList)
                Console.WriteLine("Время {0} = {1}", cur.Name, cur.Time);

            Console.ReadKey();
        }
    }
}
