using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
[assembly:
InternalsVisibleTo("ProblemTest"), InternalsVisibleTo("WinFormsApp2")]
namespace solver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of items: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the seed: ");
            int seed = int.Parse(Console.ReadLine());

            Problem problem = new Problem(number, seed);

            Console.WriteLine("Enter the capacity: ");
            int capacity = int.Parse(Console.ReadLine());
            Result result = problem.Solve(capacity);
            Console.WriteLine(result);
        }
    }

    

    

    
}