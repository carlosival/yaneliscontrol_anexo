using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace ControlAnexo.modeloanexo4
{
    public partial class fotocopiadoraReport : DevExpress.XtraReports.UI.XtraReport
    {
       
        public fotocopiadoraReport()
        {
            InitializeComponent();
        }

        public fotocopiadoraReport(string p, string p_2, string p_3, string p_4)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            xrtmodelofot.Text = p;
            xrtnoseriefot.Text = p_2;
            xrtnoinvfot.Text = p_3;
            xrtmarcafot.Text = p_4;

   
          
        }

    }
}
