Imports DevExpress.XtraEditors
Imports System
Imports System.Windows.Forms

Namespace RealTimeChartUpdates

    Friend Module Program

        <STAThread>
        Sub Main()
            Call WindowsFormsSettings.ForceDirectXPaint()
            Call WindowsFormsSettings.SetDPIAware()
            WindowsFormsSettings.AllowDpiScale = True
            WindowsFormsSettings.AllowAutoScale = DevExpress.Utils.DefaultBoolean.True
            Call Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Call Application.Run(New Form1())
        End Sub
    End Module
End Namespace
