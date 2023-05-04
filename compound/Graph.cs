using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace compound
{
    public partial class Graph : Form
    {
        public Graph()
        {
            InitializeComponent();
        }

        private void Graph_Load(object sender, EventArgs e)
        {

        }

        public void InsertData(List<double> list, double amount)
        {
            chartEarnings.Titles.Add($"Доход за {list.Count} лет");
            chartEarnings.Series.Clear();

            for (int i = 0; i < list.Count; i++)
            {
                Series series = chartEarnings.Series.Add($"{i + 1} год");
                series.Points.Add(list[i] - amount);
            }
        }
    }
}
