
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ProjektPlecakowy;




namespace AppProjektPlecakowy2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            try
            {
                int seed = int.Parse(txtSeed.Text);
                int numItems = int.Parse(txtNumItems.Text);
                int capacity = int.Parse(txtCapacity.Text);

                // Tworzymy obiekt Problem z wygenerowanymi przedmiotami
                Problem problem = new Problem(numItems, seed);

                // Rozwiązujemy problem plecakowy dla danej pojemności
                Result result = problem.Solve(capacity);

                // Czyszczenie list przed dodaniem nowych wartości
                lstResults.Items.Clear();
                lstInstance.Items.Clear();

                // Wyświetlanie wszystkich przedmiotów w instancji
                foreach (var item in problem.Przedmioty)
                {
                    lstInstance.Items.Add($"Przedmiot: Waga {item.Waga} kg, Wartość {item.Wartosc} zł");
                }

                // Wyświetlanie wybranych przedmiotów w rozwiązaniu
                foreach (var item in result.SelectedItems)
                {
                    lstResults.Items.Add($"Przedmiot: {item} ");
                }
                lstResults.Items.Add($"wartosc:{result.TotalValue}");
                lstResults.Items.Add($"Waga{result.TotalWeight}");

                if (result.SelectedItems.Count == 0)
                {
                    lstResults.Items.Add("Brak możliwego rozwiązania.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex.Message);
            }
        }
    }
}