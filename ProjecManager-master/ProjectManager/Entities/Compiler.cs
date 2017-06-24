using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entities
{
    public class Compilador
    {
        public static void Compilar(object data, bool check)
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.WorkingDirectory = (String)data;
            if(check == true)
                process.StartInfo.Arguments = "/K mvn clean install -DskipTests";
            else
                process.StartInfo.Arguments = "/c mvn clean install -DskipTests";
            process.EnableRaisingEvents = true;
            //process.Exited += manejador;
            process.Start();
            process.WaitForExit();
            while (!process.HasExited);

        }

        


    }
}
