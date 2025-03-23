using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
   
namespace ProjektPlecakowy
{
    internal class ProgramPL
    {
        static void Main(string[] args)
        {
            Console.Write("Wprowadz seed: ");
            int seed = int.Parse(Console.ReadLine());

            Console.Write("Wprowadz liczbe przedmiotow: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Wprowadz pojemnosc plecaka: ");
            int capacity = int.Parse(Console.ReadLine());

            Problem problem = new Problem(n, seed);
            Console.WriteLine(problem);

            Result result = problem.Solve(capacity);
            Console.WriteLine(result);



        }
    }
}
