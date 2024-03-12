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
    internal class Result
    {
        public List<Item> Pack { get; set; }
        public int TotalValue { get; set; }
        public int TotalWeight { get; set; }

        public Result(List<Item> pack, int total_value, int total_weight)
        {
            Pack = pack;
            TotalValue = total_value;
            TotalWeight = total_weight;
        }

        public override string ToString()
        {
            string packStr = "Packed items: ";
            foreach (var item in Pack)
            {
                packStr += "Item " + item.Index + ", ";
            }
            return packStr + "\nTotal weight: " + TotalWeight + "\nTotal value: " + TotalValue;
        }
    }
}
