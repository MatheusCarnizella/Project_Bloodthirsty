using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Bloodthirsty.Utils
{
    public static class Utility
    {

        public const string FOLDERS_TORETURN = @"..\..\";

        public static string GetRootDirectory()
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            return Path.GetFullPath(Path.Combine(baseDirectory + FOLDERS_TORETURN));
        }

        public static string GetRootDirectory(string pathDirectory)
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            return Path.GetFullPath(Path.Combine(baseDirectory + FOLDERS_TORETURN + pathDirectory));
        }

    }
}
