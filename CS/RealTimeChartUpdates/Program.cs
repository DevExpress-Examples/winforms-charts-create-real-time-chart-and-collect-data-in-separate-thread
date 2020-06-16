using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace RealTimeChartUpdates {
    static class Program {

        [STAThread]
        static void Main() {
            WindowsFormsSettings.ForceDirectXPaint();
            WindowsFormsSettings.SetDPIAware();
            WindowsFormsSettings.AllowDpiScale = true;
            WindowsFormsSettings.AllowAutoScale = DevExpress.Utils.DefaultBoolean.True;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }
    }
}
