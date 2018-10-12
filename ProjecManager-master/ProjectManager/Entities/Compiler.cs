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

        public static void CompilarApk(object path, bool plataforma, bool firma, String entorno)
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.WorkingDirectory = (String)path;
            process.StartInfo.Arguments += "/K ";

            switch (entorno)
            {
                case "DESARROLLO":
                    process.StartInfo.Arguments += "set TARGET=dev ";
                    break;
                case "TESTING":
                    process.StartInfo.Arguments += "set TARGET=test ";
                    break;
                case "PRODUCCION":
                    process.StartInfo.Arguments += "set TARGET=prod ";
                    break;
            }

            if (plataforma == true){
                process.StartInfo.Arguments += "&& cordova platform remove android && cordova platform add android ";
            }

            if (entorno.Equals("PRODUCCION"))
            {
                process.StartInfo.Arguments += "&& XCOPY googleServices\\prod\\google-services.json platforms\android\app /Y /S ";
            }
            else
            {
                process.StartInfo.Arguments += @"&& XCOPY googleServices\test\google-services.json platforms\android\app /Y /S ";
            }

            if (firma == true)
            {
                process.StartInfo.Arguments += @"&& cordova build --release && XCOPY platforms\android\app\build\outputs\apk\release\app-release-unsigned.apk .\firmaAPK /Y /S && del firmaAPK\osdeUrgenciasMobile.apk /Q && jarsigner -verbose -sigalg SHA1withRSA -digestalg SHA1 -keystore urgenciasMobile.keystore firmaAPK/app-release-unsigned.apk urgMobileOsde -storepass misiones -keypass grupoosde && cd firmaAPK && ren app-release-unsigned.apk osdeUrgenciasMobile.apk";
                 process.Start();
                 process.WaitForExit();
                 while (!process.HasExited) ;
            }
            else
            {
                process.StartInfo.Arguments += "&& cordova build android";
                process.Start();
                process.WaitForExit();
                while (!process.HasExited) ;
            }
                
                
            
            
            
            
        }
    }
}
