using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Compilador
    {
        public static void Compilar(string path)
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.WorkingDirectory = path;
            process.StartInfo.Arguments = "/c mvn clean install -DskipTests";
            process.Start();
        }
    }
}
