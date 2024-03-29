Imports DevExpress.Utils
Imports DevExpress.XtraCharts
Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Threading
Imports System.Windows.Forms

Namespace RealTimeChartUpdates

    Public Partial Class Form1
        Inherits Form

        Const ViewportPointCount As Integer = 5000

        Private counter As Integer = 0

        Private dataAcquisitionThread As Thread

        Private isEnabled As Boolean = True

        Private lastRawDataIndex As Integer = 0

        Private rawData As List(Of DataPoint) = New List(Of DataPoint)()

        Private viewportData As ObservableCollection(Of DataPoint) = New ObservableCollection(Of DataPoint)()

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            dataAcquisitionThread = New Thread(New ThreadStart(AddressOf AcquireData))
            dataAcquisitionThread.Start()
            chartControl1.Titles.Add(New ChartTitle With {.Text = "Real-Time Charting"})
            Dim series As Series = New Series()
            series.ChangeView(ViewType.Line)
            series.DataSource = viewportData
            series.DataSourceSorted = True
            series.ArgumentDataMember = "Argument"
            series.ValueDataMembers.AddRange("Value")
            chartControl1.Series.Add(series)
            Dim seriesView As LineSeriesView = CType(series.View, LineSeriesView)
            seriesView.LastPoint.LabelDisplayMode = SidePointDisplayMode.SeriesPoint
            seriesView.LastPoint.Label.TextPattern = "{V:f2}"
            Dim diagram As XYDiagram = CType(chartControl1.Diagram, XYDiagram)
            diagram.AxisX.DateTimeScaleOptions.ScaleMode = ScaleMode.Continuous
            diagram.AxisX.Label.ResolveOverlappingOptions.AllowRotate = False
            diagram.AxisX.Label.ResolveOverlappingOptions.AllowStagger = False
            diagram.AxisX.VisualRange.EndSideMargin = 200
            diagram.DependentAxesYRange = DefaultBoolean.True
            diagram.AxisY.WholeRange.AlwaysShowZeroLevel = False
            Dim timer As System.Windows.Forms.Timer = New System.Windows.Forms.Timer()
            timer.Interval = 100
            timer.Start()
            AddHandler timer.Tick, AddressOf Timer_Tick
        End Sub

        Private Sub AcquireData()
            While isEnabled
                Thread.Sleep(15)
                SyncLock rawData
                    For i As Integer = 0 To 50 - 1
                        rawData.Add(New DataPoint(Date.Now, GenerateValue(Math.Min(Interlocked.Increment(counter), counter - 1))))
                    Next

                End SyncLock
            End While
        End Sub

        Private Function GenerateValue(ByVal x As Double) As Double
            Return Math.Sin(x / 1000.0) * 3 * x + x / 2 + 5
        End Function

        Private Sub Timer_Tick(ByVal sender As Object, ByVal e As EventArgs)
            SyncLock rawData
                For i As Integer = Math.Max(lastRawDataIndex, rawData.Count - ViewportPointCount) To rawData.Count - 1
                    viewportData.Add(rawData(i))
                Next

                lastRawDataIndex = rawData.Count
                While viewportData.Count > ViewportPointCount
                    viewportData.RemoveAt(0)
                End While

            End SyncLock
        End Sub

        Protected Overrides Sub OnClosing(ByVal e As CancelEventArgs)
            isEnabled = False
            MyBase.OnClosing(e)
        End Sub

        Public Class DataPoint

            Public Sub New(ByVal argument As Date, ByVal value As Double)
                Me.Argument = argument
                Me.Value = value
            End Sub

            Public Property Argument As Date

            Public Property Value As Double
        End Class
    End Class
End Namespace
