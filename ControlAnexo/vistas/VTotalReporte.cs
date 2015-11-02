using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ControlAnexo.modeloanexo4;
using System.IO;

namespace ControlAnexo.vistas
{
    public partial class VTotalReporte : DevExpress.XtraEditors.XtraForm
    {
        public VTotalReporte()
        {
            InitializeComponent();
            Total report = new Total();
            CrearDirectorioFacturas();
            report.ExportToPdf("../Sistema para el Control de los Medios Informáticos/Control Total de Medios/Control Total de Medios Informaticos.pdf");
            documentViewer1.PrintingSystem = report.PrintingSystem;
        }


        private static void CrearDirectorioFacturas()
        {
            DirectoryInfo dr = new DirectoryInfo("../Sistema para el Control de los Medios Informáticos/Control Total de Medios");
            if (!dr.Exists)
            {
                dr.Create();
            }
        }
    }
}