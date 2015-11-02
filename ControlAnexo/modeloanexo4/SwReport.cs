using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace ControlAnexo.modeloanexo4
{
    public partial class SwReport : DevExpress.XtraReports.UI.XtraReport
    {
       
        public SwReport()
        {
            InitializeComponent();
        }

        public SwReport(string p, string p_2, string p_3, string p_4)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            xrtmodeloswitch.Text = p;
            xrtnoserienoserie.Text = p_2;
            xrtinvswitch.Text = p_3;
            xrtmarcaswitch.Text = p_4; 
        }

    }
}
