using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace ControlAnexo.modeloanexo4
{
    public partial class upsReport : DevExpress.XtraReports.UI.XtraReport
    {
        

        public upsReport()
        {
            InitializeComponent();
        }

        public upsReport(string p, string p_2, string p_3, string p_4)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            xrtmodeloups.Text = p;
            xrtnoserieups.Text = p_2;
            xrtinvups.Text = p_3;
            xrtmarcaups.Text = p_4;

        }

    }
}
