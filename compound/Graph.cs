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

        public void InsertData(List<double> list, List<double> notmultipled, string term, string textboxString)
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

            Series series2 = new Series();
            series2.ChartType = SeriesChartType.Spline;
            series2.IsXValueIndexed = true;
            series2.BorderWidth = 2;
            series2.Font = new Font(FontFamily.GenericSansSerif, (float)9.5, System.Drawing.FontStyle.Bold);

            for (int i = 0; i < list.Count; i++)
            {
                DataPoint data = new DataPoint(i + 1, list[i]);
                series1.Points.Add(data);
            }

            for (int i = 0; i < notmultipled.Count; i++)
            {
                DataPoint data = new DataPoint(i + 1, notmultipled[i]);
                series2.Points.Add(data);
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

            foreach (var pt in series2.Points)
            {
                if (pt.XValue == notmultipled.Count)
                {
                    pt.MarkerColor = Color.Red;
                    pt.MarkerSize = 5;
                    pt.MarkerStyle = MarkerStyle.Circle;
                    pt.Label = "#VAL{C}";
                }
            }

            chartEarnings.Series.Add(series1);
            chartEarnings.Series.Add(series2);
        }

        private void chartEarnings_Click(object sender, EventArgs e)
        {

        }
    }
}
