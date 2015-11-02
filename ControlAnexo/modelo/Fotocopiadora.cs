using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControlAnexo.modelo
{
   public class Fotocopiadora
    {
        public int id { set; get; }
        public string noinventario { set; get; }
        public string modelo { set; get; }
        public string noserie { set; get; }
        public string marca { set; get; }


        public string estado { get; set; }
    }
}
