using System;
using System.Windows.Forms;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Math;
static class Program
{
	static void Main()
	{
		double MinX = -50, MaxX = 1000, step = 0.5, a = -1, b = -10;

		Form MainForm = new Form { Size = new Size(800, 400) };
		Chart chart = new Chart() { Dock = DockStyle.Fill }; chart.ChartAreas.Add(new ChartArea());
		Series series = new Series() { ChartType = SeriesChartType.Line }; chart.Series.Add(series);

		for (double i = MinX; i <= MaxX; i += step) series.Points.AddXY(i, Func(i, a, b));

		MainForm.Controls.Add(chart);
		Application.Run(MainForm);
	}

	static double Func(double x, double a, double b) => a * Cos(Sqrt(x)) / Pow((x - Pow(b, 3)), 2);
}