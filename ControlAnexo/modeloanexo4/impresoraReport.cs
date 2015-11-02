using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace ControlAnexo.modeloanexo4
{
    public partial class impresoraReport : DevExpress.XtraReports.UI.XtraReport
    {
        
        public impresoraReport()
        {
            InitializeComponent();
        }

        public impresoraReport(string p, string p_2, string p_3, string p_4)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            xrtmodeloimpresora.Text = p;
            xrtnoserieimpresora.Text = p_2;
            xrtnoinveimpresora.Text = p_3;
            xrtmarcaimpresora.Text = p_4;
        }

    }
}
