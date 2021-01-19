using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M2NETCore_MVC.Models
{
    public class Servicios
    {

        public int _id { get; set; }
        public string _descripcion { get; set; }
        public Servicios()
        {

        }

        public Servicios(int id, string descripcion)
        {
            this._id = id;
            this._descripcion = descripcion;
        }



    }
}
