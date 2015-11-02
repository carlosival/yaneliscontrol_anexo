using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControlAnexo.modelo
{
   public class Configuracion
    {
       public string noinventario { set; get; }
        public string cantidad { get; set; }
        public string memoria { get; set; }
        public string procesador { get; set; }
        public string placabase { get; set; }
        public string velocidad { get; set; }
        public string noserieplacabase { get; set; }
        public string tarjetared { set; get; }
        public string tarjetasonido { set; get; }
        public string tarjetavideo { set; get; }
        public int id { get; set; }
    }
}
