using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PytF1357Model
{
    public static class IniFile
    {
        

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section,
            string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section,
            string key, string def, StringBuilder retVal, int size, string filePath);

        public static void WriteINI(string Valor)
        {
            string Seccion = "PATH";
            string Clave = "path";
            string path = $"{Environment.CurrentDirectory}/Config.ini";
            WritePrivateProfileString(Seccion, Clave, Valor, path);
        }

        public static string ReadINI()
        {
            StringBuilder temp = new StringBuilder(255);
            string path = $"{Environment.CurrentDirectory}/Config.ini";
            string Seccion = "PATH";
            string Clave = "path";
            int i = GetPrivateProfileString(Seccion, Clave, "", temp, 255, path);
            return temp.ToString();
        }


    }
}
