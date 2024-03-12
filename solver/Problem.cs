using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
[assembly:
InternalsVisibleTo("ProblemTest"), InternalsVisibleTo("WinFormsApp2")]
namespace solver
{
    internal class Problem
    {
        private int n;
        private int seed;
        private List<Item> items = new List<Item>();


        public Problem(List<Item> items)
        {
            this.items = items;
        }

        public Problem(int num, int seed)
        {
            this.n = num;
            this.seed = seed;
            Random random = new Random(seed);
            for (int i = 0; i < n; i++)
            {
                int value = random.Next(1, 11);
                int weight = random.Next(1, 11);
                items.Add(new Item(value, weight));
                Console.WriteLine(items[i]);
            }
        }
        public List<Item> GetItems()
        {
            return items;
        }
        public Result Solve(int capacity)
        {
            int total_value = 0;
            int total_weight = 0;
            List<Item> sort = new List<Item>();
            List<Item> pack = new List<Item>();
            sort = items.OrderByDescending(item => (double)item.Value / item.Weight).ToList();
            foreach (var item in sort)
            {
                if (total_weight + item.Weight <= capacity)
                {
                    pack.Add(item);
                    total_weight += item.Weight;
                    total_value += item.Value;
                }
                else
                {
                }
            }


            return new Result(pack, total_value, total_weight);
        }
    }
}
