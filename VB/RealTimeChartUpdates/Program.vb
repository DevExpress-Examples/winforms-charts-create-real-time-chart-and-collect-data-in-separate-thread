Imports DevExpress.XtraEditors
Imports System
Imports System.Windows.Forms

Namespace RealTimeChartUpdates
	Friend Module Program

		<STAThread>
		Sub Main()
			WindowsFormsSettings.ForceDirectXPaint()
			WindowsFormsSettings.SetDPIAware()
			WindowsFormsSettings.AllowDpiScale = True
			WindowsFormsSettings.AllowAutoScale = DevExpress.Utils.DefaultBoolean.True
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			Application.Run(New Form1())

		End Sub
	End Module
End Namespace
