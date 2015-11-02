using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using System.Threading;

namespace ControlAnexo.vistas
{
    public partial class VPantallaInicial : SplashScreen
    {
        public VPantallaInicial()
        {
            InitializeComponent();
            backgroundWorker1.RunWorkerAsync();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
            
        }

        private void finishProcess()
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;

            this.Close();
        }


        public void setMessage(string msg)
        {
            labelControl2.Text = msg;
        }

        private void backgroundWorker1_DoWork_1(object sender, DoWorkEventArgs e)
        {
            System.Threading.Thread.Sleep(3000);

            this.Invoke((MethodInvoker)(() => setMessage("Conectando a la bases de datos..")));

            Thread.Sleep(3000);

            this.Invoke((MethodInvoker)(() => setMessage("Cargando archivos de configuración...")));

            Thread.Sleep(3000);

            this.Invoke((MethodInvoker)(() => setMessage("Iniciando la aplicación...")));

            Thread.Sleep(3000);

            if (this.InvokeRequired) this.Invoke(new Action(finishProcess));
            
        }
    }
}