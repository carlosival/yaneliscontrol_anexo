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
    public partial class VReporte : DevExpress.XtraEditors.XtraForm
    {
        public VReporte(string id)
        {
            InitializeComponent();
            anexoReport report = new anexoReport(id);
            CrearDirectorioFacturas();
            report.ExportToPdf("../Sistema para el Control de los Medios Informáticos/Expedientes/Expediente "+id+".pdf");
            documentViewer1.PrintingSystem = report.PrintingSystem;
            
        }

        private static void CrearDirectorioFacturas()
        {
            DirectoryInfo dr = new DirectoryInfo("../Sistema para el Control de los Medios Informáticos/Expedientes");
            if (!dr.Exists)
            {
                dr.Create();
            }
        }

    }
}