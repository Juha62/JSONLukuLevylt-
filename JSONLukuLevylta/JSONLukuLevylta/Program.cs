using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONLukuLevylta
{
    class Program
    {
        static void Main(string[] args)
        {
            string Filetsu = @"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETCore\v5.0\project.lock.json";

            if (File.Exists(Filetsu))


            {



                string aiempitiedosto = File.ReadAllText(Filetsu);
                Console.WriteLine(aiempitiedosto);

                Console.ReadLine();

            }
        }
    }
}