using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpreadsheetLight;

namespace PytF1357Model
{
    internal class WriteTXT
    {
        internal List<object> ReadExcelVersion5(List<object> Registro01, string readFile, string saveFile)
        {
            List<object> dataReturn = new List<object>();

            try
            {
                SLDocument excelFile = new SLDocument(readFile);
                StreamWriter txtfile = new StreamWriter(saveFile + $@"\F1357.{Registro01[0]}.{Registro01[1]}.{Registro01[2]}.txt");

                int column = 1;
                int row = 2;

                // Manejo de decimales
                decimal decimalRedondeado;
                string decimalCadena;

                // Se escriben los valores del registro 01.
                string valorRegistroUno = $"01{Registro01[0]}{Registro01[1]}{Registro01[2]}01032151357{Registro01[3]}00500\n";
                txtfile.Write(valorRegistroUno);

                bool check = string.IsNullOrEmpty(excelFile.GetCellValueAsString(row, column));

                while (string.IsNullOrEmpty(excelFile.GetCellValueAsString(row, column)) == false)
                {

                    RegisterLenght registerLenght = new RegisterLenght();

                    string fill = null;

                    if (column == 1)
                    {
                        fill = "02" + registerLenght.ConvertToRegisterLenght(excelFile.GetCellValueAsInt64(row, column), 11);
                        txtfile.Write(fill);

                    }
                    else if (column == 2 || column == 3)
                    {
                        fill = registerLenght.ConvertToRegisterLenght(excelFile.GetCellValueAsString(row, column), 8);
                        txtfile.Write(fill);

                    }
                    else if (column == 4)
                    {
                        fill = registerLenght.ConvertToRegisterLenght(excelFile.GetCellValueAsInt32(row, column), 2);
                        txtfile.Write(fill);
                    }
                    else if (column >= 5 && column < 10)
                    {
                        fill = registerLenght.ConvertToRegisterLenght(excelFile.GetCellValueAsInt32(row, column), 1);
                        txtfile.Write(fill);

                    }
                    else if (column == 10)
                    {
                        fill = registerLenght.ConvertToRegisterLenght(excelFile.GetCellValueAsInt32(row, column), 1) + "\n";
                        txtfile.Write(fill);
                    }
                    else if (column == 11)
                    {
                        decimalRedondeado = excelFile.GetCellValueAsDecimal(row, column);
                        decimalCadena = decimalRedondeado.ToString("N2");
                        fill = "03" + registerLenght.ConvertToRegisterLenght(excelFile.GetCellValueAsInt64(row, 1), 11)
                                    + registerLenght.ConvertToRegisterLenght(decimalCadena, 15);
                        txtfile.Write(fill);
                    }
                    else if (column >= 12 && column <= 34)
                    {
                        decimalRedondeado = excelFile.GetCellValueAsDecimal(row, column);
                        decimalCadena = decimalRedondeado.ToString("N2");
                        fill = registerLenght.ConvertToRegisterLenght(decimalCadena, 15);
                        txtfile.Write(fill);

                    }
                    else if (column == 35)
                    {
                        decimalRedondeado = excelFile.GetCellValueAsDecimal(row, column);
                        decimalCadena = decimalRedondeado.ToString("N2");
                        fill = registerLenght.ConvertToRegisterLenght(decimalCadena, 17);
                        txtfile.Write(fill);
                    }
                    else if (column >= 36 && column < 63)
                    {
                        decimalRedondeado = excelFile.GetCellValueAsDecimal(row, column);
                        decimalCadena = decimalRedondeado.ToString("N2");
                        fill = registerLenght.ConvertToRegisterLenght(decimalCadena, 15);
                        txtfile.Write(fill);

                    }
                    else if (column == 63)
                    {
                        decimalRedondeado = excelFile.GetCellValueAsDecimal(row, column);
                        decimalCadena = decimalRedondeado.ToString("N2");
                        fill = registerLenght.ConvertToRegisterLenght(decimalCadena, 15) + "\n";
                        txtfile.Write(fill);
                    }
                    else if (column == 64)
                    {
                        decimalRedondeado = excelFile.GetCellValueAsDecimal(row, column);
                        decimalCadena = decimalRedondeado.ToString("N2");
                        fill = "04" + registerLenght.ConvertToRegisterLenght(excelFile.GetCellValueAsString(row, 1), 11)
                                    + registerLenght.ConvertToRegisterLenght(decimalCadena, 15);
                        txtfile.Write(fill);
                    }
                    else if (column >= 65 && column <= 87)
                    {
                        decimalRedondeado = excelFile.GetCellValueAsDecimal(row, column);
                        decimalCadena = decimalRedondeado.ToString("N2");
                        fill = registerLenght.ConvertToRegisterLenght(decimalCadena, 15);
                        txtfile.Write(fill);

                    }
                    else if (column == 88)
                    {
                        decimalRedondeado = excelFile.GetCellValueAsDecimal(row, column);
                        decimalCadena = decimalRedondeado.ToString("N2");
                        fill = registerLenght.ConvertToRegisterLenght(decimalCadena, 17);
                        txtfile.Write(fill);

                    }
                    else if (column >= 89 && column < 92)
                    {
                        decimalRedondeado = excelFile.GetCellValueAsDecimal(row, column);
                        decimalCadena = decimalRedondeado.ToString("N2");
                        fill = registerLenght.ConvertToRegisterLenght(decimalCadena, 15);
                        txtfile.Write(fill);

                    }
                    else if (column == 92)
                    {
                        decimalRedondeado = excelFile.GetCellValueAsDecimal(row, column);
                        decimalCadena = decimalRedondeado.ToString("N2");
                        fill = registerLenght.ConvertToRegisterLenght(decimalCadena, 15) + "\n";
                        txtfile.Write(fill);
                    }
                    else if (column == 93)
                    {
                        decimalRedondeado = excelFile.GetCellValueAsDecimal(row, column);
                        decimalCadena = decimalRedondeado.ToString("N2");
                        fill = "05" + registerLenght.ConvertToRegisterLenght(excelFile.GetCellValueAsString(row, 1), 11)
                                    + registerLenght.ConvertToRegisterLenght(decimalCadena, 15);
                        txtfile.Write(fill);
                    }
                    else if (column >= 94 && column <= 96)
                    {
                        decimalRedondeado = excelFile.GetCellValueAsDecimal(row, column);
                        decimalCadena = decimalRedondeado.ToString("N2");
                        fill = registerLenght.ConvertToRegisterLenght(decimalCadena, 15);
                        txtfile.Write(fill);
                    }
                    else if (column == 97)
                    {
                        fill = registerLenght.ConvertToRegisterLenght(excelFile.GetCellValueAsString(row, column), 2);
                        txtfile.Write(fill);

                    }
                    else if (column >= 98 && column <= 104)
                    {
                        decimalRedondeado = excelFile.GetCellValueAsDecimal(row, column);
                        decimalCadena = decimalRedondeado.ToString("N2");
                        fill = registerLenght.ConvertToRegisterLenght(decimalCadena, 15);
                        txtfile.Write(fill);
                    }
                    else if (column == 105)
                    {
                        fill = registerLenght.ConvertToRegisterLenght(excelFile.GetCellValueAsString(row, column), 2);
                        txtfile.Write(fill);

                    }
                    else if (column >= 106 && column < 108)
                    {
                        decimalRedondeado = excelFile.GetCellValueAsDecimal(row, column);
                        decimalCadena = decimalRedondeado.ToString("N2");
                        fill = registerLenght.ConvertToRegisterLenght(decimalCadena, 15);
                        txtfile.Write(fill);

                    }
                    else if (column == 108)
                    {
                        decimalRedondeado = excelFile.GetCellValueAsDecimal(row, column);
                        decimalCadena = decimalRedondeado.ToString("N2");
                        fill = registerLenght.ConvertToRegisterLenght(decimalCadena, 15) + "\n";
                        txtfile.Write(fill);
                    }
                    else if (column == 109)
                    {
                        fill = "06" + registerLenght.ConvertToRegisterLenght(excelFile.GetCellValueAsString(row, 1), 11)
                                    + registerLenght.ConvertToRegisterLenght(excelFile.GetCellValueAsString(row, column), 1);
                        txtfile.Write(fill);
                    }
                    else if (column == 110)
                    {
                        fill = registerLenght.ConvertToRegisterLenght(excelFile.GetCellValueAsString(row, column), 1);
                        txtfile.Write(fill);
                    }
                    else if (column >= 111 && column < 125)
                    {
                        decimalRedondeado = excelFile.GetCellValueAsDecimal(row, column);
                        decimalCadena = decimalRedondeado.ToString("N2");
                        fill = registerLenght.ConvertToRegisterLenght(decimalCadena, 15);
                        txtfile.Write(fill);
                    }
                    else if (column == 125)
                    {
                        decimalRedondeado = excelFile.GetCellValueAsDecimal(row, column);
                        decimalCadena = decimalRedondeado.ToString("N2");
                        fill = registerLenght.ConvertToRegisterLenght(decimalCadena, 15) + "\n";
                        txtfile.Write(fill);
                    }

                    // Verifica que existan datos en el archivo excel.
                    if (string.IsNullOrEmpty(excelFile.GetCellValueAsString(row, column + 1)) == false)
                    {
                        column++;
                    }
                    else if (string.IsNullOrEmpty(excelFile.GetCellValueAsString(row + 1, column)) == false)
                    {
                        column = 1;
                        row++;
                    }
                    else
                    {
                        break;
                    }
                }
                txtfile.Close();

                dataReturn.Add(true);
                dataReturn.Add("El proceso finalizo correctamente.");

                return dataReturn;
            }
            catch(Exception ex)
            {
                dataReturn.Add(false);
                dataReturn.Add(ex.Message);

                return dataReturn;
            }
        }

        internal List<object> ReadExcelVersion6(List<object> Registro01, string readFile, string saveFile)
        {
            List<object> dataReturn = new List<object>();

            try
            {
                SLDocument excelFile = new SLDocument(readFile);
                StreamWriter txtfile = new StreamWriter(saveFile + $@"\F1357.{Registro01[0]}.{Registro01[1]}.{Registro01[2]}.txt");

                int column = 1;
                int row = 2;
                decimal decimalRedondeado;
                string decimalString;

                // Se escriben los valores del registro 01.
                string valorRegistroUno = $"01{Registro01[0]}{Registro01[1]}{Registro01[2]}01032151357{Registro01[3]}00600\n";
                txtfile.Write(valorRegistroUno);

                bool check = string.IsNullOrEmpty(excelFile.GetCellValueAsString(row, column));

                while (string.IsNullOrEmpty(excelFile.GetCellValueAsString(row, column)) == false)
                {

                    RegisterLenght registerLenght = new RegisterLenght();

                    string fill = null;

                    if (column == 1)
                    {
                        fill = "02" + registerLenght.ConvertToRegisterLenght(excelFile.GetCellValueAsInt64(row, column), 11);
                        txtfile.Write(fill);

                    }
                    else if (column == 2 || column == 3)
                    {
                        fill = registerLenght.ConvertToRegisterLenght(excelFile.GetCellValueAsString(row, column), 8);
                        txtfile.Write(fill);

                    }
                    else if (column == 4)
                    {
                        fill = registerLenght.ConvertToRegisterLenght(excelFile.GetCellValueAsInt32(row, column), 2);
                        txtfile.Write(fill);
                    }
                    else if (column >= 5 && column < 11)
                    {
                        fill = registerLenght.ConvertToRegisterLenght(excelFile.GetCellValueAsInt32(row, column), 1);
                        txtfile.Write(fill);

                    }
                    else if (column == 11)
                    {
                        fill = registerLenght.ConvertToRegisterLenght(excelFile.GetCellValueAsInt32(row, column), 1) + "\n";
                        txtfile.Write(fill);
                    }
                    else if (column == 12)
                    {
                        decimalRedondeado = Math.Round(excelFile.GetCellValueAsDecimal(row, column), 2);
                        decimalString = decimalRedondeado.ToString("N2");
                        fill = "03" + registerLenght.ConvertToRegisterLenght(excelFile.GetCellValueAsInt64(row, 1), 11)
                                    + registerLenght.ConvertToRegisterLenght(decimalString, 15);
                        txtfile.Write(fill);
                    }
                    else if (column >= 13 && column <= 35)
                    {
                        decimalRedondeado = Math.Round(excelFile.GetCellValueAsDecimal(row, column), 2);
                        decimalString = decimalRedondeado.ToString("N2");
                        fill = registerLenght.ConvertToRegisterLenght(decimalString, 15);
                        txtfile.Write(fill);

                    }
                    else if (column == 36)
                    {
                        decimalRedondeado = Math.Round(excelFile.GetCellValueAsDecimal(row, column), 2);
                        decimalString = decimalRedondeado.ToString("N2");
                        fill = registerLenght.ConvertToRegisterLenght(decimalString, 17);
                        txtfile.Write(fill);
                    }
                    else if (column >= 37 && column < 64)
                    {
                        decimalRedondeado = Math.Round(excelFile.GetCellValueAsDecimal(row, column), 2);
                        decimalString = decimalRedondeado.ToString("N2");
                        fill = registerLenght.ConvertToRegisterLenght(decimalString, 15);
                        txtfile.Write(fill);

                    }
                    else if (column == 64)
                    {
                        decimalRedondeado = Math.Round(excelFile.GetCellValueAsDecimal(row, column), 2);
                        decimalString = decimalRedondeado.ToString("N2");
                        fill = registerLenght.ConvertToRegisterLenght(decimalString, 15) + "\n";
                        txtfile.Write(fill);
                    }
                    else if (column == 65)
                    {
                        decimalRedondeado = Math.Round(excelFile.GetCellValueAsDecimal(row, column), 2);
                        decimalString = decimalRedondeado.ToString("N2");
                        fill = "04" + registerLenght.ConvertToRegisterLenght(excelFile.GetCellValueAsInt64(row, 1), 11)
                                    + registerLenght.ConvertToRegisterLenght(decimalString, 15);
                        txtfile.Write(fill);
                    }
                    else if (column >= 66 && column <= 88)
                    {
                        decimalRedondeado = Math.Round(excelFile.GetCellValueAsDecimal(row, column), 2);
                        decimalString = decimalRedondeado.ToString("N2");
                        fill = registerLenght.ConvertToRegisterLenght(decimalString, 15);
                        txtfile.Write(fill);

                    }
                    else if (column == 89)
                    {
                        decimalRedondeado = Math.Round(excelFile.GetCellValueAsDecimal(row, column), 2);
                        decimalString = decimalRedondeado.ToString("N2");
                        fill = registerLenght.ConvertToRegisterLenght(decimalString, 17);
                        txtfile.Write(fill);

                    }
                    else if (column >= 90 && column < 94)
                    {
                        decimalRedondeado = Math.Round(excelFile.GetCellValueAsDecimal(row, column), 2);
                        decimalString = decimalRedondeado.ToString("N2");
                        fill = registerLenght.ConvertToRegisterLenght(decimalString, 15);
                        txtfile.Write(fill);

                    }
                    else if (column == 94)
                    {
                        decimalRedondeado = Math.Round(excelFile.GetCellValueAsDecimal(row, column), 2);
                        decimalString = decimalRedondeado.ToString("N2");
                        fill = registerLenght.ConvertToRegisterLenght(decimalString, 15) + "\n";
                        txtfile.Write(fill);
                    }
                    else if (column == 95)
                    {
                        decimalRedondeado = Math.Round(excelFile.GetCellValueAsDecimal(row, column), 2);
                        decimalString = decimalRedondeado.ToString("N2");
                        fill = "05" + registerLenght.ConvertToRegisterLenght(excelFile.GetCellValueAsInt64(row, 1), 11)
                                    + registerLenght.ConvertToRegisterLenght(decimalString, 15);
                        txtfile.Write(fill);
                    }
                    else if (column >= 96 && column <= 98)
                    {
                        decimalRedondeado = Math.Round(excelFile.GetCellValueAsDecimal(row, column), 2);
                        decimalString = decimalRedondeado.ToString("N2");
                        fill = registerLenght.ConvertToRegisterLenght(decimalString, 15);
                        txtfile.Write(fill);
                    }
                    else if (column == 99)
                    {
                        fill = registerLenght.ConvertToRegisterLenght(excelFile.GetCellValueAsInt32(row, column), 2);
                        txtfile.Write(fill);

                    }
                    else if (column >= 100 && column <= 106)
                    {
                        decimalRedondeado = Math.Round(excelFile.GetCellValueAsDecimal(row, column), 2);
                        decimalString = decimalRedondeado.ToString("N2");
                        fill = registerLenght.ConvertToRegisterLenght(decimalString, 15);
                        txtfile.Write(fill);
                    }
                    else if (column == 107)
                    {
                        fill = registerLenght.ConvertToRegisterLenght(excelFile.GetCellValueAsInt32(row, column), 2);
                        txtfile.Write(fill);

                    }
                    else if (column >= 108 && column <= 110)
                    {
                        decimalRedondeado = Math.Round(excelFile.GetCellValueAsDecimal(row, column), 2);
                        decimalString = decimalRedondeado.ToString("N2");
                        fill = registerLenght.ConvertToRegisterLenght(decimalString, 15);
                        txtfile.Write(fill);

                    }
                    else if (column >= 111 && column <= 113)
                    {
                        fill = registerLenght.ConvertToRegisterLenght(excelFile.GetCellValueAsInt32(row, column), 2);
                        txtfile.Write(fill);

                    }
                    else if (column == 114)
                    {
                        fill = registerLenght.ConvertToRegisterLenght(excelFile.GetCellValueAsInt32(row, column), 2) + "\n";
                        txtfile.Write(fill);
                    }
                    else if (column == 115)
                    {
                        fill = "06" + registerLenght.ConvertToRegisterLenght(excelFile.GetCellValueAsInt64(row, 1), 11)
                                    + registerLenght.ConvertToRegisterLenght(excelFile.GetCellValueAsInt32(row, column), 1);
                        txtfile.Write(fill);
                    }
                    else if (column == 116)
                    {
                        fill = registerLenght.ConvertToRegisterLenght(excelFile.GetCellValueAsInt32(row, column), 1);
                        txtfile.Write(fill);
                    }
                    else if (column >= 117 && column <= 130)
                    {
                        decimalRedondeado = Math.Round(excelFile.GetCellValueAsDecimal(row, column), 2);
                        decimalString = decimalRedondeado.ToString("N2");
                        fill = registerLenght.ConvertToRegisterLenght(decimalString, 15);
                        txtfile.Write(fill);
                    }
                    else if (column == 131)
                    {
                        decimalRedondeado = Math.Round(excelFile.GetCellValueAsDecimal(row, column), 2);
                        decimalString = decimalRedondeado.ToString("N2");
                        fill = registerLenght.ConvertToRegisterLenght(decimalString, 15) + "\n";
                        txtfile.Write(fill);
                    }

                    // Verifica que existan datos en el archivo excel.
                    if (string.IsNullOrEmpty(excelFile.GetCellValueAsString(row, column + 1)) == false)
                    {
                        column++;
                    }
                    else if (string.IsNullOrEmpty(excelFile.GetCellValueAsString(row + 1, column)) == false)
                    {
                        column = 1;
                        row++;
                    }
                    else
                    {
                        break;
                    }
                }

                txtfile.Close();

                dataReturn.Add(true);
                dataReturn.Add("El procedimiento finalizo correctamente.");
                
                return dataReturn;
            }
            catch(IOException)
            {
                dataReturn.Add(false);
                dataReturn.Add("El archivo especificado esta siendo utilizado en otro proceso.");
                
                return dataReturn;
            }            
        }
    }
}
