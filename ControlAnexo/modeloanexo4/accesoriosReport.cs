using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace ControlAnexo.modeloanexo4
{
    public partial class accesoriosReport : DevExpress.XtraReports.UI.XtraReport
    {
      
     
        public accesoriosReport()
        {
            InitializeComponent();
            //Obtencion de los accesorios si existe.
        }

        public accesoriosReport(string mouse, string bocinas, string teclado)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            xrtraton.Text = mouse;
            xrtteclado.Text = teclado;
            xrtbocinas.Text = bocinas;
        }

      

    }
}
