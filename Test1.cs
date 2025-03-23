using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProblemPlecakowy;
using System.Collections.Generic;

namespace TestProblemPlecakowy
{
    [TestClass]
    public class ProblemTests
    {
        [TestMethod]
        public void Solve_ShouldReturnAtLeastOneItem_WhenAtLeastOneFits()
        {
            Problem problem = new Problem(5, 42);
            Result result = problem.Solve(10);
            Assert.IsTrue(result.SelectedItems.Count > 0, "Powinien zostać wybrany przynajmniej jeden przedmiot.");
        }

        [TestMethod]
        public void Solve_ShouldReturnEmpty_WhenNoItemFits()
        {
            Problem problem = new Problem(5, 42);
            Result result = problem.Solve(0);
            Assert.AreEqual(0, result.SelectedItems.Count, "Lista wynikowa powinna być pusta.");
        }

        [TestMethod]
        public void Solve_ShouldReturnCorrectResult_ForSpecificInstance()
        {
            Problem problem = new Problem(1, 42);
            Result result = problem.Solve(10);
            Assert.IsTrue(result.TotalValue > 0, "Całkowita wartość powinna być większa niż 0 dla odpowiedniego przypadku.");
        }

        [TestMethod]
        public void Solve_ShouldNotModifyOriginalItemList()
        {
            Problem problem = new Problem(5, 42);
            List<Przedmiot> originalList = new List<Przedmiot>(problem.Przedmioty);
            problem.Solve(10);
            CollectionAssert.AreEqual(originalList, problem.Przedmioty, "Lista przedmiotów nie powinna się zmieniać po wywołaniu Solve().");
        }

        [TestMethod]
        public void Solve_ShouldHandleEmptyItemList()
        {
            Problem problem = new Problem(0, 42);
            Result result = problem.Solve(10);
            Assert.AreEqual(0, result.SelectedItems.Count, "Lista wynikowa powinna być pusta dla pustej listy przedmiotów.");
        }

        [TestMethod]
        public void Test_Items_Are_Generated_Correstly()
        {
            Problem problem = new Problem(10, 42);
            foreach (var item in problem.Przedmioty)
            {
                Assert.IsTrue(item.Waga > 0, "Waga przedmiotu powinna być większa od 0.");
                Assert.IsTrue(item.Wartosc > 0, "Wartość przedmiotu powinna być większa od 0." );
            }
        }
    }
}

