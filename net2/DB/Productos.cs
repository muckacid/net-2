using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using net2.Model;

namespace net2.DB
{
    class Productos
    {
        //conexion: instacia de la base de datos
        public List<Producto> Data { set; get; }

        public Productos()
        {
            Data = new List<Producto>();
        }
    }
}
