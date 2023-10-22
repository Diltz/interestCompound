using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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

        public void InsertData(List<double> list, string term, string textboxString)
        {
            resultBox.Text = textboxString;

            Title title = new Title();
            title.Text = $"Доход за {term}";
            title.Font = new Font(FontFamily.GenericSansSerif, (float)12.8, System.Drawing.FontStyle.Bold);

            chartEarnings.Titles.Add(title);
            chartEarnings.Series.Clear();

            Series series1 = new Series();
            series1.ChartType = SeriesChartType.Spline;
            series1.IsXValueIndexed = true;
            series1.BorderWidth = 3;
            series1.Font = new Font(FontFamily.GenericSansSerif, (float)9.5, System.Drawing.FontStyle.Bold);

            for (int i = 0; i < list.Count; i++)
            {
                DataPoint data = new DataPoint(i + 1, list[i]);
                series1.Points.Add(data);
            }

            foreach (var pt in series1.Points)
            {
                if (pt.XValue == list.Count)
                {
                    pt.MarkerColor = Color.Red;
                    pt.MarkerSize = 5;
                    pt.MarkerStyle = MarkerStyle.Circle;
                    pt.Label = "#VAL{C}";
                }
            }

            chartEarnings.Series.Add(series1);
        }

        private void chartEarnings_Click(object sender, EventArgs e)
        {

        }
    }
}
