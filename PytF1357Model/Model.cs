using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PytF1357Model
{
    public static class Model
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Registro01"></param>
        /// <param name="OpenFile"></param>
        /// <param name="SaveFile"></param>
        /// <returns></returns>
        public static List<object> TxtAExcelVersion5(List<object> Registro01, string OpenFile, string SaveFile)
        {
            // Valores a pasar.
            List<object> resultados;            
            //Versión 5
            byte version = 5;
            // Genera archivo Excel.            
            LecturaTXT lecturaTXT = new LecturaTXT();
            // Lee registro 01.
            lecturaTXT.ReturnReg01(Registro01, OpenFile);
            // Genera el resto del archivo y devuelve el estado del proceso.
            resultados = lecturaTXT.ReadTxt(OpenFile, SaveFile, version);
            
            return resultados;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Registro01"></param>
        /// <param name="OpenFile"></param>
        /// <param name="SaveFile"></param>
        /// <returns></returns>
        public static List<object> TxtAExcelVersion6(List<object> Registro01, string OpenFile, string SaveFile)
        {
            // Valores a pasar.
            List<object> list;
            // Versión 6
            byte version = 6;
            // Generación del txt.
            LecturaTXT lecturaTXT = new LecturaTXT();
            // Genera archivo Excel.
            // Lee registro 01
            lecturaTXT.ReturnReg01(Registro01, OpenFile);
            // Genera el resto del archivo y devuelve el estado del proceso.
            list = lecturaTXT.ReadTxt(OpenFile, SaveFile, version);
            
            return list;
        }

        public static List<object> ExcelATxtVersion5(List<object> Registro01, string ReadFile, string SaveFile)
        {
            // Valores a retornar.
            List<object> resultados;            
            
            WriteTXT writeTXT = new WriteTXT();
            resultados = writeTXT.ReadExcelVersion5(Registro01 , ReadFile, SaveFile);
                
            return resultados;
        }

        public static List<object> ExcelATxtVersion6(List<object> Registro01, string ReadFile, string SaveFile)
        {
            // Valores a retornar.
            List<object> list;           
            WriteTXT writeTXT = new WriteTXT();
            list = writeTXT.ReadExcelVersion6(Registro01, ReadFile, SaveFile);
            return list;
        }
    }
}
