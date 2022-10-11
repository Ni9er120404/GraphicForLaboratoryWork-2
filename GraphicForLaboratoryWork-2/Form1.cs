using System;
using System.Windows.Forms;

namespace GraphicForLaboratoryWork_2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			const int N = 3500;
			for (int x = 1; x < N; x++)
			{
				int y = (int)Math.Pow(x, 2);
				chart1.Series[0].Points.AddXY(x, y);
				int y1 = (int)Math.Pow(3*x, 2);
				chart1.Series[1].Points.AddXY(x, y1);

			}
		}

		private void Chart1_Click(object sender, EventArgs e)
		{


		}
	}
}