using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace ControlAnexo.modeloanexo4
{
    public partial class faxReport : DevExpress.XtraReports.UI.XtraReport
    {
       
        public faxReport()
        {
            InitializeComponent();
        }

        public faxReport(string marca, string modelo, string noinv, string noserie)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            xrtmarcafax.Text = marca;
            xrtmodelofax.Text = modelo;
            xrtnoinvfax.Text = noinv;
            xrtnoseriefax.Text = noserie;
        }

    }
}
