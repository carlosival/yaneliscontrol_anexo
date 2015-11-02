namespace ControlAnexo.vistas
{
    partial class VNuevoUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtarea = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtcorreo = new DevExpress.XtraEditors.TextEdit();
            this.txtuser = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnAceptar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.cbxnombre = new System.Windows.Forms.ComboBox();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdanexoDataSet = new ControlAnexo.bdanexoDataSet();
            this.usuarioTableAdapter = new ControlAnexo.bdanexoDataSetTableAdapters.usuarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.txtarea.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcorreo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtuser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdanexoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtarea
            // 
            this.txtarea.EditValue = "Area 9: Almacén de Insumo";
            this.txtarea.Location = new System.Drawing.Point(94, 129);
            this.txtarea.Name = "txtarea";
            this.txtarea.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtarea.Properties.Items.AddRange(new object[] {
            "Area 9: Almacén de Insumo",
            "Area 11:Area Depósito AFT",
            "Area 15: Caja",
            "Area 16:Departamento de Contabilidad",
            "Area 17:Direccion General",
            "Area 18: Direccion de Economia",
            "Area 19: Area Jefe de Recursos Humanos",
            "Area 20: Departamento de Recurso Humanos",
            "Area 21: Oficina de Cuadro",
            "Area 22: Auditoria",
            "Area 23: Oficina  Juridico",
            "Area 25: Direccion de Desarrollo Empresarial",
            "Area 26: Economia Archivo ",
            "Area 28:Secretaria de la Direccion general",
            "Area 30: Salon de Reuniones",
            "Area 32: Direccion Tecnica",
            "Area 34: Direccion Tecnica 2",
            "Area 35: Oficina Griñam",
            "Area 40: Seguridad y Proteccion",
            "Area 43: Administracion Interna Direccion",
            ""});
            this.txtarea.Size = new System.Drawing.Size(428, 20);
            this.txtarea.TabIndex = 24;
            // 
            // txtcorreo
            // 
            this.txtcorreo.Location = new System.Drawing.Point(94, 103);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Properties.Mask.EditMask = "p3";
            this.txtcorreo.Size = new System.Drawing.Size(428, 20);
            this.txtcorreo.TabIndex = 23;
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(94, 77);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(428, 20);
            this.txtuser.TabIndex = 22;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(37, 132);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(27, 13);
            this.labelControl5.TabIndex = 21;
            this.labelControl5.Text = "Area:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(37, 106);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(37, 13);
            this.labelControl4.TabIndex = 20;
            this.labelControl4.Text = "Correo:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(37, 80);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 13);
            this.labelControl2.TabIndex = 19;
            this.labelControl2.Text = "Usuario:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(37, 50);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 13);
            this.labelControl1.TabIndex = 18;
            this.labelControl1.Text = "Nombre:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(13, 13);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(522, 13);
            this.labelControl3.TabIndex = 25;
            this.labelControl3.Text = "Para eliminar este usuario, debe especificar cual  es el nuevo usuario responsabl" +
                "e de los medios informáticos.";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(366, 165);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 26;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(447, 165);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 27;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cbxnombre
            // 
            this.cbxnombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbxnombre.DataSource = this.usuarioBindingSource;
            this.cbxnombre.DisplayMember = "UsuarioNombre";
            this.cbxnombre.ForeColor = System.Drawing.Color.Black;
            this.cbxnombre.FormattingEnabled = true;
            this.cbxnombre.Location = new System.Drawing.Point(94, 50);
            this.cbxnombre.Name = "cbxnombre";
            this.cbxnombre.Size = new System.Drawing.Size(428, 21);
            this.cbxnombre.TabIndex = 28;
            this.cbxnombre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.comboBox1_KeyUp);
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(ControlAnexo.modelo.Usuario);
            // 
            // bdanexoDataSet
            // 
            this.bdanexoDataSet.DataSetName = "bdanexoDataSet";
            this.bdanexoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // VNuevoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 214);
            this.Controls.Add(this.cbxnombre);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtarea);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VNuevoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nuevo Usuario";
            this.Load += new System.EventHandler(this.VNuevoUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtarea.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcorreo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtuser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdanexoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit txtarea;
        private DevExpress.XtraEditors.TextEdit txtcorreo;
        private DevExpress.XtraEditors.TextEdit txtuser;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnAceptar;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private System.Windows.Forms.ComboBox cbxnombre;
        private bdanexoDataSet bdanexoDataSet;
        private bdanexoDataSetTableAdapters.usuarioTableAdapter usuarioTableAdapter;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
    }
}