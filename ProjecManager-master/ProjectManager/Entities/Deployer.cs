using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace Entities
{
    public class Deployer
    {
        /// <summary>
        /// Copia los archivos (abre un cuadro de progreso)
        /// </summary>
        /// <param name="source">origen</param>
        /// <param name="targetPath">destino</param>
        public static void Deployar(string source, string targetPath)
        {
            try
            {
                FileSystem.CopyFile(source, targetPath,
                    UIOption.AllDialogs);
            }
            catch (OperationCanceledException)
            {
                
            }
        }
    }
}
