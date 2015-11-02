using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using ControlAnexo.modelo;

namespace ControlAnexo.modeloanexo4
{
    public partial class anexoReport : DevExpress.XtraReports.UI.XtraReport
    {
        //public anexoReport()
        //{
        //    InitializeComponent();
        //}
        public anexoReport(string id)
        {
            InitializeComponent();

            PointF point = new PointF(0, 115);

            bdanexoDataSet.expedienteDataTable exp = expedienteTableAdapter1.ExpedienteById(Convert.ToInt16(id));
            int idexpediente = ((bdanexoDataSet.expedienteRow)exp.Rows[0]).Id;

            bdanexoDataSet.usuarioDataTable item = usuarioTableAdapter1.UsuarioById(((bdanexoDataSet.expedienteRow)exp.Rows[0]).idusuario);

            xrtempresa.Text = "ALIMATIC";
            xrtusuario.Text = ((bdanexoDataSet.usuarioRow)item.Rows[0]).usuario;
            xrtarea.Text = ((bdanexoDataSet.usuarioRow)item.Rows[0]).area;
            xrtfecha.Text = DateTime.Today.ToShortDateString();

            //Obtencion del Equipo si existe.
            bdanexoDataSet.equipoDataTable equipo = equipoTableAdapter1.GetEquipoByUsuario(idexpediente);
            if (equipo.Count > 0)
            {
                xrtinventario.Text = ((bdanexoDataSet.equipoRow)equipo.Rows[0]).noinventario;
                xrtobservaciones.Text = ((bdanexoDataSet.equipoRow)equipo.Rows[0]).observaciones;
                xrtequipo.Text = ((bdanexoDataSet.equipoRow)equipo.Rows[0]).nombre;
                xrtdominiored.Text = ((bdanexoDataSet.equipoRow)equipo.Rows[0]).dominiored;
                xrtserie.Text = ((bdanexoDataSet.equipoRow)equipo.Rows[0]).noserie;
            }

            //Obtencion del Configuracion si existe.
            bdanexoDataSet.configuracionDataTable configuaracion = configuracionTableAdapter1.GetConfiguracionByUsuario(idexpediente);
            if (configuaracion.Count > 0)
            {
                XRSubreport xrsubrepor = new XRSubreport();
                xrsubrepor.ReportSource = new configReport(((bdanexoDataSet.configuracionRow)configuaracion.Rows[0]).placabase,
                ((bdanexoDataSet.configuracionRow)configuaracion.Rows[0]).procesador,
                ((bdanexoDataSet.configuracionRow)configuaracion.Rows[0]).noserieplaca,
                ((bdanexoDataSet.configuracionRow)configuaracion.Rows[0]).cantidad,
                ((bdanexoDataSet.configuracionRow)configuaracion.Rows[0]).memoria,
                ((bdanexoDataSet.configuracionRow)configuaracion.Rows[0]).tarjetared,
                ((bdanexoDataSet.configuracionRow)configuaracion.Rows[0]).tarjetasonido,
                ((bdanexoDataSet.configuracionRow)configuaracion.Rows[0]).tarjetagrafica,
                ((bdanexoDataSet.configuracionRow)configuaracion.Rows[0]).velocidad);

                Detail.Controls.Add(xrsubrepor);
                xrsubrepor.Visible = true;
                xrsubrepor.LocationF = point;
                xrsubrepor.CanGrow = false;
                xrsubrepor.SizeF = new SizeF(624, 172.01F);
                point.Y += 172.01F;
            }
            //Obtencion de los accesorios si existe.
            bdanexoDataSet.accesoriosDataTable accesorios = accesoriosTableAdapter1.GetAccesoriosByUsuario(idexpediente);
            if (accesorios.Count > 0)
            {
                XRSubreport xrsubrepor = new XRSubreport();
                xrsubrepor.ReportSource = new accesoriosReport(((bdanexoDataSet.accesoriosRow)accesorios.Rows[0]).mouse, ((bdanexoDataSet.accesoriosRow)accesorios.Rows[0]).bocinas,
                    ((bdanexoDataSet.accesoriosRow)accesorios.Rows[0]).teclado);
                Detail.Controls.Add(xrsubrepor);
                xrsubrepor.LocationF = point;
                xrsubrepor.CanGrow = false; 
                xrsubrepor.Visible = true;
                xrsubrepor.SizeF = new SizeF(624, 122.3F);
                point.Y += 122.3F;
            }

            //Obtencion de los cd/dvd si existe.
            //Obtencion de los discoduro si existe.
            //Obtencion de los disquete si existe.

            bdanexoDataSet.disqueteDataTable disquete = disqueteTableAdapter1.GetDisqueteByUsuario(idexpediente);
            bdanexoDataSet.discoduroDataTable discoduro = discoduroTableAdapter1.GetDiscoDuroByUsuario(idexpediente);
            bdanexoDataSet.cdroomDataTable cddvd = cdroomTableAdapter1.GetDVDByUsuario(idexpediente);

            if (disquete.Count > 0 || discoduro.Count > 0 || cddvd.Count > 0)
            {
                almacenamientoReport almacReport = new almacenamientoReport();

                if (disquete.Count > 0)
                {
                    almacReport.nombreDisquete = ((bdanexoDataSet.disqueteRow)disquete.Rows[0]).nombre;
                    almacReport.noseriedisquete = ((bdanexoDataSet.disqueteRow)disquete.Rows[0]).noserie;
                }

                if (cddvd.Count > 0)
                {
                    almacReport.nombreCdDvd = ((bdanexoDataSet.cdroomRow)cddvd.Rows[0]).nombre;
                    almacReport.noserieCdDvd = ((bdanexoDataSet.cdroomRow)cddvd.Rows[0]).noserie;
                }

                if (discoduro.Count > 0)
                {
                    List<DiscoDuro> list = new List<DiscoDuro>();
                    foreach (var discoitem in discoduro.Rows)
                    {
                        DiscoDuro dd = new DiscoDuro();
                        dd.descripcion = ((bdanexoDataSet.discoduroRow)discoduro.Rows[0]).descripcion;
                        dd.capacidad = ((bdanexoDataSet.discoduroRow)discoduro.Rows[0]).capacidad;
                        dd.noserie = ((bdanexoDataSet.discoduroRow)discoduro.Rows[0]).noserie;
                        dd.estado = ((bdanexoDataSet.discoduroRow)discoduro.Rows[0]).estado;
                        list.Add(dd);
                    }
                    almacReport.discosduros = list;

                    XRSubreport xrsubrepor = new XRSubreport();
                    xrsubrepor.ReportSource = almacReport;
                    Detail.Controls.Add(xrsubrepor);
                    xrsubrepor.LocationF = point;
                    xrsubrepor.CanGrow = false;
                    xrsubrepor.Visible = true;
                    xrsubrepor.SizeF = new SizeF(624, 188.14F);
                    point.Y += 188.14F;
                }
                //Obtencion de los escanner si existe.
                bdanexoDataSet.escannerDataTable escanner = escannerTableAdapter1.GetScannerByUsuario(idexpediente);
                if (escanner.Count > 0)
                {

                    XRSubreport xrsubrepor = new XRSubreport();
                    xrsubrepor.ReportSource = new escanerReport(((bdanexoDataSet.escannerRow)escanner.Rows[0]).marca, ((bdanexoDataSet.escannerRow)escanner.Rows[0]).modelo,
                       ((bdanexoDataSet.escannerRow)escanner.Rows[0]).noserie, ((bdanexoDataSet.escannerRow)escanner.Rows[0]).noinventario);
                    Detail.Controls.Add(xrsubrepor);
                    xrsubrepor.LocationF = point;
                    xrsubrepor.CanGrow = false;
                    xrsubrepor.Visible = true;
                    xrsubrepor.SizeF = new SizeF(624, 80.72F);
                    point.Y += 80.72F;
                }


                //Obtencion de los fax si existe.
                bdanexoDataSet.faxDataTable fax = faxTableAdapter1.GetFaxByUsuario(idexpediente);
                if (fax.Count > 0)
                {
                    XRSubreport xrsubrepor = new XRSubreport();
                    xrsubrepor.ReportSource = new faxReport(((bdanexoDataSet.faxRow)fax.Rows[0]).marca,
                    ((bdanexoDataSet.faxRow)fax.Rows[0]).modelo, ((bdanexoDataSet.faxRow)fax.Rows[0]).noinventario, ((bdanexoDataSet.faxRow)fax.Rows[0]).noserie);
                    Detail.Controls.Add(xrsubrepor);
                    xrsubrepor.LocationF = point;
                    xrsubrepor.CanGrow = false;
                    xrsubrepor.Visible = true;
                    xrsubrepor.SizeF = new SizeF(624, 80.72F);
                    point.Y += 80.72F;
                }

                //Obtencion de los impresora si existe.
                bdanexoDataSet.impresoraDataTable impresora = impresoraTableAdapter1.GetImpresoraByUsuario(idexpediente);
                if (impresora.Count > 0)
                {
                    XRSubreport xrsubrepor = new XRSubreport();
                    xrsubrepor.ReportSource = new impresoraReport(((bdanexoDataSet.impresoraRow)impresora.Rows[0]).modelo,
                        ((bdanexoDataSet.impresoraRow)impresora.Rows[0]).noserie, ((bdanexoDataSet.impresoraRow)impresora.Rows[0]).noinventario,
                        ((bdanexoDataSet.impresoraRow)impresora.Rows[0]).marca);
                    Detail.Controls.Add(xrsubrepor);
                    xrsubrepor.LocationF = point;
                    xrsubrepor.CanGrow = false;
                    xrsubrepor.Visible = true;
                    xrsubrepor.SizeF = new SizeF(624, 80.72F);
                    point.Y += 80.72F;
                }

                //Obtencion de los monitor si existe.
                bdanexoDataSet.monitorDataTable monitor = monitorTableAdapter1.GetMonitorByUsuario(idexpediente);
                if (monitor.Count > 0)
                {
                    XRSubreport xrsubrepor = new XRSubreport();
                    xrsubrepor.ReportSource = new monitorReport(((bdanexoDataSet.monitorRow)monitor.Rows[0]).modelo, ((bdanexoDataSet.monitorRow)monitor.Rows[0]).noserie,
                        ((bdanexoDataSet.monitorRow)monitor.Rows[0]).noinventario, ((bdanexoDataSet.monitorRow)monitor.Rows[0]).marca);
                    Detail.Controls.Add(xrsubrepor);
                    xrsubrepor.LocationF = point;
                    xrsubrepor.CanGrow = false;
                    xrsubrepor.Visible = true;
                    xrsubrepor.SizeF = new SizeF(624, 80.72F);
                    point.Y += 80.72F;
                }

                //Obtencion de los ups si existe.
                bdanexoDataSet.upsDataTable ups = upsTableAdapter1.GetUpsByUsuario(idexpediente);
                if (ups.Count > 0)
                {
                    XRSubreport xrsubrepor = new XRSubreport();
                    xrsubrepor.ReportSource = new upsReport(((bdanexoDataSet.upsRow)ups.Rows[0]).modelo, ((bdanexoDataSet.upsRow)ups.Rows[0]).noserie,
                        ((bdanexoDataSet.upsRow)ups.Rows[0]).noinventario, ((bdanexoDataSet.upsRow)ups.Rows[0]).marca);
                    Detail.Controls.Add(xrsubrepor);
                    xrsubrepor.LocationF = point;
                    xrsubrepor.CanGrow = false;
                    xrsubrepor.Visible = true;
                    xrsubrepor.SizeF = new SizeF(624, 80.72F);
                    point.Y += 80.72F;
                }


                //Obtencion de los switch si existe.
                bdanexoDataSet.switchDataTable swt = switchTableAdapter1.GetSwitchByUsuario(idexpediente);
                if (swt.Count > 0)
                {
                    XRSubreport xrsubrepor = new XRSubreport();
                    xrsubrepor.ReportSource = new SwReport(((bdanexoDataSet.switchRow)swt.Rows[0]).modelo, ((bdanexoDataSet.switchRow)swt.Rows[0]).noserie,
                        ((bdanexoDataSet.switchRow)swt.Rows[0]).noinventario, ((bdanexoDataSet.switchRow)swt.Rows[0]).marca);
                    Detail.Controls.Add(xrsubrepor);
                    xrsubrepor.LocationF = point;
                    xrsubrepor.CanGrow = false;
                    xrsubrepor.Visible = true;
                    xrsubrepor.SizeF = new SizeF(624, 80.72F);
                    point.Y += 80.72F;
                }

                //Obtencion de los fotocopiadora si existe.
                bdanexoDataSet.fotocopiadoraDataTable ft = fotocopiadoraTableAdapter1.GetFotocopiadoraByUsuario(idexpediente);
                if (ft.Count > 0)
                {
                    XRSubreport xrsubrepor = new XRSubreport();
                    xrsubrepor.ReportSource = new fotocopiadoraReport(((bdanexoDataSet.fotocopiadoraRow)ft.Rows[0]).modelo, ((bdanexoDataSet.fotocopiadoraRow)ft.Rows[0]).noserie,
                        ((bdanexoDataSet.fotocopiadoraRow)ft.Rows[0]).noinventario, ((bdanexoDataSet.fotocopiadoraRow)ft.Rows[0]).marca);
                    Detail.Controls.Add(xrsubrepor);
                    xrsubrepor.LocationF = point;
                    xrsubrepor.CanGrow = false;
                    xrsubrepor.Visible = true;
                    xrsubrepor.SizeF = new SizeF(624, 80.72F);
                    point.Y += 80.72F;
                }

                XRLabel label1 = new XRLabel();
                label1.Text = "Elaborado por: ";
                Detail.Controls.Add(label1);
                label1.Visible = true;
                point.Y += 15;
                label1.LocationF = point;

                XRLine line1 = new XRLine();
                line1.LineWidth = 1;
                line1.SizeF = new System.Drawing.SizeF(358, 23);
                line1.Visible = true;
                PointF pontLine = new PointF();
                pontLine.X = point.X + 90;
                pontLine.Y = point.Y;
                line1.LocationF = pontLine;
                Detail.Controls.Add(line1);


                XRLabel label2 = new XRLabel();
                label2.Text = "Firma: ";
                Detail.Controls.Add(label2);
                label2.Visible = true;
                point.Y += 23;
                label2.LocationF = point;

                XRLine line2 = new XRLine();
                line2.LineWidth = 1;
                line2.SizeF = new System.Drawing.SizeF(358, 23);
                line2.Visible = true;
                Detail.Controls.Add(line2);
                pontLine.Y = point.Y;
                line2.LocationF = pontLine;

                XRLabel label3 = new XRLabel();
                label3.Text = "Usuario: ";
                Detail.Controls.Add(label3);
                label3.Visible = true;
                point.Y += 23;
                label3.LocationF = point;

                XRLine line3 = new XRLine();
                line3.LineWidth = 1;
                line3.SizeF = new System.Drawing.SizeF(358, 23);
                line3.Visible = true;
                Detail.Controls.Add(line3);
                pontLine.Y = point.Y;
                line3.LocationF = pontLine;

            }
        }
    }
}
