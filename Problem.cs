using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("TestProblemPlecakowy")]

namespace ProblemPlecakowy




    {
        internal class Problem
        {
            public int LiczbaN { get; set; }
            public List<Przedmiot> Przedmioty { get; set; }

            public Problem(int n, int seed)
            {
                LiczbaN = n;
                Przedmioty = new List<Przedmiot>();
                Random random = new Random(seed);
                for (int i = 0; i < n; i++)
                {
                    int waga = random.Next(1, 11);
                    int wartosc = random.Next(1, 11);
                    Przedmioty.Add(new Przedmiot(i + 1, waga, wartosc));
                }
            }
            public Result Solve(int capacity)
            {
                var sortedItems = Przedmioty.OrderByDescending(p => (double)p.Wartosc / p.Waga).ToList();
                List<int> selectedIndices = new List<int>();
                int totalWeight = 0, totalValue = 0;

                foreach (var item in sortedItems)
                {
                    if (totalWeight + item.Waga <= capacity)
                    {
                        selectedIndices.Add(item.Indeks);
                        totalWeight += item.Waga;
                        totalValue += item.Wartosc;
                    }
                }
                return new Result(selectedIndices, totalValue, totalWeight);
            }
            public override string ToString()
            {
                string result = "Lista przedmiotow:\n";
                for (int i = 0; i < Przedmioty.Count; i++)
                {
                    result += $"Przedmiot{i + 1}: Waga= {Przedmioty[i].Waga}, Wartosc={Przedmioty[i].Wartosc}\n";
                }
                return result;
            }

        }
    }

