using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace ControlAnexo.modeloanexo4
{
    public partial class almacenamientoReport : DevExpress.XtraReports.UI.XtraReport
    {
        public string nombreDisquete
        {
            set
            {
                xrtunidaddisquete.Text = value;
            }
        }

        public string noseriedisquete
        {
            set
            {
                xrtnoseriedisquete.Text = value; 
            }
            
        }

        public string nombreCdDvd {
            set
            {
                xrtcddvd.Text = value; 
            }
            
        }

        public string noserieCdDvd
        {
            set
            { xrtcddvdserie.Text = value; }
           
        }

        public System.Collections.Generic.List<modelo.DiscoDuro> discosduros
        { 
            

            set
            {
                int num = 1; 
                foreach (var item in value)
                {
                    if (num == 1)
                    {
                        xrtdiscoduro1.Text = item.descripcion;
                        xrtcapc1.Text = item.capacidad;
                        xrtdiscoserie1.Text = item.noserie;
                    }
                    if (num == 2)
                    {
                        xrtdiscoduro2.Text = item.descripcion;
                        xrtcapc2.Text = item.capacidad;
                        xrtdiscoserie2.Text = item.noserie;
                    }
                    if (num == 3)
                    {
                        xrtdiscoduro3.Text = item.descripcion;
                        xrtcapc3.Text = item.capacidad;
                        xrtdiscoserie3.Text = item.noserie;
                    }
                    num++;
                }
            }
        }
        
        public almacenamientoReport()
        {
            InitializeComponent();
        }


       
    }
}
