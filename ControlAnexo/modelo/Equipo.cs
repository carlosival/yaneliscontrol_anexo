using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControlAnexo.modelo
{
  public class Equipo
    {
      public string noinventario { set; get; }
      public string noserie { set; get; }
      public string nombre { set; get; }
      public string estado { set; get; }
      public string dominiored { get; set; }
      public string observaciones { get; set; }
      public int id { get; set; }
    }
}
