using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace ControlAnexo.modeloanexo4
{
    public partial class configReport : DevExpress.XtraReports.UI.XtraReport
    {

        public configReport(string placabase, string procesador, string noserieplaca, string cantidad, string memoria, string tarjetared, string tarjetasonido, string tarjetagrafica, string velocidad)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            xrtplacabase.Text = placabase;
            xrtprocesador.Text = procesador;
            xrtnoserie.Text =noserieplaca;
            xrtcantidad.Text = cantidad;
            xrtmemoria.Text = memoria;
            xrttarjetared.Text = tarjetared;
            xrttarjetasonido.Text = tarjetasonido;
            xrttarjetagrafica.Text = tarjetagrafica;
            xrtvelocidad.Text = velocidad;
        }

    }
}
