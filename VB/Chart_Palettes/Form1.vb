Imports Microsoft.VisualBasic
#Region "#usings"
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
' ...
#End Region ' #usings

Namespace Chart_Palettes
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

#Region "#code"
Private Sub Form1_Load(ByVal sender As Object, _ 
ByVal e As EventArgs) Handles MyBase.Load
	' Create an empty chart.
	Dim barChart As New ChartControl()

	' Create a series and add points to it.
	Dim series1 As New Series("Bar Series", ViewType.Bar)
	series1.Points.Add(New SeriesPoint("A", New Double() { 10 }))
	series1.Points.Add(New SeriesPoint("B", New Double() { 12 }))
	series1.Points.Add(New SeriesPoint("C", New Double() { 14 }))
	series1.Points.Add(New SeriesPoint("D", New Double() { 17 }))

	' Create an indicator (e.g. Regression Line),
	' and add it to the series' collection.
	Dim myLine As New RegressionLine(ValueLevel.Value)
	CType(series1.View, SideBySideBarSeriesView).Indicators.Add(myLine)

	' Add the series to the chart.
	barChart.Series.Add(series1)

	' Define the chart's appearance and palette.
	barChart.AppearanceName = "Dark"
	barChart.PaletteName = "Opulent"
	barChart.PaletteBaseColorNumber = 5

	' Define a separate palette for the chart's indicators.
	barChart.IndicatorsPaletteName = "Default"

	' Add the chart to the form.
	barChart.Dock = DockStyle.Fill
	Me.Controls.Add(barChart)
End Sub
#End Region ' #code

	End Class
End Namespace
