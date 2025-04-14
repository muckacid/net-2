using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using net2.Model;

namespace net2.DB
{
    class Inventario
    {
        //conexion: instacia de la base de datos
        public List<Item> Data { set; get; }

        public Inventario()
        {
            Data = new List<Item>();
        }
    }
}
