using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Deployer
    {
        public static void Deployar(string source, string targetPath)
        {
            System.IO.File.Copy(source, targetPath, true);
        }
    }
}
