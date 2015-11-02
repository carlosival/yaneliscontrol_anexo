using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Threading;

namespace ControlAnexo.vistas
{
    public partial class VSplashScreen : DevExpress.XtraEditors.XtraForm
    {
        public VSplashScreen()
        {
            InitializeComponent();
            backgroundWorker1.RunWorkerAsync();
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

      

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            System.Threading.Thread.Sleep(3000);

            this.Invoke((MethodInvoker)(() => setMessage("Conectando a la bases de datos..")));

            System.Threading.Thread.Sleep(3000);

            this.Invoke((MethodInvoker)(() => setMessage("Cargando archivos de configuración...")));

            Thread.Sleep(3000);

            this.Invoke((MethodInvoker)(() => setMessage("Iniciando la aplicación...")));

            Thread.Sleep(3000);

            if (this.InvokeRequired) this.Invoke(new Action(finishProcess));
        }
    }
}