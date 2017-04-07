using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Serializable]
    public class Server
    {
        private string name;
        private string path;
        private List<string> sources = new List<string>();

        public List<string> Sources
        {
            get { return sources; }
            set { sources = value; }
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
