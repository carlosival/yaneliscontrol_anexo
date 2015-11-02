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
    public partial class VNuevoUsuario : DevExpress.XtraEditors.XtraForm
    {
        private string p;

        public VNuevoUsuario()
        {
            InitializeComponent();
        }

        public VNuevoUsuario(string p)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.p = p;

            this.usuarioTableAdapter.Fill(this.bdanexoDataSet.usuario);
            cbxnombre.DataSource = TodosUsuarios();

        }

        private void VNuevoUsuario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bdanexoDataSet.usuario' table. You can move, or remove it, as needed.
            this.usuarioTableAdapter.Fill(this.bdanexoDataSet.usuario);


        }

        private void comboBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Return)
            {
                LlenarDatosUsuario();
            }
        }

        private void LlenarDatosUsuario()
        {
            // Necesito los datos del usuario en modelo logico
            if (cbxnombre.SelectedItem  != null)
            {
                txtuser.Text = ((Usuario)cbxnombre.SelectedItem).UsuarioNombre;
                txtcorreo.Text = ((Usuario)cbxnombre.SelectedItem).Correo;
                txtarea.Text = ((Usuario)cbxnombre.SelectedItem).Area;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bdanexoDataSet.usuarioDataTable usuario = usuarioTableAdapter.UsuarioById(Convert.ToInt16(p));
            if (usuario != null)
            {
                usuarioTableAdapter.Update(txtuser.Text,txtcorreo.Text, txtarea.Text,cbxnombre.Text,
                                            ((bdanexoDataSet.usuarioRow)usuario[0]).Id,
                                            ((bdanexoDataSet.usuarioRow)usuario[0]).usuario,
                                            ((bdanexoDataSet.usuarioRow)usuario[0]).correo,
                                            ((bdanexoDataSet.usuarioRow)usuario[0]).area,
                                            ((bdanexoDataSet.usuarioRow)usuario[0]).nombreusuario);
                usuarioTableAdapter.Update(bdanexoDataSet.usuario);
                usuarioTableAdapter.Fill(bdanexoDataSet.usuario);
            }
            else
            {
                usuarioTableAdapter.Insert(txtuser.Text,txtcorreo.Text, txtarea.Text, cbxnombre.Text); 
            }

            this.Close(); 

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public List<Usuario> TodosUsuarios()
        {
            List<Usuario> listausuarios = new List<Usuario>();
            foreach (var item in bdanexoDataSet.usuario.Rows)
            {
                Usuario newusuario = new Usuario();
                newusuario.UsuarioNombre = ((bdanexoDataSet.usuarioRow)item).usuario;
                newusuario.Area = ((bdanexoDataSet.usuarioRow)item).area;
                newusuario.Correo = ((bdanexoDataSet.usuarioRow)item).correo;

                listausuarios.Add(newusuario);
            }
            return listausuarios;

        }
    }
}