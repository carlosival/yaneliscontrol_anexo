namespace ControlAnexo.vistas
{
    partial class Vinicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vinicio));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnComputadora = new DevExpress.XtraBars.BarButtonItem();
            this.btnUsuario = new DevExpress.XtraBars.BarButtonItem();
            this.btnFacturar = new DevExpress.XtraBars.BarButtonItem();
            this.btnNuevo = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefrescar = new DevExpress.XtraBars.BarButtonItem();
            this.btnTotalComputadoras = new DevExpress.XtraBars.BarButtonItem();
            this.btnActualizar = new DevExpress.XtraBars.BarButtonItem();
            this.btnVerUsuarios = new DevExpress.XtraBars.BarButtonItem();
            this.btnVerPcs = new DevExpress.XtraBars.BarButtonItem();
            this.btnVerExp = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.gridUsuarios = new DevExpress.XtraGrid.GridControl();
            this.usuarioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bdanexoDataSet = new ControlAnexo.bdanexoDataSet();
            this.gridViewUsuario = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colusuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcorreo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colarea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombreusuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.configuracionTableAdapter1 = new ControlAnexo.bdanexoDataSetTableAdapters.configuracionTableAdapter();
            this.equipoTableAdapter1 = new ControlAnexo.bdanexoDataSetTableAdapters.equipoTableAdapter();
            this.accesoriosTableAdapter1 = new ControlAnexo.bdanexoDataSetTableAdapters.accesoriosTableAdapter();
            this.cdroomTableAdapter1 = new ControlAnexo.bdanexoDataSetTableAdapters.cdroomTableAdapter();
            this.monitorTableAdapter1 = new ControlAnexo.bdanexoDataSetTableAdapters.monitorTableAdapter();
            this.discoduroTableAdapter1 = new ControlAnexo.bdanexoDataSetTableAdapters.discoduroTableAdapter();
            this.gridPCs = new DevExpress.XtraGrid.GridControl();
            this.equipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewEquipo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnoinventario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnoserie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridExp = new DevExpress.XtraGrid.GridControl();
            this.expedienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewExp = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colArea1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuarioNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnoinventario1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnoserie1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.expedienteTableAdapter1 = new ControlAnexo.bdanexoDataSetTableAdapters.expedienteTableAdapter();
            this.usuarioTableAdapter1 = new ControlAnexo.bdanexoDataSetTableAdapters.usuarioTableAdapter();
            this.btnControl = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdanexoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPCs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEquipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridExp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expedienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewExp)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnComputadora,
            this.btnUsuario,
            this.btnFacturar,
            this.btnNuevo,
            this.btnRefrescar,
            this.btnTotalComputadoras,
            this.btnActualizar,
            this.btnVerUsuarios,
            this.btnVerPcs,
            this.btnVerExp,
            this.btnControl});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 16;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.Size = new System.Drawing.Size(1040, 144);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnComputadora
            // 
            this.btnComputadora.Caption = "Computadora";
            this.btnComputadora.Id = 2;
            this.btnComputadora.Name = "btnComputadora";
            // 
            // btnUsuario
            // 
            this.btnUsuario.Caption = "Usuario";
            this.btnUsuario.Id = 3;
            this.btnUsuario.Name = "btnUsuario";
            // 
            // btnFacturar
            // 
            this.btnFacturar.Caption = "Generar";
            this.btnFacturar.Id = 4;
            this.btnFacturar.LargeGlyph = global::ControlAnexo.Properties.Resources.Album_32x32;
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFacturar_ItemClick);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Caption = "Nuevo";
            this.btnNuevo.Id = 5;
            this.btnNuevo.LargeGlyph = global::ControlAnexo.Properties.Resources.AddFile_32x32;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNuevo_ItemClick);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Caption = "Refrescar";
            this.btnRefrescar.Id = 6;
            this.btnRefrescar.LargeGlyph = global::ControlAnexo.Properties.Resources.GenerateData_32x32;
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefrescar_ItemClick);
            // 
            // btnTotalComputadoras
            // 
            this.btnTotalComputadoras.Caption = "Informe general";
            this.btnTotalComputadoras.Id = 7;
            this.btnTotalComputadoras.LargeGlyph = global::ControlAnexo.Properties.Resources.Other_32x32;
            this.btnTotalComputadoras.Name = "btnTotalComputadoras";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Caption = "Actualizar";
            this.btnActualizar.Id = 9;
            this.btnActualizar.LargeGlyph = global::ControlAnexo.Properties.Resources.PageOrientationPortrait;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnActualizar_ItemClick);
            // 
            // btnVerUsuarios
            // 
            this.btnVerUsuarios.Caption = "Usuarios";
            this.btnVerUsuarios.Id = 11;
            this.btnVerUsuarios.LargeGlyph = global::ControlAnexo.Properties.Resources.Profile;
            this.btnVerUsuarios.Name = "btnVerUsuarios";
            this.btnVerUsuarios.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnVerUsuarios_ItemClick);
            // 
            // btnVerPcs
            // 
            this.btnVerPcs.Caption = "Medios Informáticos";
            this.btnVerPcs.Id = 13;
            this.btnVerPcs.LargeGlyph = global::ControlAnexo.Properties.Resources.My_Computer;
            this.btnVerPcs.Name = "btnVerPcs";
            this.btnVerPcs.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnVerPcs_ItemClick);
            // 
            // btnVerExp
            // 
            this.btnVerExp.Caption = "Expedientes";
            this.btnVerExp.Id = 14;
            this.btnVerExp.LargeGlyph = global::ControlAnexo.Properties.Resources.NewAlbum_32x32;
            this.btnVerExp.Name = "btnVerExp";
            this.btnVerExp.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnVerExp_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Inicio";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNuevo);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnActualizar);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnFacturar);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnRefrescar);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Expedientes";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnVerPcs);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnVerExp);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnVerUsuarios);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnControl);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Ver";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 634);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1040, 31);
            // 
            // gridUsuarios
            // 
            this.gridUsuarios.DataSource = this.usuarioBindingSource1;
            this.gridUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridUsuarios.Location = new System.Drawing.Point(0, 144);
            this.gridUsuarios.MainView = this.gridViewUsuario;
            this.gridUsuarios.MenuManager = this.ribbon;
            this.gridUsuarios.Name = "gridUsuarios";
            this.gridUsuarios.Size = new System.Drawing.Size(1040, 490);
            this.gridUsuarios.TabIndex = 2;
            this.gridUsuarios.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewUsuario});
            this.gridUsuarios.Visible = false;
            // 
            // usuarioBindingSource1
            // 
            this.usuarioBindingSource1.DataMember = "usuario";
            this.usuarioBindingSource1.DataSource = this.bdanexoDataSet;
            // 
            // bdanexoDataSet
            // 
            this.bdanexoDataSet.DataSetName = "bdanexoDataSet";
            this.bdanexoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewUsuario
            // 
            this.gridViewUsuario.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colusuario,
            this.colcorreo,
            this.colarea,
            this.colnombreusuario});
            this.gridViewUsuario.GridControl = this.gridUsuarios;
            this.gridViewUsuario.Name = "gridViewUsuario";
            this.gridViewUsuario.OptionsBehavior.Editable = false;
            // 
            // colusuario
            // 
            this.colusuario.Caption = "Usuario";
            this.colusuario.FieldName = "usuario";
            this.colusuario.Name = "colusuario";
            this.colusuario.Visible = true;
            this.colusuario.VisibleIndex = 1;
            // 
            // colcorreo
            // 
            this.colcorreo.Caption = "Correo";
            this.colcorreo.FieldName = "correo";
            this.colcorreo.Name = "colcorreo";
            this.colcorreo.Visible = true;
            this.colcorreo.VisibleIndex = 2;
            // 
            // colarea
            // 
            this.colarea.Caption = "Area";
            this.colarea.FieldName = "area";
            this.colarea.Name = "colarea";
            this.colarea.Visible = true;
            this.colarea.VisibleIndex = 3;
            // 
            // colnombreusuario
            // 
            this.colnombreusuario.Caption = "Nombre";
            this.colnombreusuario.FieldName = "nombreusuario";
            this.colnombreusuario.Name = "colnombreusuario";
            this.colnombreusuario.Visible = true;
            this.colnombreusuario.VisibleIndex = 0;
            // 
            // configuracionTableAdapter1
            // 
            this.configuracionTableAdapter1.ClearBeforeFill = true;
            // 
            // equipoTableAdapter1
            // 
            this.equipoTableAdapter1.ClearBeforeFill = true;
            // 
            // accesoriosTableAdapter1
            // 
            this.accesoriosTableAdapter1.ClearBeforeFill = true;
            // 
            // cdroomTableAdapter1
            // 
            this.cdroomTableAdapter1.ClearBeforeFill = true;
            // 
            // monitorTableAdapter1
            // 
            this.monitorTableAdapter1.ClearBeforeFill = true;
            // 
            // discoduroTableAdapter1
            // 
            this.discoduroTableAdapter1.ClearBeforeFill = true;
            // 
            // gridPCs
            // 
            this.gridPCs.DataSource = this.equipoBindingSource;
            this.gridPCs.Location = new System.Drawing.Point(27, 218);
            this.gridPCs.MainView = this.gridViewEquipo;
            this.gridPCs.MenuManager = this.ribbon;
            this.gridPCs.Name = "gridPCs";
            this.gridPCs.Size = new System.Drawing.Size(565, 200);
            this.gridPCs.TabIndex = 5;
            this.gridPCs.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewEquipo});
            this.gridPCs.Visible = false;
            // 
            // equipoBindingSource
            // 
            this.equipoBindingSource.DataMember = "equipo";
            this.equipoBindingSource.DataSource = this.bdanexoDataSet;
            // 
            // gridViewEquipo
            // 
            this.gridViewEquipo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colnoinventario,
            this.colnoserie,
            this.colnombre,
            this.colestado});
            this.gridViewEquipo.GridControl = this.gridPCs;
            this.gridViewEquipo.Name = "gridViewEquipo";
            this.gridViewEquipo.OptionsBehavior.Editable = false;
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Width = 43;
            // 
            // colnoinventario
            // 
            this.colnoinventario.Caption = "No Inv.";
            this.colnoinventario.FieldName = "noinventario";
            this.colnoinventario.Name = "colnoinventario";
            this.colnoinventario.Visible = true;
            this.colnoinventario.VisibleIndex = 0;
            this.colnoinventario.Width = 100;
            // 
            // colnoserie
            // 
            this.colnoserie.Caption = "No Serie";
            this.colnoserie.FieldName = "noserie";
            this.colnoserie.Name = "colnoserie";
            this.colnoserie.Visible = true;
            this.colnoserie.VisibleIndex = 1;
            this.colnoserie.Width = 100;
            // 
            // colnombre
            // 
            this.colnombre.Caption = "Nombre";
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 2;
            this.colnombre.Width = 100;
            // 
            // colestado
            // 
            this.colestado.Caption = "Estado";
            this.colestado.FieldName = "estado";
            this.colestado.Name = "colestado";
            this.colestado.Visible = true;
            this.colestado.VisibleIndex = 3;
            this.colestado.Width = 104;
            // 
            // gridExp
            // 
            this.gridExp.DataSource = this.expedienteBindingSource;
            this.gridExp.Location = new System.Drawing.Point(598, 218);
            this.gridExp.MainView = this.gridViewExp;
            this.gridExp.MenuManager = this.ribbon;
            this.gridExp.Name = "gridExp";
            this.gridExp.Size = new System.Drawing.Size(362, 240);
            this.gridExp.TabIndex = 8;
            this.gridExp.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewExp});
            this.gridExp.Visible = false;
            // 
            // expedienteBindingSource
            // 
            this.expedienteBindingSource.DataSource = typeof(ControlAnexo.modelo.Expediente);
            // 
            // gridViewExp
            // 
            this.gridViewExp.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colArea1,
            this.colUsuarioNombre,
            this.colnoinventario1,
            this.colnoserie1,
            this.colnombre1,
            this.colestado1,
            this.colid1});
            this.gridViewExp.GridControl = this.gridExp;
            this.gridViewExp.Name = "gridViewExp";
            this.gridViewExp.OptionsBehavior.Editable = false;
            // 
            // colArea1
            // 
            this.colArea1.FieldName = "Area";
            this.colArea1.Name = "colArea1";
            this.colArea1.Visible = true;
            this.colArea1.VisibleIndex = 5;
            // 
            // colUsuarioNombre
            // 
            this.colUsuarioNombre.Caption = "Usuario";
            this.colUsuarioNombre.FieldName = "UsuarioNombre";
            this.colUsuarioNombre.Name = "colUsuarioNombre";
            this.colUsuarioNombre.Visible = true;
            this.colUsuarioNombre.VisibleIndex = 4;
            // 
            // colnoinventario1
            // 
            this.colnoinventario1.Caption = "No Inv.";
            this.colnoinventario1.FieldName = "noinventario";
            this.colnoinventario1.Name = "colnoinventario1";
            this.colnoinventario1.Visible = true;
            this.colnoinventario1.VisibleIndex = 2;
            // 
            // colnoserie1
            // 
            this.colnoserie1.Caption = "No. Serie";
            this.colnoserie1.FieldName = "noserie";
            this.colnoserie1.Name = "colnoserie1";
            this.colnoserie1.Visible = true;
            this.colnoserie1.VisibleIndex = 3;
            // 
            // colnombre1
            // 
            this.colnombre1.Caption = "Nombre PC";
            this.colnombre1.FieldName = "nombre";
            this.colnombre1.Name = "colnombre1";
            this.colnombre1.Visible = true;
            this.colnombre1.VisibleIndex = 1;
            // 
            // colestado1
            // 
            this.colestado1.Caption = "Estado";
            this.colestado1.FieldName = "estado";
            this.colestado1.Name = "colestado1";
            this.colestado1.Visible = true;
            this.colestado1.VisibleIndex = 6;
            // 
            // colid1
            // 
            this.colid1.Caption = "Id";
            this.colid1.FieldName = "id";
            this.colid1.Name = "colid1";
            this.colid1.Visible = true;
            this.colid1.VisibleIndex = 0;
            // 
            // expedienteTableAdapter1
            // 
            this.expedienteTableAdapter1.ClearBeforeFill = true;
            // 
            // usuarioTableAdapter1
            // 
            this.usuarioTableAdapter1.ClearBeforeFill = true;
            // 
            // btnControl
            // 
            this.btnControl.Caption = "Control de Medios";
            this.btnControl.Id = 15;
            this.btnControl.LargeGlyph = global::ControlAnexo.Properties.Resources.PageOrientationPortrait;
            this.btnControl.Name = "btnControl";
            this.btnControl.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnControl_ItemClick);
            // 
            // Vinicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 665);
            this.Controls.Add(this.gridExp);
            this.Controls.Add(this.gridPCs);
            this.Controls.Add(this.gridUsuarios);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Vinicio";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Sistema para el Control de los Medios Informáticos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RibbonHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdanexoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPCs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEquipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridExp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expedienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewExp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnComputadora;
        private DevExpress.XtraBars.BarButtonItem btnUsuario;
        private DevExpress.XtraGrid.GridControl gridUsuarios;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewUsuario;
        private bdanexoDataSet bdanexoDataSet;
        private DevExpress.XtraBars.BarButtonItem btnFacturar;
        private DevExpress.XtraBars.BarButtonItem btnNuevo;
        private bdanexoDataSetTableAdapters.configuracionTableAdapter configuracionTableAdapter1;
        private bdanexoDataSetTableAdapters.equipoTableAdapter equipoTableAdapter1;
        private bdanexoDataSetTableAdapters.accesoriosTableAdapter accesoriosTableAdapter1;
        private bdanexoDataSetTableAdapters.cdroomTableAdapter cdroomTableAdapter1;
        private bdanexoDataSetTableAdapters.monitorTableAdapter monitorTableAdapter1;
        private bdanexoDataSetTableAdapters.discoduroTableAdapter discoduroTableAdapter1;
        private System.Windows.Forms.BindingSource usuarioBindingSource1;
        private DevExpress.XtraBars.BarButtonItem btnRefrescar;
        private DevExpress.XtraBars.BarButtonItem btnTotalComputadoras;
        private DevExpress.XtraBars.BarButtonItem btnActualizar;
        private DevExpress.XtraGrid.Columns.GridColumn colusuario;
        private DevExpress.XtraGrid.Columns.GridColumn colcorreo;
        private DevExpress.XtraGrid.Columns.GridColumn colarea;
        private DevExpress.XtraGrid.Columns.GridColumn colnombreusuario;
        private DevExpress.XtraBars.BarButtonItem btnVerUsuarios;
        private DevExpress.XtraBars.BarButtonItem btnVerPcs;
        private DevExpress.XtraGrid.GridControl gridPCs;
        private System.Windows.Forms.BindingSource equipoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewEquipo;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colnoinventario;
        private DevExpress.XtraGrid.Columns.GridColumn colnoserie;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn colestado;
        private DevExpress.XtraBars.BarButtonItem btnVerExp;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraGrid.GridControl gridExp;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewExp;
        private System.Windows.Forms.BindingSource expedienteBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colArea1;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarioNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colnoinventario1;
        private DevExpress.XtraGrid.Columns.GridColumn colnoserie1;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre1;
        private DevExpress.XtraGrid.Columns.GridColumn colestado1;
        private DevExpress.XtraGrid.Columns.GridColumn colid1;
        private bdanexoDataSetTableAdapters.expedienteTableAdapter expedienteTableAdapter1;
        private bdanexoDataSetTableAdapters.usuarioTableAdapter usuarioTableAdapter1;
        private DevExpress.XtraBars.BarButtonItem btnControl;
    }
}