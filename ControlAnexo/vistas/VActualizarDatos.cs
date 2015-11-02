using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ControlAnexo.modelo;

namespace ControlAnexo.vistas
{
    public partial class VActualizarDatos : DevExpress.XtraEditors.XtraForm
    {
        List<DiscoDuro> listDiscosDuros;
        
        Usuario usuario;
        Equipo equipo;
        DiscoDuro discoduro;
        Configuracion config; 
        Accesorios accesorios;
        CdRoom cdroom;
        Disquete disquete;
        Fax fx;
        Fotocopiadora fotoc;
        Impresora impresora;
        Monitor monitor;
        Scanner scaner;
        Switch swt;
        Ups bck;

        DiscoDuro GetSelectedDiscoDuro()
        {
            DiscoDuro dd = null;
            int[] selecteds = gridView1.GetSelectedRows();
            if (selecteds.Length > 0)
            {
                dd = new DiscoDuro();
                object row = gridView1.GetRow(selecteds[0]);
                dd.id = ((DiscoDuro)(row)).id;
                dd.descripcion = ((DiscoDuro)(row)).descripcion;
                dd.capacidad = ((DiscoDuro)(row)).capacidad;
                dd.noserie = ((DiscoDuro)(row)).noserie;
            }
            return dd;

        }

        public event EventHandler ActualizacionDatos;
        private List<DiscoDuro> listDiscosDurosVieja;

        public VActualizarDatos(string SelectedId)
        {
            InitializeComponent();
            listDiscosDuros = new List<DiscoDuro>();
            listDiscosDurosVieja = new List<DiscoDuro>();
            usuario = new Usuario();
            equipo = new Equipo();
            discoduro = new DiscoDuro();
            accesorios = new Accesorios();
            cdroom = new CdRoom();
            disquete = new Disquete();
            fx = new Fax();
            fotoc = new Fotocopiadora();
            impresora = new Impresora();
            monitor = new Monitor();
            scaner = new Scanner();
            swt = new Switch();
            bck = new Ups();
            config = new Configuracion(); 

            BuscarDatos(SelectedId);
        }

        private void BuscarDatos(string SelectedId)
        {
            bdanexoDataSet.expedienteDataTable exp = expedienteTableAdapter1.ExpedienteById(Convert.ToInt16(SelectedId));
            int idusuario = ((bdanexoDataSet.expedienteRow)exp.Rows[0]).idusuario;
            if (exp.Rows.Count > 0)
            {
                usuario = ConvertirAUsuario(idusuario);
                if (usuario != null)
                {
                    PagUsuario.PageVisible = true;
                    txtnombre.Text = usuario.UsuarioNombre;
                    txtuser.Text = usuario.usuario;
                    txtcorreo.Text = usuario.Correo;
                    txtarea.Text = usuario.Area;
                    labelControl3.Text = "Id: " + usuario.id; 
                }
            }

            equipo = ConvetirAEquipo(idusuario); 
            if (equipo!=null)
            {
                PagEquipo.PageVisible = true;
                groupEquipo.Enabled = true; 
                txtnombreequipo.Text = equipo.nombre;
                txtnoinvequipo.Text = equipo.noinventario;
                txtnoserieequipo.Text = equipo.noserie;
                txtdominiored.Text = equipo.dominiored;
               
                memoobservaciones.Text = equipo.observaciones;
            }


            config = ConvertirAConfig(idusuario);
            if (config !=null)
            {
                PagEquipo.PageVisible = true;
                groupConfiguracion.Enabled = true;
                txtplacabase.Text = config.placabase;
                txtnoserieconfig.Text = config.noserieplacabase;
                txtprocesador.Text = config.procesador;
                txtvelocidad.Text = config.velocidad;
                txtmemoria.Text = config.memoria;
                txtcantidadconfiguracion.Text = config.cantidad;
                txttarjetagrafica.Text = config.tarjetavideo;
                txttarjetasonido.Text = config.tarjetasonido;
                txttarjetared.Text = config.tarjetared;

            }

             bdanexoDataSet.discoduroDataTable dd = discoduroTableAdapter1.GetDiscoDuroByUsuario(((bdanexoDataSet.expedienteRow)exp.Rows[0]).Id);
             if (dd.Rows.Count > 0)
             {
                 PagDiscoDuro.PageVisible = true; 
                 foreach (var item in dd.Rows)
                 {
                     DiscoDuro disco = new DiscoDuro();
                     disco.descripcion = ((bdanexoDataSet.discoduroRow)item).descripcion;
                     disco.capacidad = ((bdanexoDataSet.discoduroRow)item).capacidad;
                     disco.noserie = ((bdanexoDataSet.discoduroRow)item).noserie;
                     disco.estado = ((bdanexoDataSet.discoduroRow)item).estado; 
                     listDiscosDuros.Add(disco); 
                 }
                 listDiscosDurosVieja = listDiscosDuros; 
                 gridControlDD.DataSource = listDiscosDuros;
             }

            // almacenamiento 
             cdroom = ConvertirACD(idusuario);
             if (cdroom !=null)
             {
                 PagAlmacenamiento.PageVisible = true;
                 groupLector.Enabled = true; 
                 txtcddescripcion.Text = cdroom.nombre;
                 txtcdnoserie.Text = cdroom.noserie;
                 cbxestadocd.Text = cdroom.estadocdroom;
             }

             disquete = ConvertirADisquete(idusuario);
             if (disquete!= null )
             {
                 PagAlmacenamiento.PageVisible = true;
                 groupDisquete.Enabled = true;
                 txtdescripciondisquete.Text = disquete.nombre;
                 txtdisquetenoserie.Text = disquete.noserie;
                 cbxestadodisq.Text = disquete.estado;
             }
            
            // accesorios
             accesorios = ConvertirAAccesorios(idusuario);
             if (accesorios != null)
             {
                 PagAccesorios.PageVisible = true;
                 
                 txtteclado.Text = accesorios.teclado;
                 txtraton.Text = accesorios.mouse;
                 txtbocinas.Text = accesorios.bocina;

                 cbxestadobocinas.Text = accesorios.estadobocina;
                 cbxestadoraton.Text = accesorios.estadomouse;
                 cbxestadoteclado.Text = accesorios.estadoteclado; 
             }

            //impresora
             impresora = ConvertirAImpresora(idusuario);
             if (impresora != null)
             {
                 PagImpresora.PageVisible = true;
                 txtimpresoramarca.Text = impresora.marca;
                 txtimpresoramodelo.Text = impresora.modelo;
                 txtimpresoranoserie.Text = impresora.noserie;
                 txtimpresoranoinventario.Text = impresora.noinventario;
                 cbxestadoimpresora.Text = impresora.estado; 
             }

            //monitor
             monitor = ConvertirAMonitor(idusuario);
             if (monitor != null)
             {
                 PagMonitor.PageVisible = true;
                 txtmonitormarca.Text = monitor.marca;
                 txtmonitornoserie.Text = monitor.noserie;
                 txtmonitormodelo.Text = monitor.modelo;
                 txtmonitornoinv.Text = monitor.noinventario;
                 cbxestadomonitor.Text = monitor.estado; 
             }

            //switch
            swt = ConvertirASwitch(idusuario);
            if (swt != null)
            {
                PagSwitch.PageVisible = true;
                txtswitcmarca.Text = swt.marca;
                txtswitchnoserie.Text = swt.noserie;
                txtswitchmodelo.Text = swt.modelo;
                txtswitchnoinv.Text = swt.noinventario;
                cbxestadoswitch.Text = swt.estado;
            }

            //fax
            fx = ConvertirAFax(idusuario);
            if (fx != null)
            {
                PagFax.PageVisible = true;
                txtfaxmarca.Text = fx.marca;
                txtfaxnoseie.Text = fx.noserie;
                txtfaxmodelo.Text = fx.modelo;
                txtfaxnoinv.Text = fx.noinventario;
                cbxestadofax.Text = fx.estado; 
            }
             //Backup 
            bck = ConvertirAUps(idusuario);
            if (bck != null)
            {
                PagBackup.PageVisible = true;
                txtbackupmarca.Text = bck.marca;
                txtbackupnoserie.Text = bck.noserie;
                txtbackupmodelo.Text = bck.modelo;
                txtbackupnoinv.Text = bck.noinventario;
                cbxestadoups.Text = bck.estado; 
            }
            // escaner
            scaner = ConvertirAScaner(idusuario);
            if (scaner != null)
            {
                PagScaneer.PageVisible = true;
                txtscanermarca.Text = scaner.marca;
                txtscanernoserie.Text = scaner.noserie;
                txtscanermodelo.Text = scaner.modelo;
                txtscanernoinv.Text = scaner.noinventario;
                cbxestadoscaner.Text = scaner.estado;
            }

            // fotocopiadora 
            fotoc = ConvertirAFoct(idusuario);
            if (fotoc != null)
            {
                PagFotoc.PageVisible = true;
                txtfotocopiadoramarca.Text = fotoc.marca;
                txtfotocopiadoranoserie.Text = fotoc.noserie;
                txtfotocopiadoramodelo.Text = fotoc.modelo;
                txtfotocopiadoranoinventario.Text = fotoc.noinventario;
                cbxestadofotocopiadora.Text = fotoc.estado; 
            }
        }

        private Fotocopiadora ConvertirAFoct(int idusuario)
        {
            Fotocopiadora fot = null; 
            bdanexoDataSet.fotocopiadoraDataTable ft = fotocopiadoraTableAdapter1.GetFotocopiadoraByUsuario(idusuario);
            if (ft.Rows.Count > 0)
            {
                fot = new Fotocopiadora(); 
                fot.marca = ((bdanexoDataSet.fotocopiadoraRow)ft.Rows[0]).marca;
                fot.noserie = ((bdanexoDataSet.fotocopiadoraRow)ft.Rows[0]).noserie;
                fot.modelo = ((bdanexoDataSet.fotocopiadoraRow)ft.Rows[0]).modelo;
                fot.noinventario = ((bdanexoDataSet.fotocopiadoraRow)ft.Rows[0]).noinventario;
                fot.estado = ((bdanexoDataSet.fotocopiadoraRow)ft.Rows[0]).estado;
                fot.id = ((bdanexoDataSet.fotocopiadoraRow)ft.Rows[0]).Id;
            }
            return fot; 
        }

        private Scanner ConvertirAScaner(int idusuario)
        {
            Scanner sc = null; 
            bdanexoDataSet.escannerDataTable esc = escannerTableAdapter1.GetScannerByUsuario(idusuario);
            if (esc.Rows.Count > 0)
            {
                sc = new Scanner(); 
                sc.marca = ((bdanexoDataSet.escannerRow)esc.Rows[0]).marca;
                sc.noserie = ((bdanexoDataSet.escannerRow)esc.Rows[0]).noserie;
                sc.modelo = ((bdanexoDataSet.escannerRow)esc.Rows[0]).modelo;
                sc.noinventario = ((bdanexoDataSet.escannerRow)esc.Rows[0]).noinventario;
                sc.estado = ((bdanexoDataSet.escannerRow)esc.Rows[0]).estado;
                sc.id = ((bdanexoDataSet.escannerRow)esc.Rows[0]).Id;
            }
            return sc;
        }

        private Ups ConvertirAUps(int idusuario)
        {
            Ups us = null; 
            bdanexoDataSet.upsDataTable ups = upsTableAdapter1.GetUpsByUsuario(idusuario);
            if (ups.Rows.Count > 0)
            {
                us = new Ups();
                us.marca = ((bdanexoDataSet.upsRow)ups.Rows[0]).marca;
                us.noserie= ((bdanexoDataSet.upsRow)ups.Rows[0]).noserie;
                us.modelo = ((bdanexoDataSet.upsRow)ups.Rows[0]).modelo;
                us.noinventario = ((bdanexoDataSet.upsRow)ups.Rows[0]).noinventario;
                us.estado= ((bdanexoDataSet.upsRow)ups.Rows[0]).estado;
                us.id = ((bdanexoDataSet.upsRow)ups.Rows[0]).Id; 
            }
            return us;
        }

        private Fax ConvertirAFax(int idusuario)
        {
            Fax fx = null; 
            bdanexoDataSet.faxDataTable fax = faxTableAdapter1.GetFaxByUsuario(idusuario);
            if (fax.Rows.Count > 0)
            {
                fx = new Fax();
                fx.marca = ((bdanexoDataSet.faxRow)fax.Rows[0]).marca;
                fx.noserie = ((bdanexoDataSet.faxRow)fax.Rows[0]).noserie;
                fx.modelo = ((bdanexoDataSet.faxRow)fax.Rows[0]).modelo;
                fx.noinventario = ((bdanexoDataSet.faxRow)fax.Rows[0]).noinventario;
                fx.estado = ((bdanexoDataSet.faxRow)fax.Rows[0]).estado;
                fx.id = ((bdanexoDataSet.faxRow)fax.Rows[0]).Id;
            }
            return fx; 
        }

        private Switch ConvertirASwitch(int idusuario)
        {
            Switch swt = null; 
            bdanexoDataSet.switchDataTable sw = switchTableAdapter1.GetSwitchByUsuario(idusuario);
            if (sw.Rows.Count > 0)
            {
                swt = new Switch(); 
                PagSwitch.PageVisible = true;
                swt.marca = ((bdanexoDataSet.switchRow)sw.Rows[0]).marca;
                swt.noserie = ((bdanexoDataSet.switchRow)sw.Rows[0]).noserie;
                swt.modelo = ((bdanexoDataSet.switchRow)sw.Rows[0]).modelo;
                swt.noinventario = ((bdanexoDataSet.switchRow)sw.Rows[0]).noinventario;
                swt.estado = ((bdanexoDataSet.switchRow)sw.Rows[0]).estado;
                swt.id = ((bdanexoDataSet.switchRow)sw.Rows[0]).Id;
            }
            return swt; 
        }

        private Monitor ConvertirAMonitor(int idusuario)
        {
            Monitor mon = null; 
            bdanexoDataSet.monitorDataTable mont = monitorTableAdapter1.GetMonitorByUsuario(idusuario);
            if (mont.Rows.Count > 0)
            {
                mon = new Monitor(); 
                mon.marca = ((bdanexoDataSet.monitorRow)mont.Rows[0]).marca;
                mon.noserie = ((bdanexoDataSet.monitorRow)mont.Rows[0]).noserie;
                mon.modelo = ((bdanexoDataSet.monitorRow)mont.Rows[0]).modelo;
                mon.noinventario = ((bdanexoDataSet.monitorRow)mont.Rows[0]).noinventario;
                mon.estado = ((bdanexoDataSet.monitorRow)mont.Rows[0]).estado;
                mon.id = ((bdanexoDataSet.monitorRow)mont.Rows[0]).Id;
            }
            return mon; 
        }

        private Impresora ConvertirAImpresora(int idusuario)
        {
            Impresora impresora = null; 
            bdanexoDataSet.impresoraDataTable imp = impresoraTableAdapter1.GetImpresoraByUsuario(idusuario);
            if (imp.Rows.Count > 0)
            {
                impresora = new Impresora(); 
                impresora.marca = ((bdanexoDataSet.impresoraRow)imp.Rows[0]).marca;
                impresora.modelo = ((bdanexoDataSet.impresoraRow)imp.Rows[0]).modelo;
                impresora.noserie = ((bdanexoDataSet.impresoraRow)imp.Rows[0]).noserie;
                impresora.noinventario = ((bdanexoDataSet.impresoraRow)imp.Rows[0]).noinventario;
                impresora.estado = ((bdanexoDataSet.impresoraRow)imp.Rows[0]).estado;
                impresora.id = ((bdanexoDataSet.impresoraRow)imp.Rows[0]).Id;
            }
            return impresora; 
        }

        private Accesorios ConvertirAAccesorios(int idusuario)
        {
            Accesorios ac = null; 
            bdanexoDataSet.accesoriosDataTable acc = accesoriosTableAdapter1.GetAccesoriosByUsuario(idusuario);
            if (acc.Rows.Count > 0)
            {
                ac = new Accesorios();
                ac.teclado = ((bdanexoDataSet.accesoriosRow)acc.Rows[0]).teclado;
                ac.mouse = ((bdanexoDataSet.accesoriosRow)acc.Rows[0]).mouse;
                ac.bocina = ((bdanexoDataSet.accesoriosRow)acc.Rows[0]).bocinas;

                ac.estadobocina = ((bdanexoDataSet.accesoriosRow)acc.Rows[0]).estadobocinas;
                ac.estadomouse = ((bdanexoDataSet.accesoriosRow)acc.Rows[0]).estadomouse;
                ac.estadoteclado = ((bdanexoDataSet.accesoriosRow)acc.Rows[0]).estadoteclado;
            }
            return ac; 
        }

        private Disquete ConvertirADisquete(int idusuario)
        {
            Disquete ds = null; 
            bdanexoDataSet.disqueteDataTable disq = disqueteTableAdapter1.GetDisqueteByUsuario(idusuario);
            if (disq.Rows.Count > 0)
            {
                ds = new Disquete(); 
                ds.nombre = ((bdanexoDataSet.disqueteRow)disq.Rows[0]).nombre;
                ds.noserie = ((bdanexoDataSet.disqueteRow)disq.Rows[0]).noserie;
                ds.estado = ((bdanexoDataSet.disqueteRow)disq.Rows[0]).estado;
                ds.id = ((bdanexoDataSet.disqueteRow)disq.Rows[0]).Id;
            }
            return ds; 
        }

        private CdRoom ConvertirACD(int idusuario)
        {
            CdRoom cdr = null; 
            bdanexoDataSet.cdroomDataTable cd = cdroomTableAdapter1.GetDVDByUsuario(idusuario);
            if (cd.Rows.Count > 0)
            {
                cdr = new CdRoom(); 
                cdr.nombre  = ((bdanexoDataSet.cdroomRow)cd.Rows[0]).nombre;
                cdr.noserie= ((bdanexoDataSet.cdroomRow)cd.Rows[0]).noserie;
                cdr.estadocdroom = ((bdanexoDataSet.cdroomRow)cd.Rows[0]).estado;
                cdr.id = ((bdanexoDataSet.cdroomRow)cd.Rows[0]).Id;
            }
            return cdr; 
        }

        private Configuracion ConvertirAConfig(int idusuario)
        {
            Configuracion cf = null; 
            bdanexoDataSet.configuracionDataTable confg = configuracionTableAdapter1.GetConfiguracionByUsuario(idusuario);
            if (confg.Rows.Count > 0)
            {
                cf = new Configuracion(); 
                cf.placabase = ((bdanexoDataSet.configuracionRow)confg.Rows[0]).placabase;
                cf.noserieplacabase = ((bdanexoDataSet.configuracionRow)confg.Rows[0]).noserieplaca;
                cf.procesador = ((bdanexoDataSet.configuracionRow)confg.Rows[0]).procesador;
                cf.velocidad = ((bdanexoDataSet.configuracionRow)confg.Rows[0]).velocidad;
                cf.memoria = ((bdanexoDataSet.configuracionRow)confg.Rows[0]).memoria;
                cf.cantidad = ((bdanexoDataSet.configuracionRow)confg.Rows[0]).cantidad;
                cf.tarjetavideo = ((bdanexoDataSet.configuracionRow)confg.Rows[0]).tarjetagrafica;
                cf.tarjetasonido = ((bdanexoDataSet.configuracionRow)confg.Rows[0]).tarjetasonido;
                cf.tarjetared= ((bdanexoDataSet.configuracionRow)confg.Rows[0]).tarjetared;
                cf.id = ((bdanexoDataSet.configuracionRow)confg.Rows[0]).Id;

            }
            return cf;
        }

        private Equipo ConvetirAEquipo(int idusuario)
        {
            Equipo equip = null;  
            bdanexoDataSet.equipoDataTable equipo = equipoTableAdapter1.GetEquipoByUsuario(idusuario);
            if (equipo.Rows.Count > 0)
            {
                equip = new Equipo(); 
                equip.nombre = ((bdanexoDataSet.equipoRow)equipo.Rows[0]).nombre;
                equip.noinventario = ((bdanexoDataSet.equipoRow)equipo.Rows[0]).noinventario;
                equip.noserie = ((bdanexoDataSet.equipoRow)equipo.Rows[0]).noserie;
                equip.dominiored = ((bdanexoDataSet.equipoRow)equipo.Rows[0]).dominiored;
                equip.observaciones = ((bdanexoDataSet.equipoRow)equipo.Rows[0]).observaciones;
                equip.id = ((bdanexoDataSet.equipoRow)equipo.Rows[0]).Id;
            }
            return equip; 
        }

        private Usuario ConvertirAUsuario(int idusuario)
        {
            Usuario us = null; 
            bdanexoDataSet.usuarioDataTable usuario = usuarioTableAdapter1.UsuarioById(idusuario);
            if (usuario.Rows.Count > 0)
            {
                us = new Usuario();
                us.UsuarioNombre = ((bdanexoDataSet.usuarioRow)usuario.Rows[0]).nombreusuario;
                us.usuario = ((bdanexoDataSet.usuarioRow)usuario.Rows[0]).usuario;
                us.Correo = ((bdanexoDataSet.usuarioRow)usuario.Rows[0]).correo;
                us.Area = ((bdanexoDataSet.usuarioRow)usuario.Rows[0]).area;
                us.id = ((bdanexoDataSet.usuarioRow)usuario.Rows[0]).Id;
            }
            return us;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ActualizarDatos();
            this.Close(); 
        }

        void ActualizarDatos()
        {
            if (usuario != null)
            {
                usuarioTableAdapter1.Fill(bdanexoDataSet1.usuario);
                usuarioTableAdapter1.Update(txtuser.Text, txtcorreo.Text, txtarea.Text, txtnombre.Text, usuario.id, usuario.usuario, usuario.Correo, usuario.Area, usuario.UsuarioNombre);
                usuarioTableAdapter1.Update(bdanexoDataSet1.usuario);
                usuarioTableAdapter1.Fill(bdanexoDataSet1.usuario);

                int? idcliente = usuarioTableAdapter1.IdUltimoPedidoInsertado();
                int? idexpediente = expedienteTableAdapter1.IdUltimoExpedienteInsertado();

                if (equipo != null)
                {
                    equipoTableAdapter1.Fill(bdanexoDataSet1.equipo);
                    equipoTableAdapter1.Update(txtnoinvequipo.Text, txtnoserieequipo.Text, memoobservaciones.Text, txtdominiored.Text, txtnombreequipo.Text, cbxestadodd.Text, idexpediente
                                                , equipo.id, equipo.noinventario, equipo.noserie, equipo.observaciones, equipo.dominiored, equipo.nombre, equipo.estado, idexpediente);
                    equipoTableAdapter1.Update(bdanexoDataSet1.equipo);
                    equipoTableAdapter1.Fill(bdanexoDataSet1.equipo);
                }

                if (config != null)
                {
                    configuracionTableAdapter1.Fill(bdanexoDataSet1.configuracion);
                    configuracionTableAdapter1.Update(txtplacabase.Text, txtnoserieconfig.Text, txtcantidadconfiguracion.Text, txtmemoria.Text, txtvelocidad.Text, txtprocesador.Text, txttarjetared.Text,
                                                      txttarjetasonido.Text, txttarjetagrafica.Text, txtnoinvequipo.Text, idexpediente,
                                                      config.id, config.placabase, config.noserieplacabase, config.cantidad, config.memoria, config.velocidad, config.procesador,
                                                      config.tarjetared, config.tarjetasonido, config.tarjetavideo, config.noinventario, idexpediente);
                    configuracionTableAdapter1.Update(bdanexoDataSet1.configuracion);
                    configuracionTableAdapter1.Fill(bdanexoDataSet1.configuracion);
                }

                if (accesorios != null)
                {
                    accesoriosTableAdapter1.Fill(bdanexoDataSet1.accesorios);
                    accesoriosTableAdapter1.Update(txtteclado.Text, txtraton.Text, txtbocinas.Text, cbxestadoteclado.Text, idexpediente, cbxestadobocinas.Text, cbxestadoraton.Text,
                                                   accesorios.id, accesorios.teclado, accesorios.mouse, accesorios.bocina, accesorios.estadoteclado, idexpediente, accesorios.estadobocina,
                                                   accesorios.estadomouse);
                    accesoriosTableAdapter1.Update(bdanexoDataSet1.accesorios);
                    accesoriosTableAdapter1.Fill(bdanexoDataSet1.accesorios);
                }

                if (listDiscosDuros.Count > 0)
                {
                    foreach (var item in listDiscosDuros)
                    {
                        foreach (var itemviejo in listDiscosDurosVieja)
                        {
                            if (item.id == itemviejo.id)
                            {
                                discoduroTableAdapter1.Fill(bdanexoDataSet1.discoduro);
                                discoduroTableAdapter1.Update(item.capacidad, item.noserie, item.descripcion,
                                                      cbxestadodd.Text, idexpediente, itemviejo.id, itemviejo.capacidad, itemviejo.noserie, 
                                                      itemviejo.descripcion, itemviejo.estado, idexpediente);
                                discoduroTableAdapter1.Update(bdanexoDataSet1.discoduro);
                                discoduroTableAdapter1.Fill(bdanexoDataSet1.discoduro);
                                break;
                            }
                        }
                    }
                }

                if (cdroom != null)
                {
                    cdroomTableAdapter1.Fill(bdanexoDataSet1.cdroom);
                    cdroomTableAdapter1.Update(txtcddescripcion.Text, txtcdnoserie.Text, cbxestadocd.Text, idexpediente, cdroom.id, cdroom.nombre, cdroom.noserie, cdroom.estadocdroom, idexpediente);
                    cdroomTableAdapter1.Update(bdanexoDataSet1.cdroom);
                    cdroomTableAdapter1.Fill(bdanexoDataSet1.cdroom);
                }

                if (disquete != null)
                {

                    disqueteTableAdapter1.Fill(bdanexoDataSet1.disquete);
                    disqueteTableAdapter1.Update(txtdescripciondisquete.Text, txtdisquetenoserie.Text, cbxestadodisq.Text, idexpediente, disquete.id, disquete.nombre, disquete.noserie,
                                                 disquete.estado, idexpediente);
                    disqueteTableAdapter1.Update(bdanexoDataSet1.disquete);
                    disqueteTableAdapter1.Fill(bdanexoDataSet1.disquete);
                }

                if (impresora != null)
                {

                    impresoraTableAdapter1.Fill(bdanexoDataSet1.impresora);
                    impresoraTableAdapter1.Update(txtimpresoramodelo.Text, txtimpresoranoserie.Text, txtimpresoranoinventario.Text, txtimpresoramarca.Text, cbxestadoimpresora.Text,
                                                   idexpediente, impresora.id, impresora.modelo, impresora.noserie, impresora.noinventario, impresora.marca,
                                                   impresora.estado, idexpediente);
                    impresoraTableAdapter1.Update(bdanexoDataSet1.impresora);
                    impresoraTableAdapter1.Fill(bdanexoDataSet1.impresora);
                }

                if (bck != null)
                {
                    upsTableAdapter1.Fill(bdanexoDataSet1.ups);
                    upsTableAdapter1.Update(txtbackupmarca.Text, txtbackupnoserie.Text, txtbackupnoinv.Text, txtbackupmodelo.Text, cbxestadoups.Text, idexpediente,
                                            bck.id, bck.marca, bck.noserie, bck.noinventario, bck.modelo, bck.estado, idexpediente);
                    upsTableAdapter1.Update(bdanexoDataSet1.ups);
                    upsTableAdapter1.Fill(bdanexoDataSet1.ups);
                }

                if (monitor != null)
                {
                    monitorTableAdapter1.Fill(bdanexoDataSet1.monitor);
                    monitorTableAdapter1.Update(txtmonitormarca.Text, txtmonitormodelo.Text, txtmonitornoserie.Text, txtmonitornoinv.Text, cbxestadomonitor.Text, idexpediente,
                                                 monitor.id, monitor.marca, monitor.modelo, monitor.noserie, monitor.noinventario, monitor.estado, idexpediente);
                    monitorTableAdapter1.Update(bdanexoDataSet1.monitor);
                    monitorTableAdapter1.Fill(bdanexoDataSet1.monitor);
                }

                if (fotoc != null)
                {

                    fotocopiadoraTableAdapter1.Fill(bdanexoDataSet1.fotocopiadora);
                    fotocopiadoraTableAdapter1.Update(txtfotocopiadoramarca.Text, txtfotocopiadoramodelo.Text, txtimpresoranoserie.Text, txtfotocopiadoranoinventario.Text, cbxestadofotocopiadora.Text, idexpediente,
                                                       fotoc.id, fotoc.marca, fotoc.modelo, fotoc.noserie, fotoc.noinventario, fotoc.estado, idexpediente);
                    fotocopiadoraTableAdapter1.Update(bdanexoDataSet1.fotocopiadora);
                    fotocopiadoraTableAdapter1.Fill(bdanexoDataSet1.fotocopiadora);
                }

                if (fx != null)
                {
                    faxTableAdapter1.Fill(bdanexoDataSet1.fax);
                    faxTableAdapter1.Update(txtfaxmarca.Text, txtfaxmodelo.Text, txtfaxnoseie.Text, txtfaxnoinv.Text, cbxestadofax.Text, idexpediente, fx.id,
                                            fx.marca, fx.modelo, fx.noserie, fx.noinventario, fx.estado, idexpediente);
                    faxTableAdapter1.Update(bdanexoDataSet1.fax);
                    faxTableAdapter1.Fill(bdanexoDataSet1.fax);
                }

                if (swt != null)
                {

                    switchTableAdapter1.Fill(bdanexoDataSet1._switch);
                    switchTableAdapter1.Update(txtswitchmodelo.Text, txtswitcmarca.Text, txtswitchnoserie.Text, txtswitchnoinv.Text, cbxestadoswitch.Text, idexpediente,
                                                  swt.id, swt.modelo, swt.marca, swt.noserie, swt.noinventario, swt.estado, idexpediente);
                    switchTableAdapter1.Update(bdanexoDataSet1._switch);
                }

                if (scaner != null)
                {
                    escannerTableAdapter1.Fill(bdanexoDataSet1.escanner);
                    escannerTableAdapter1.Update(txtscanermarca.Text, txtscanermodelo.Text, txtscanernoserie.Text, txtscanernoinv.Text, idcliente, cbxestadoscaner.Text, idexpediente,
                        scaner.id, scaner.marca, scaner.modelo, scaner.noserie, scaner.noinventario, 1, scaner.estado, idexpediente);
                    escannerTableAdapter1.Update(bdanexoDataSet1.escanner);
                    escannerTableAdapter1.Fill(bdanexoDataSet1.escanner);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            ActualizarDatos();
        }

        private void VActualizarDatos_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (ActualizacionDatos != null)
                ActualizacionDatos(sender, null);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DiscoDuro dd = new DiscoDuro();
            dd.descripcion = txtdiscodurodescrpcion.Text;
            dd.capacidad = txtcapacidad.Text;
            dd.noserie = txtdiscoduronoserie.Text;
            listDiscosDuros.Add(dd);

            txtdiscodurodescrpcion.Text = "";
            txtdiscoduronoserie.Text = "";
            txtcapacidad.Text = "";

            gridControlDD.DataSource = null;
            gridControlDD.DataSource = listDiscosDuros;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DiscoDuro dd = GetSelectedDiscoDuro();
            foreach (var item in listDiscosDuros)
            {
                if (item.id == dd.id)
                {
                    item.capacidad = txtcapacidad.Text;
                    item.descripcion = txtdiscodurodescrpcion.Text;
                    item.estado = cbxestadodd.Text;
                    item.noserie = txtdiscoduronoserie.Text;
                    break;
                }
            }

            txtcapacidad.Text = "";
            txtdiscodurodescrpcion.Text = "";
            cbxestadodd.SelectedIndex = 0;
            txtdiscoduronoserie.Text = ""; 

            gridControlDD.DataSource = null;
            gridControlDD.DataSource = listDiscosDuros;
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            DiscoDuro dd = GetSelectedDiscoDuro();

            txtdiscodurodescrpcion.Text = dd.descripcion;
            txtdiscoduronoserie.Text = dd.noserie;
            txtcapacidad.Text = dd.capacidad;
            cbxestadodd.Text = dd.estado; 
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DiscoDuro dd = GetSelectedDiscoDuro();
            foreach (var item in listDiscosDuros)
            {
                if (dd.id == item.id)
                {
                    listDiscosDuros.Remove(item);
                    break;
                }
            }
            gridControlDD.DataSource = null;
            gridControlDD.DataSource = listDiscosDuros;
        }
    }
}