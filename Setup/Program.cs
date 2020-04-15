
using Microsoft.VisualBasic.FileIO;
using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;

namespace Setup
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!Directory.Exists("C:\\ProgramFiles (x86)\\PuroRecheio\\Compras"))
                Directory.CreateDirectory("C:\\ProgramFiles (x86)\\PuroRecheio\\Compras");
            foreach (var file in Directory.GetFiles(Path.GetFullPath(".")))
                Console.WriteLine(file);
            foreach (var file in Directory.GetDirectories(Path.GetFullPath(".")))
                Console.WriteLine(file);
            FileSystem.CopyDirectory("Programas", "C:\\Program Files (x86)\\PuroRecheio\\Compras");
            var processo = Process.Start("SQL\\SQL2019-SSEI-Expr.exe");
            processo.WaitForExit();
        }
    }
}
