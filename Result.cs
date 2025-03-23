using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemPlecakowy
{
    internal class Result
    {
        public List<int> SelectedItems { get; set; }
        public int TotalValue { get; set; }
        public int TotalWeight { get; set; }

        public Result(List<int> selectedItems, int totalValue, int totalWeight)
        {
            SelectedItems = selectedItems;
            TotalValue = totalValue;
            TotalWeight = totalWeight;
        }
        public override string ToString()
        {
            return $"Wybrane przedmioty:{string.Join(",", SelectedItems)}\n łączna wartosc:{TotalValue}\n łączna waga:{TotalWeight}";

        }




    }
}

