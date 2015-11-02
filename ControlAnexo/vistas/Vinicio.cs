using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using ControlAnexo.modeloanexo4;
using ControlAnexo.modelo;

namespace ControlAnexo.vistas
{
    public partial class Vinicio : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Vinicio()
        {
            showSplashScreen();

            InitializeComponent();

            expedienteTableAdapter1.Fill(bdanexoDataSet.expediente); 

            gridExp.DataSource = TodosExpedientes();
            gridExp.Visible = true;
            gridExp.Dock = DockStyle.Fill;
            gridViewExp.GroupPanelText = "Expedientes";
            gridViewUsuario.GroupPanelText = "Usuarios";
            gridViewEquipo.GroupPanelText = "Medios Informáticos"; 
        }

        private void showSplashScreen()
        {
            using (VSplashScreen fsplash = new VSplashScreen())
            {
                if (fsplash.ShowDialog() == System.Windows.Forms.DialogResult.Cancel) this.Close();
            }
        }

        public List<Expediente> TodosExpedientes()
        {
            List<Expediente> luistexp = new List<Expediente>();
            
            expedienteTableAdapter1.Fill(bdanexoDataSet.expediente);
            

            foreach (var item in bdanexoDataSet.expediente.Rows)
            {
                Expediente exp = new Expediente();
                exp.id = ((bdanexoDataSet.expedienteRow)item).Id.ToString();
                bdanexoDataSet.usuarioDataTable usuario = usuarioTableAdapter1.UsuarioById(((bdanexoDataSet.expedienteRow)item).idusuario);
               
                if (usuario.Rows.Count > 0)
                {
                    exp.UsuarioNombre = ((bdanexoDataSet.usuarioRow)usuario.Rows[0]).nombreusuario;
                    exp.Area = ((bdanexoDataSet.usuarioRow)usuario.Rows[0]).area;
                }

                this.equipoTableAdapter1.Fill(this.bdanexoDataSet.equipo);
                bdanexoDataSet.equipoDataTable equipo = equipoTableAdapter1.GetEquipoByUsuario(((bdanexoDataSet.expedienteRow)item).Id);
                if (equipo.Rows.Count > 0)
                {
                    exp.noinventario = ((bdanexoDataSet.equipoRow)equipo.Rows[0]).noinventario;
                    exp.nombre = ((bdanexoDataSet.equipoRow)equipo.Rows[0]).nombre;
                    exp.noserie = ((bdanexoDataSet.equipoRow)equipo.Rows[0]).noserie;
                    exp.estado = ((bdanexoDataSet.equipoRow)equipo.Rows[0]).estado;
                }

                luistexp.Add(exp); 
            }

            return luistexp;
        }

       
        
        private void RibbonHome_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bdanexoDataSet.usuario' table. You can move, or remove it, as needed.
            this.usuarioTableAdapter1.Fill(this.bdanexoDataSet.usuario);
        }

        private string GetSelectedIdUsuario()
        {
            int[] selecteds = gridViewUsuario.GetSelectedRows();
            object row = gridViewUsuario.GetRow(selecteds[0]);

            string id = ((System.Data.DataRowView)(row)).Row.ItemArray[0].ToString();
            return id;
        }

        private string GetSelectedIdExpediente()
        {
            int[] selecteds = gridViewExp.GetSelectedRows();
            object row = gridViewExp.GetRow(selecteds[0]);

            string id = ((Expediente)(row)).id.ToString();
            return id;
        }

        private string GetSelectedIdPcs()
        {
            int[] selecteds = gridViewEquipo.GetSelectedRows();
            object row = gridViewEquipo.GetRow(selecteds[0]);

            string id = ((System.Data.DataRowView)(row)).Row.ItemArray[0].ToString();
            return id;
        }


        private void btnFacturar_ItemClick(object sender, ItemClickEventArgs e)
        {
            VReporte report = new VReporte(GetSelectedIdExpediente());
            report.ShowDialog();

            //string id = GetSelectedIdExpediente();
            //anexoReport report = new anexoReport(id);
            //report.ExportToPdf("D:/Sistema para el Control de los Medios Informáticos/Expedientes/Expediente " + id + ".pdf");
            //report.CreateDocument(); 
            
            
        }

        private void btnNuevo_ItemClick(object sender, ItemClickEventArgs e)
        {
            VNuevoMedioComputo formNewComputer = new VNuevoMedioComputo();
            formNewComputer.ComputerInsertado += new EventHandler(formNewComputer_ComputerInsertado);
            formNewComputer.ShowDialog();
        }

        void formNewComputer_ComputerInsertado(object sender, EventArgs e)
        {
            RefrescarGridusuarios();
            RefrescarGridExpedientes();
            RefrescarGridPCs(); 
        }

        private void RefrescarGridusuarios()
        {
            this.usuarioTableAdapter1.Fill(this.bdanexoDataSet.usuario);
            gridUsuarios.DataSource = usuarioTableAdapter1;
        }

        private void btnActualizar_ItemClick(object sender, ItemClickEventArgs e)
        {
            VActualizarDatos form = new VActualizarDatos( GetSelectedIdExpediente());
            form.ActualizacionDatos += new EventHandler(form_ActualizacionDatos);
            form.ShowDialog();
        }

        void form_ActualizacionDatos(object sender, EventArgs e)
        {
            this.usuarioTableAdapter1.Fill(this.bdanexoDataSet.usuario);
            this.equipoTableAdapter1.Fill(this.bdanexoDataSet.equipo);
            this.expedienteTableAdapter1.Fill(this.bdanexoDataSet.expediente); 

            RefrescarGridusuarios();
            RefrescarGridExpedientes();
            RefrescarGridPCs(); 

        }

        private void RefrescarGridExpedientes()
        {

            gridExp.DataSource = null;
            gridExp.DataSource = TodosExpedientes(); 
        }

        private void btnRefrescar_ItemClick(object sender, ItemClickEventArgs e)
        {
            RefrescarGridusuarios();
            RefrescarGridExpedientes();
            RefrescarGridPCs(); 
        }

        private void RefrescarGridPCs()
        {
            this.equipoTableAdapter1.Fill(this.bdanexoDataSet.equipo);
            gridPCs.DataSource = equipoTableAdapter1;
        }

        private void btnVerUsuarios_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridUsuarios.Visible = true;
            gridUsuarios.Dock = DockStyle.Fill;

            gridPCs.Visible = false;
            gridExp.Visible = false;
            btnActualizar.Enabled = false;
            btnFacturar.Enabled = false; 
        }

        private void btnVerPcs_ItemClick(object sender, ItemClickEventArgs e)
        {

            gridPCs.Visible = true;
            gridPCs.Dock = DockStyle.Fill;

            gridUsuarios.Visible = false;
            gridExp.Visible = false;
            btnActualizar.Enabled = false;
            btnFacturar.Enabled = false; 
        }

        private void btnVerExp_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridExp.Visible = true;
            gridExp.Dock = DockStyle.Fill;
            btnActualizar.Enabled = true;
            btnFacturar.Enabled = true; 

            gridUsuarios.Visible = false;
            gridPCs.Visible = false;
        }

        private void btnControl_ItemClick(object sender, ItemClickEventArgs e)
        {
            VTotalReporte report = new VTotalReporte();
            report.ShowDialog();
        }

      
    }
}