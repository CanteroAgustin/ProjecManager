using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Serializable]
    public class Apps
    {
        private string name;
        private string path;
        private List<string> piezas = new List<string>();


        public List<string> Piezas
        {
            get { return piezas; }
            set { piezas = value; }
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Path
        {
            get { return path; }
            set { path = value; }
        }

    }
}
