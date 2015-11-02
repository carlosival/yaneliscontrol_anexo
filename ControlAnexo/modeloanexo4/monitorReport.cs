using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace ControlAnexo.modeloanexo4
{
    public partial class monitorReport : DevExpress.XtraReports.UI.XtraReport
    {
        
        public monitorReport()
        {
            InitializeComponent();
        }

        public monitorReport(string p, string p_2, string p_3, string p_4)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            xrtmarcamonitor.Text = p;
            xrtmarcamonitor.Text = p_2;
            xrtnoinvemonitor.Text = p_3;
            xrtmarcamonitor.Text = p_4;
        }

    }
}
