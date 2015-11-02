using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace ControlAnexo.modeloanexo4
{
    public partial class escanerReport : DevExpress.XtraReports.UI.XtraReport
    {
        
        public escanerReport()
        {
            InitializeComponent();
        }

        public escanerReport(string p, string p_2, string p_3, string p_4)
        {
            InitializeComponent();
            xrtmarcaesc.Text = p;
            xrtmodeloesc.Text = p_2;
            xrtnoinvesc.Text = p_4;
            xrtnoserieesc.Text = p_3;
           
        }

    }
}
