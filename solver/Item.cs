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
    internal class Item
    {
        private int value;
        private int weight;
        static private int index;
        private int el;

        public Item(int value, int weight)
        {
            this.value = value;
            this.weight = weight;
            this.el = index++;
        }

        public int Value => value;
        public int Weight => weight;
        public int Index => el;
        public override string ToString()
        {
            return $"{Index}. value: {Value} weight: {Weight}";
        }
    }
}
