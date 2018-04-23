#region #usings
using System;
using System.Windows.Forms;
using DevExpress.XtraCharts;
// ...
#endregion #usings

namespace Chart_Palettes {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

#region #code
private void Form1_Load(object sender, EventArgs e) {
    // Create an empty chart.
    ChartControl barChart = new ChartControl();

    // Create a series and add points to it.
    Series series1 = new Series("Bar Series", ViewType.Bar);
    series1.Points.Add(new SeriesPoint("A", new double[] { 10 }));
    series1.Points.Add(new SeriesPoint("B", new double[] { 12 }));
    series1.Points.Add(new SeriesPoint("C", new double[] { 14 }));
    series1.Points.Add(new SeriesPoint("D", new double[] { 17 }));

    // Create an indicator (e.g. Regression Line),
    // and add it to the series' collection.
    RegressionLine myLine = new RegressionLine(ValueLevel.Value);
    ((SideBySideBarSeriesView)series1.View).Indicators.Add(myLine);

    // Add the series to the chart.
    barChart.Series.Add(series1);

    // Define the chart's appearance and palette.
    barChart.AppearanceName = "Dark";
    barChart.PaletteName = "Opulent";
    barChart.PaletteBaseColorNumber = 5;

    // Define a separate palette for the chart's indicators.
    barChart.IndicatorsPaletteName = "Default";

    // Add the chart to the form.
    barChart.Dock = DockStyle.Fill;
    this.Controls.Add(barChart);
}
#endregion #code

    }
}
