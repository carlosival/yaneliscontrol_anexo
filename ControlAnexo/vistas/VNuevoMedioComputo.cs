using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ControlAnexo.modelo;
using DevExpress.XtraEditors.Controls;

namespace ControlAnexo.vistas
{
    public partial class VNuevoMedioComputo : DevExpress.XtraEditors.XtraForm
    {
        public event EventHandler ComputerInsertado;
        List<DiscoDuro> listDiscosDuros; 

        public VNuevoMedioComputo()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            listDiscosDuros = new List<DiscoDuro>();
            this.usuarioTableAdapter1.Fill(this.bdanexoDataSet1.usuario);
            cbxNombreUsuario.DataSource = TodosUsuarios();

        }

        DiscoDuro GetSelectedDiscoDuro()
        {
            DiscoDuro dd = null;
            int[] selecteds = gridView1.GetSelectedRows();
            if (selecteds.Length > 0)
            {
                dd = new DiscoDuro();
                object row = gridView1.GetRow(selecteds[0]);
                dd.id  = ((DiscoDuro)(row)).id;
                dd.descripcion = ((DiscoDuro)(row)).descripcion;
                dd.capacidad = ((DiscoDuro)(row)).capacidad;
                dd.noserie = ((DiscoDuro)(row)).noserie;
                dd.estado = ((DiscoDuro)(row)).estado; 
            }
            return dd;
 
        }

        private void wizardControl1_NextClick(object sender, DevExpress.XtraWizard.WizardCommandButtonClickEventArgs e)
        {
            wpgaccesorios.AllowNext = false;
            wpgconfiguracion.AllowNext = false;
            wpgdiscoduro.AllowNext = false;
            wpgDisquete.AllowNext = false;
            wpgdvd.AllowNext = false;
            wpgequipo.AllowNext = false;
            wpgfax.AllowNext = false;
            wpgfotocopiadora.AllowNext = false;
            wpgimpresora.AllowNext = false;
            wpginsertar.AllowNext = false;
            wpgmoitor.AllowNext = false;
            wpgscaner.AllowNext = false;
            wpgseleccion.AllowNext = false;
            wpgswitch.AllowNext = false;
            wpgusuario.AllowNext = false;
            wpgbackup.AllowNext = false;

            ValidarBackup();
            ValidarAccesorios();
            ValidarConfiguracion();
            ValidarDiscoduro();
            ValidarDisquete();
            ValidarDVD();
            ValidarEquipo();
            ValidarFax();
            ValidarFotocopiadora();
            ValidarImpresora();
            ValidarMonitor();
            ValidarScaner();
            ValidarSeleccion();
            Validarswitch();
            ValidarUsuario();

            if (wizardControl1.SelectedPage == wpgseleccion)
            {
                if (checkseleccionar.SelectedItems.Count > 0)
                {
                    wpgseleccion.AllowNext = true;
                }
            }

            if (wizardControl1.SelectedPage == wpgdiscoduro)
            {
                if (listDiscosDuros.Count == 0)
                {
                    DiscoDuro dd = new DiscoDuro();
                    dd.descripcion = txtdiscodurodescrpcion.Text;
                    dd.capacidad = txtcapacidad.Text;
                    dd.noserie = txtdiscoduronoserie.Text;
                    listDiscosDuros.Add(dd);
                }
            }
        }

        private void ValidarBackup()
        {
            if (txtbackupmarca.Text != "" && txtbackupmodelo.Text != "" && txtbackupnoinv.Text != ""
              && txtbackupnoserie.Text != "")
                wpgbackup.AllowNext = true;
        }

        private void ValidarUsuario()
        {
            if (txtuser.Text != "" && cbxNombreUsuario.Text != "" && txtcorreo.Text != "")
                wpgusuario.AllowNext = true;
        }

        private void Validarswitch()
        {
            if (txtswitchmodelo.Text != "" && txtswitchnoinv.Text != "" && txtswitchnoserie.Text != ""
               && txtswitcmarca.Text != "")
                wpgswitch.AllowNext = true;
        }

        private void ValidarSeleccion()
        {
            if (checkseleccionar.SelectedItems.Count > 0)
            {
                wpgseleccion.AllowNext = true;
            }
        }
       
        private void ValidarScaner()
        {
            if (txtscanermarca.Text != "" && txtscanermodelo.Text != "" && txtscanernoinv.Text != ""
              && txtscanernoserie.Text != "")
                wpgscaner.AllowNext = true;
        }

        private void ValidarMonitor()
        {
            if (txtmonitormarca.Text != "" && txtmonitormodelo.Text != "" && txtmonitornoinv.Text != ""
               && txtmonitornoserie.Text != "")
                wpgmoitor.AllowNext = true;
        }

        private void ValidarImpresora()
        {
            if (txtimpresoramarca.Text != "" && txtimpresoranoserie.Text != "" && txtimpresoramodelo.Text != ""
                && txtimpresoramodelo.Text != "")
                wpgimpresora.AllowNext = true;
        }

        private void ValidarFotocopiadora()
        {
            if (txtfotocopiadoramarca.Text != "" && txtfotocopiadoranoinventario.Text != "" && txtfotocopiadoramodelo.Text != ""
                && txtfotocopiadoranoserie.Text != "")
                wpgfotocopiadora.AllowNext = true;
        }

        private void ValidarFax()
        {
            if (txtfaxmarca.Text != "" && txtfaxmodelo.Text != "" && txtfaxnoinv.Text != ""
               && txtfaxnoseie.Text != "")
                wpgfax.AllowNext = true;
        }

        private void ValidarEquipo()
        {
            if (txtnombreequipo.Text != "" && txtnoinvequipo.Text != ""
                && txtnoserieequipo.Text != "" && txtdominiored.Text != "")
                wpgequipo.AllowNext = true;
        }

        private void ValidarDVD()
        {
            if (txtcddescripcion.Text != "" && txtcdnoserie.Text != "")
                wpgdvd.AllowNext = true;
        }

        private void ValidarDisquete()
        {
            if (txtdescripciondisquete.Text != "" && txtdisquetenoserie.Text != "")
                wpgDisquete.AllowNext = true;
        }

        private void ValidarDiscoduro()
        {
            if (txtdiscodurodescrpcion.Text != "" && txtdiscoduronoserie.Text != "" &&
                txtcapacidad.Text != "")
                wpgdiscoduro.AllowNext = true;
        }

        private void ValidarConfiguracion()
        {
            if (txtplacabase.Text != "" && txtprocesador.Text != "" && txtmemoria.Text != "" &&
                txtnoserieconfig.Text != "" && txtvelocidad.Text != "" && txtcantidadconfiguracion.Text != ""
                 && txttarjetagrafica.Text != "" && txttarjetasonido.Text != "" &&
                txttarjetared.Text != "")
            {
                wpgconfiguracion.AllowNext = true;
            }
        }

        private void ValidarAccesorios()
        {
            if (txtteclado.Text != "" && txtraton.Text != "" && txtbocinas.Text != "")
                wpgaccesorios.AllowNext = true;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            bdanexoDataSet.usuarioDataTable user = usuarioTableAdapter1.UsuarioByUser(txtuser.Text);
            usuarioTableAdapter1.Fill(bdanexoDataSet1.usuario);
            if (user.Rows.Count == 0)
            {
                usuarioTableAdapter1.Insert(txtuser.Text, txtcorreo.Text, txtarea.Text, cbxNombreUsuario.Text);
            }
            else
            {
                usuarioTableAdapter1.Update(txtuser.Text, txtcorreo.Text, txtarea.Text, cbxNombreUsuario.Text, ((bdanexoDataSet.usuarioRow)user.Rows[0]).Id,
                    ((bdanexoDataSet.usuarioRow)user.Rows[0]).usuario, ((bdanexoDataSet.usuarioRow)user.Rows[0]).correo, ((bdanexoDataSet.usuarioRow)user.Rows[0]).area,
                    ((bdanexoDataSet.usuarioRow)user.Rows[0]).nombreusuario);
            }

            usuarioTableAdapter1.Update(bdanexoDataSet1.usuario);
            usuarioTableAdapter1.Fill(bdanexoDataSet1.usuario);

            int? idcliente = usuarioTableAdapter1.IdUltimoPedidoInsertado();

            expedienteTableAdapter1.Fill(bdanexoDataSet1.expediente);
            expedienteTableAdapter1.Insert(idcliente);
            expedienteTableAdapter1.Update(bdanexoDataSet1.expediente);
            expedienteTableAdapter1.Fill(bdanexoDataSet1.expediente); 

            int? idexpediente = expedienteTableAdapter1.IdUltimoExpedienteInsertado();

            if (wpgequipo.Visible == true)
                {
                equipoTableAdapter1.Fill(bdanexoDataSet1.equipo);
                equipoTableAdapter1.Insert(txtnoinvequipo.Text, txtnoserieequipo.Text, memoobservaciones.Text, txtdominiored.Text, txtnombreequipo.Text, cbxestadodd.Text, idexpediente);
                equipoTableAdapter1.Update(bdanexoDataSet1.equipo);
                equipoTableAdapter1.Fill(bdanexoDataSet1.equipo);

            }
            if (wpgconfiguracion.Visible == true)
            {
                configuracionTableAdapter1.Fill(bdanexoDataSet1.configuracion);
                configuracionTableAdapter1.Insert(txtplacabase.Text, txtnoserieconfig.Text, txtcantidadconfiguracion.Text, txtmemoria.Text, txtvelocidad.Text, txtprocesador.Text, txttarjetared.Text, txttarjetasonido.Text, txttarjetagrafica.Text,txtnoinvequipo.Text, idexpediente);
                configuracionTableAdapter1.Update(bdanexoDataSet1.configuracion);
                configuracionTableAdapter1.Fill(bdanexoDataSet1.configuracion);
            }

            if (wpgaccesorios.Visible == true)
            {
                accesoriosTableAdapter1.Fill(bdanexoDataSet1.accesorios);
                accesoriosTableAdapter1.Insert(txtteclado.Text, txtraton.Text, txtbocinas.Text,cbxestadoteclado.Text, idexpediente, cbxestadobocinas.Text, cbxestadobocinas.Text);
                accesoriosTableAdapter1.Update(bdanexoDataSet1.accesorios);
                accesoriosTableAdapter1.Fill(bdanexoDataSet1.accesorios);
            }

            if (wpgdiscoduro.Visible == true)
            {
                InsertarDiscoDuro(idexpediente);
            }

            if (wpgdvd.Visible == true)
            {
                cdroomTableAdapter1.Fill(bdanexoDataSet1.cdroom);
                cdroomTableAdapter1.Insert(txtcddescripcion.Text, txtcdnoserie.Text, cbxestadocd.Text, idexpediente);
                cdroomTableAdapter1.Update(bdanexoDataSet1.cdroom);
                cdroomTableAdapter1.Fill(bdanexoDataSet1.cdroom);

            }
            if (wpgDisquete.Visible == true)
            {
                disqueteTableAdapter1.Fill(bdanexoDataSet1.disquete);
                disqueteTableAdapter1.Insert(txtdescripciondisquete.Text, txtdisquetenoserie.Text,cbxestadodisq.Text,idexpediente);
                disqueteTableAdapter1.Update(bdanexoDataSet1.disquete);
                disqueteTableAdapter1.Fill(bdanexoDataSet1.disquete);
            }

            if (wpgimpresora.Visible == true)
            {
                impresoraTableAdapter1.Fill(bdanexoDataSet1.impresora);
                impresoraTableAdapter1.Insert(txtimpresoramodelo.Text, txtimpresoranoserie.Text, txtimpresoranoinventario.Text, txtimpresoramarca.Text, cbxestadoimpresora.Text, idexpediente);
                impresoraTableAdapter1.Update(bdanexoDataSet1.impresora);
                impresoraTableAdapter1.Fill(bdanexoDataSet1.impresora);
            }

            if (wpgbackup.Visible == true)
            {
                upsTableAdapter1.Fill(bdanexoDataSet1.ups);
                upsTableAdapter1.Insert(txtbackupmarca.Text, txtbackupnoserie.Text, txtbackupnoinv.Text, txtbackupmodelo.Text, cbxestadoups.Text, idexpediente);
                upsTableAdapter1.Update(bdanexoDataSet1.ups);
                upsTableAdapter1.Fill(bdanexoDataSet1.ups);
            }

            if (wpgmoitor.Visible == true)
            {
                monitorTableAdapter1.Fill(bdanexoDataSet1.monitor);
                monitorTableAdapter1.Insert(txtmonitormarca.Text, txtmonitormodelo.Text, txtmonitornoserie.Text, txtmonitornoinv.Text, cbxestadomonitor.Text, idexpediente);
                monitorTableAdapter1.Update(bdanexoDataSet1.monitor);
                monitorTableAdapter1.Fill(bdanexoDataSet1.monitor);
            }

            if (wpgfotocopiadora.Visible == true)
            {
                fotocopiadoraTableAdapter1.Fill(bdanexoDataSet1.fotocopiadora);
                fotocopiadoraTableAdapter1.Insert(txtfotocopiadoramarca.Text, txtfotocopiadoramodelo.Text, txtimpresoranoserie.Text, txtfotocopiadoranoinventario.Text, cbxestadofotocopiadora.Text, idexpediente);
                fotocopiadoraTableAdapter1.Update(bdanexoDataSet1.fotocopiadora);
                fotocopiadoraTableAdapter1.Fill(bdanexoDataSet1.fotocopiadora);
            }

            if (wpgfax.Visible == true)
            {
                faxTableAdapter1.Fill(bdanexoDataSet1.fax);
                faxTableAdapter1.Insert(txtfaxmarca.Text, txtfaxmodelo.Text, txtfaxnoseie.Text, txtfaxnoinv.Text, cbxestadofax.Text, idexpediente);
                faxTableAdapter1.Update(bdanexoDataSet1.fax);
                faxTableAdapter1.Fill(bdanexoDataSet1.fax);
            }


            if (wpgswitch.Visible == true)
            {
                switchTableAdapter1.Fill(bdanexoDataSet1._switch);
                switchTableAdapter1.Insert(txtswitchmodelo.Text, txtswitcmarca.Text, txtswitchnoserie.Text, txtswitchnoinv.Text, cbxestadoswitch.Text, idexpediente);
                switchTableAdapter1.Update(bdanexoDataSet1._switch);
                switchTableAdapter1.Fill(bdanexoDataSet1._switch);
            }

            if (wpgscaner.Visible == true)
            {
                escannerTableAdapter1.Fill(bdanexoDataSet1.escanner);
                escannerTableAdapter1.Insert(txtscanermarca.Text, txtscanermodelo.Text, txtscanernoserie.Text, txtscanernoinv.Text,idcliente,cbxestadoscaner.Text, idexpediente);
                escannerTableAdapter1.Update(bdanexoDataSet1.escanner);
                escannerTableAdapter1.Fill(bdanexoDataSet1.escanner);
            }

        }

        private void InsertarDiscoDuro(int? idexpediente)
        {
                if (listDiscosDuros.Count > 0)
                {
                    foreach (var item in listDiscosDuros)
                    {
                        discoduroTableAdapter1.Fill(bdanexoDataSet1.discoduro);
                        discoduroTableAdapter1.Insert(item.capacidad, item.noserie, item.descripcion, cbxestadodd.Text, idexpediente);
                        discoduroTableAdapter1.Update(bdanexoDataSet1.discoduro);
                        discoduroTableAdapter1.Fill(bdanexoDataSet1.discoduro);
                    }
                }
        }

        private void checkseleccionar_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            if (checkseleccionar.SelectedItems.Count > 0)
            {
                wpgseleccion.AllowNext = true;
            }

            if ((((CheckedListBoxItem)checkseleccionar.GetItem(0)).CheckState == CheckState.Checked))
            {
                wpgconfiguracion.Visible = true;
            }
            if ((((CheckedListBoxItem)checkseleccionar.GetItem(1)).CheckState == CheckState.Checked))
            {
                wpgdiscoduro.Visible = true;
            }
            if ((((CheckedListBoxItem)checkseleccionar.GetItem(2)).CheckState == CheckState.Checked))
            {
                wpgaccesorios.Visible = true;
            }
            if ((((CheckedListBoxItem)checkseleccionar.GetItem(3)).CheckState == CheckState.Checked))
            {
                wpgmoitor.Visible = true;
            }
            if ((((CheckedListBoxItem)checkseleccionar.GetItem(4)).CheckState == CheckState.Checked))
            {
                wpgbackup.Visible = true;
            }
            if ((((CheckedListBoxItem)checkseleccionar.GetItem(5)).CheckState == CheckState.Checked))
            {
                wpgimpresora.Visible = true;
            }
            if ((((CheckedListBoxItem)checkseleccionar.GetItem(6)).CheckState == CheckState.Checked))
            {
                wpgfotocopiadora.Visible = true;
            }
            if ((((CheckedListBoxItem)checkseleccionar.GetItem(7)).CheckState == CheckState.Checked))
            {
                wpgfax.Visible = true;
            }
            if ((((CheckedListBoxItem)checkseleccionar.GetItem(8)).CheckState == CheckState.Checked))
            {
                wpgswitch.Visible = true;
            }
            if ((((CheckedListBoxItem)checkseleccionar.GetItem(9)).CheckState == CheckState.Checked))
            {
                wpgscaner.Visible = true;
            }
            if ((((CheckedListBoxItem)checkseleccionar.GetItem(10)).CheckState == CheckState.Checked))
            {
                wpgDisquete.Visible = true;
            }
            if ((((CheckedListBoxItem)checkseleccionar.GetItem(11)).CheckState == CheckState.Checked))
            {
                wpgdvd.Visible = true;
            }
            if ((((CheckedListBoxItem)checkseleccionar.GetItem(0)).CheckState == CheckState.Unchecked))
            {
                wpgconfiguracion.Visible = false;
            }
            if ((((CheckedListBoxItem)checkseleccionar.GetItem(1)).CheckState == CheckState.Unchecked))
            {
                wpgdiscoduro.Visible = false;
            }
            if ((((CheckedListBoxItem)checkseleccionar.GetItem(2)).CheckState == CheckState.Unchecked))
            {
                wpgaccesorios.Visible = false;
            }
            if ((((CheckedListBoxItem)checkseleccionar.GetItem(3)).CheckState == CheckState.Unchecked))
            {
                wpgmoitor.Visible = false;
            }
            if ((((CheckedListBoxItem)checkseleccionar.GetItem(4)).CheckState == CheckState.Unchecked))
            {
                wpgbackup.Visible = false;
            }
            if ((((CheckedListBoxItem)checkseleccionar.GetItem(5)).CheckState == CheckState.Unchecked))
            {
                wpgimpresora.Visible = false;
            }
            if ((((CheckedListBoxItem)checkseleccionar.GetItem(6)).CheckState == CheckState.Unchecked))
            {
                wpgfotocopiadora.Visible = false;
            }
            if ((((CheckedListBoxItem)checkseleccionar.GetItem(7)).CheckState == CheckState.Unchecked))
            {
                wpgfax.Visible = false;
            }

            if ((((CheckedListBoxItem)checkseleccionar.GetItem(8)).CheckState == CheckState.Unchecked))
            {
                wpgswitch.Visible = false;
            }
            if ((((CheckedListBoxItem)checkseleccionar.GetItem(9)).CheckState == CheckState.Unchecked))
            {
                wpgscaner.Visible = false;
            }
            if ((((CheckedListBoxItem)checkseleccionar.GetItem(10)).CheckState == CheckState.Unchecked))
            {
                wpgDisquete.Visible = false;
            }
            if ((((CheckedListBoxItem)checkseleccionar.GetItem(11)).CheckState == CheckState.Unchecked))
            {
                wpgdvd.Visible = false;
            }
            if ((((CheckedListBoxItem)checkseleccionar.GetItem(0)).CheckState == CheckState.Unchecked) &&
                (((CheckedListBoxItem)checkseleccionar.GetItem(1)).CheckState == CheckState.Unchecked) &&
                (((CheckedListBoxItem)checkseleccionar.GetItem(2)).CheckState == CheckState.Unchecked) &&
                (((CheckedListBoxItem)checkseleccionar.GetItem(3)).CheckState == CheckState.Unchecked) &&
                (((CheckedListBoxItem)checkseleccionar.GetItem(4)).CheckState == CheckState.Unchecked) &&
                (((CheckedListBoxItem)checkseleccionar.GetItem(5)).CheckState == CheckState.Unchecked) &&
                (((CheckedListBoxItem)checkseleccionar.GetItem(6)).CheckState == CheckState.Unchecked) &&
                (((CheckedListBoxItem)checkseleccionar.GetItem(7)).CheckState == CheckState.Unchecked) &&
                (((CheckedListBoxItem)checkseleccionar.GetItem(8)).CheckState == CheckState.Unchecked) &&
                (((CheckedListBoxItem)checkseleccionar.GetItem(9)).CheckState == CheckState.Unchecked) &&
                (((CheckedListBoxItem)checkseleccionar.GetItem(10)).CheckState == CheckState.Unchecked) &&
                (((CheckedListBoxItem)checkseleccionar.GetItem(11)).CheckState == CheckState.Unchecked))
            {
                wpgseleccion.AllowNext = false;
            }
        }

        private void VNuevoMedioComputo_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (ComputerInsertado != null)
                ComputerInsertado(sender, null);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            DiscoDuro dd = new DiscoDuro();
            dd.descripcion = txtdiscodurodescrpcion.Text;
            dd.capacidad = txtcapacidad.Text;
            dd.noserie = txtdiscoduronoserie.Text;
            dd.estado = cbxestadodd.Text; 
            listDiscosDuros.Add(dd);

            txtdiscodurodescrpcion.Text = "";
            txtdiscoduronoserie.Text = "";
            txtcapacidad.Text = "";

            gridControlDD.DataSource = null;
            gridControlDD.DataSource = listDiscosDuros;
        }

        private void wizardControl1_SelectedPageChanged(object sender, DevExpress.XtraWizard.WizardPageChangedEventArgs e)
        {
            if (wizardControl1.SelectedPage == wpginsertar)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            wizardControl1.SelectedPage = completionWizardPage1;
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarUsuario();
            Validacion.ValidarSoloLetras(e);
        }

        private void txtuser_KeyUp(object sender, KeyEventArgs e)
        {
            ValidarUsuario();

        }

        private void txtcorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarUsuario();
            
        }

        private void txtnombreequipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarEquipo(); 
        }

        private void txtplacabase_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarConfiguracion();
        }

        private void txtdiscodurodescrpcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDiscoduro();
        }

        private void txtcddescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDVD();
        }

        private void txtdescripciondisquete_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDisquete();
        }

        private void txtteclado_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarAccesorios();
        }

        private void txtimpresoramarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarImpresora();
        }

        private void wpgfotocopiadora_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarFotocopiadora();
        }

        private void txtscanermarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarScaner();
        }

        private void txtbackupmarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarBackup();
        }

        private void txtfaxmarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarFax();
        }

        private void txtswitcmarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validarswitch();
        }

        private void txtmonitormarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarMonitor();
        }

        private void cbxNombreUsuario_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Return)
            {
                LlenarDatosUsuario();
            }
        }

        private void LlenarDatosUsuario()
        {
            // Necesito los datos del usuario en modelo logico
            if (cbxNombreUsuario.SelectedItem != null)
            {
                txtuser.Text = ((Usuario)cbxNombreUsuario. SelectedItem).usuario;
                txtcorreo.Text = ((Usuario)cbxNombreUsuario.SelectedItem).Correo;
                txtarea.Text = ((Usuario)cbxNombreUsuario.SelectedItem).Area;
            }
        }

        public List<Usuario> TodosUsuarios()
        {
            List<Usuario> listausuarios = new List<Usuario>();
            foreach (var item in bdanexoDataSet1.usuario.Rows)
            {
                Usuario newusuario = new Usuario();
                newusuario.UsuarioNombre = ((bdanexoDataSet.usuarioRow)item).nombreusuario;
                newusuario.Area = ((bdanexoDataSet.usuarioRow)item).area;
                newusuario.Correo = ((bdanexoDataSet.usuarioRow)item).correo;
                newusuario.usuario = ((bdanexoDataSet.usuarioRow)item).usuario;
                listausuarios.Add(newusuario);
            }
            return listausuarios;
        }

        private void cbxNombreUsuario_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LlenarDatosUsuario();
            ValidarUsuario();
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
            btnEditar.Enabled = false;
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            DiscoDuro dd = GetSelectedDiscoDuro();
            txtdiscodurodescrpcion.Text = dd.descripcion;
            txtdiscoduronoserie.Text = dd.noserie;
            txtcapacidad.Text = dd.capacidad;
            cbxestadodd.Text = dd.estado;
            btnEditar.Enabled = true; 
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


        private void checkEdit1_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkEdit1.Checked)
            {
                foreach (var item in checkseleccionar.Items)
                {
                    ((CheckedListBoxItem)item).CheckState = CheckState.Checked;
                }
            }
            else
            {
                foreach (var item in checkseleccionar.Items)
                {
                    ((CheckedListBoxItem)item).CheckState = CheckState.Unchecked;
                }
 
            }

        }
    }
}