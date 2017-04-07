using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class PiezaADeployar
    {
        private string nombre;
        private string ruta;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Ruta
        {
            get { return ruta; }
            set { ruta = value; }
        }


    }
}
