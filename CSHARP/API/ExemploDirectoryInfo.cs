﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CursoCSharp.API
{
    internal class ExemploDirectoryInfo
    {
        public static void Executar()
        {
            var dirProjeto = @"~/source/repos".ParseHome();

            var dirInfo = new DirectoryInfo(dirProjeto);

            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }

            Console.WriteLine("=== Arquivos ================");
            var arquivos = dirInfo.GetFiles();
            foreach (var arquivo in arquivos)
            {
                Console.WriteLine(arquivo);
            }

            Console.WriteLine("\n=== Pastas ================");
            var pastas = dirInfo.GetDirectories();
            foreach (var pasta in pastas)
            {
                Console.WriteLine(pasta);
            }

            Console.WriteLine(dirInfo.CreationTime);
            Console.WriteLine(dirInfo.FullName);
            Console.WriteLine(dirInfo.Root);
            Console.WriteLine(dirInfo.Parent);
            Console.WriteLine(dirInfo.Parent.Parent);
        }
    }
}
