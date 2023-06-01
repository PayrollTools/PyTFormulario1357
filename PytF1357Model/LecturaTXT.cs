using System;
using System.IO;
using System.Collections.Generic;
using SpreadsheetLight;

namespace PytF1357Model
{
    internal class LecturaTXT
    {
        // Archivo de texto
        private List<string> lecturaTXT = new List<string>();
        
        // Lista donde se van a guardar los datos correspondientes a cada empleado.
        private List<object> registroEmpleado = new List<object>();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="reg01"></param>
        /// <param name="openFile"></param>
        /// <returns></returns>
        internal List<object> ReturnReg01(List<object> reg01, string openFile)
        {
            // Lectura del archivo txt.
            StreamReader txtFile = new StreamReader(openFile);
                      
            string linea = txtFile.ReadLine();
          
            long cuit = long.Parse(linea.Substring(2, 11));
            int perInformado = Int32.Parse(linea.Substring(13, 6));
            int secuencia = Int32.Parse(linea.Substring(19, 2));         
            int tipPresentacion = Int32.Parse(linea.Substring(32, 1));

            reg01.Add(cuit);
            reg01.Add(perInformado);
            reg01.Add(secuencia);
            reg01.Add(tipPresentacion);

            txtFile.Close();

            return reg01;
        }

        public List<object> ReadTxt(string openFile, string saveFile, byte version)
        {
            List<object> returnData = new List<object>();

            try
            {
                // Archivo de texto.
                StreamReader txtfile = new StreamReader(openFile);

                // ArchivoExcel
                SLDocument excelFile = new SLDocument();

                // Clase Data Frame
                DataFrame tDatos = new DataFrame();

                // Genero los datos para el DataTable
                tDatos.CreateColumns(version);

                // Variable donde se van a guardar las lineas del archivo.
                String linea;

                // lee el archivo de texto.
                linea = txtfile.ReadLine();

                while (linea != null)
                {
                    lecturaTXT.Add(linea);
                    linea = txtfile.ReadLine();
                }

                txtfile.Close();

                // Guarda los datos obtenidos en el listado registroEmpleado.

                for (int i = 0; i < lecturaTXT.Count; i++)
                {
                    String codigo = lecturaTXT[i].Substring(0, 2);

                    switch (codigo)
                    {
                        case "02":
                            LeerRegistro02(registroEmpleado, lecturaTXT, i, version);
                            break;
                        case "03":
                            LeerRegistro03(registroEmpleado, lecturaTXT, i);
                            break;
                        case "04":
                            LeerRegistro04(registroEmpleado, lecturaTXT, i, version);
                            break;
                        case "05":
                            if (version == 5)
                            {
                                LeerRegistro05Version5(registroEmpleado, lecturaTXT, i);
                            }
                            else
                            {
                                LeerRegistro05Version6(registroEmpleado, lecturaTXT, i);
                            }

                            break;

                        case "06":
                            LeerRegistro06(registroEmpleado, lecturaTXT, i);

                            // Paso los datos al DataTable

                            tDatos.tablaDatos.Rows.Add(registroEmpleado.ToArray());

                            // Limpio el List.
                            registroEmpleado.Clear();

                            break;
                    }
                }
                // Se guardan los datos en el archivo excel.
                excelFile.ImportDataTable(1, 1, tDatos.tablaDatos, true);
                excelFile.SaveAs(saveFile + @"\Resultados.xlsx");

                returnData.Add(true);
                returnData.Add("El proceso finalizo correctamente.");

                return returnData;
            }
            catch(Exception ex)
            {
                returnData.Add(false);
                returnData.Add(ex.Message);
                
                return returnData;
            }            
        }

        /// <summary>
        /// Extrae los datos, desde un objeto tipo List, del registro 02.
        /// </summary>
        /// <param name="arrayEmpleado">List. Guarda en el list los datos que extrae.</param>
        /// <param name="archivoTexto">List. Lista de donde extrae los datos.</param>
        /// <param name="i">Int. Indica el indice del List -> archivoTexto.</param>
        protected void LeerRegistro02 (List<Object> arrayEmpleado, List<string> archivoTexto, int i, byte version)
        {
            byte? convenio401989 = null;

            // Primer línea de registro correspondiente al empleado
            long cuil = long.Parse(archivoTexto[i].Substring(2, 11));
            String periodoDesde = archivoTexto[i].Substring(13, 8);
            String periodoHasta = archivoTexto[i].Substring(21, 8);
            byte meses = byte.Parse(archivoTexto[i].Substring(29, 2));
            byte beneficio = byte.Parse(archivoTexto[i].Substring(31, 1));
            byte transporte = byte.Parse(archivoTexto[i].Substring(32, 1));
            byte ley27424 = byte.Parse(archivoTexto[i].Substring(33, 1));
            byte ley27549 = byte.Parse(archivoTexto[i].Substring(34, 1));
            byte ley27555 = byte.Parse(archivoTexto[i].Substring(35, 1));
            byte ley19101 = byte.Parse(archivoTexto[i].Substring(36, 1));
            
            if(version == 6)
            {
                convenio401989 = byte.Parse(archivoTexto[i].Substring(37, 1));
            }


            // Guarda los datos en el registro.
            arrayEmpleado.Add(cuil);
            arrayEmpleado.Add(periodoDesde);
            arrayEmpleado.Add(periodoHasta);
            arrayEmpleado.Add(meses);
            arrayEmpleado.Add(beneficio);
            arrayEmpleado.Add(transporte);
            arrayEmpleado.Add(ley27424);
            arrayEmpleado.Add(ley27549);
            arrayEmpleado.Add(ley27555);
            arrayEmpleado.Add(ley19101);
            if(version == 6)
            {
                arrayEmpleado.Add(convenio401989);
            }
        }

        /// <summary>
        /// Extrae los datos, desde un objeto tipo List, del registro 03.
        /// </summary>
        /// <param name="arrayEmpleado">List. Guarda en el list los datos que extrae.</param>
        /// <param name="archivoTexto">List. Lista de donde extrae los datos.</param>
        /// <param name="i">Int. Indica el indice del List -> archivoTexto.</param>
        protected void LeerRegistro03(List<Object> arrayEmpleado, List<string> archivoTexto, int i)
        {
            // Segunda línea de registro correspondiente al empleado
            Decimal remBrutaGravada = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(13, 15));
            Decimal retNoHabitualesGravadas = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(28, 15));
            Decimal sacPrimerCuotaGrav = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(43, 15));
            Decimal sacSegCuotaGrav = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(58, 15));
            Decimal hsExtrasGrav = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(73, 15));
            Decimal movViaticosGrav = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(88, 15));
            Decimal matDidacticoGrav = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(103, 15));
            Decimal remuneracionExenta = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(118, 15));
            Decimal remExentaHsExtras = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(133, 15));
            Decimal movViaticosExenta = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(148, 15));
            Decimal matDidacticoExento = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(163, 15));
            Decimal remOtrosEmpRemBruta = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(178, 15));
            Decimal remOtrosEmpRetNoHab = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(193, 15));
            Decimal remOtrosEmpSAC1Grav = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(208, 15));
            Decimal remOtrosEmpSAC2Grav = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(223, 15));
            Decimal remOtrosEmpHsExtrasGrav = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(238, 15));
            Decimal remOtrosEmpMovViatGrav = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(253, 15));
            Decimal remOtrosEmpMatDidacticoGrav = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(268, 15));
            Decimal remOtrosEmpRemExenta = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(283, 15));
            Decimal remOtrosEmpHsExtrasExenta = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(298, 15));
            Decimal remOtrosEmpMovViatExenta = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(313, 15));
            Decimal remOtrosEmpMatDidacExento = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(328, 15));
            Decimal totRemuneracionGravada = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(343, 15));
            Decimal totRemuneracionExenta = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(358, 15));
            Decimal totalRemuneraciones = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(373, 17))    ;
            Decimal retNoHabitualesExenta = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(390, 15));
            Decimal sacPrimerCuotaExenta = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(405, 15));
            Decimal sacSegCuotaExenta = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(420, 15));
            Decimal ajPerAntRemuGravada = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(435, 15));
            Decimal ajPerAntRemExenta = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(450, 15));
            Decimal remOtrosEmpRetNoHabExenta = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(455, 15));
            Decimal remOtrosEmpSAC1Exento = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(480, 15));
            Decimal RemOtrosEmpSAC2Exento = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(495, 15));
            Decimal RemOtrosEmpAjPerAntRemGravada = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(510, 15));
            Decimal RemOtrosEmpAjPerAntRemExenta = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(525, 15));
            Decimal remExentaLey27549 = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(540, 15));
            Decimal remOtrosEmpleosLey27549 = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(555, 15));
            Decimal bonoProductividadGravado = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(570, 15));
            Decimal falloCajaGravada = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(585, 15));
            Decimal similarNaturalezaGravada = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(600, 15));
            Decimal bonoProductividadExento = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(615, 15));
            Decimal falloCajaExento = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(630, 15));
            Decimal similarNaturalezaExento = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(645, 15));
            Decimal gastosTeletrabajoExento = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(660, 15));
            Decimal ley19101Exento = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(675, 15));
            Decimal RemOtrosEmpBonoProdGravado = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(690, 15));
            Decimal RemOtrosEmpFalloCajaGravado = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(705, 15));
            Decimal RemOtrosEmpSimilNaturalezaGrav = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(720, 15));
            Decimal RemOtrosEmpBonoProducExento = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(735, 15));
            Decimal RemOtrosEmpFalloCajaExento = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(750, 15));
            Decimal RemOtrosEmpSimilNatuExento = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(765, 15));
            Decimal RemOtrosEmpGastosTeletraExento = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(780, 15));
            Decimal RemOtrosEmpLey19101Exento = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(795, 15));

            // Guarda datos en Lista
            arrayEmpleado.Add(Math.Round(remBrutaGravada,2));
            arrayEmpleado.Add(Math.Round(retNoHabitualesGravadas, 2));
            arrayEmpleado.Add(Math.Round(sacPrimerCuotaGrav, 2));
            arrayEmpleado.Add(Math.Round(sacSegCuotaGrav, 2));
            arrayEmpleado.Add(Math.Round(hsExtrasGrav, 2));
            arrayEmpleado.Add(Math.Round(movViaticosGrav, 2));
            arrayEmpleado.Add(Math.Round(matDidacticoGrav, 2));
            arrayEmpleado.Add(Math.Round(remuneracionExenta, 2));
            arrayEmpleado.Add(Math.Round(remExentaHsExtras, 2));
            arrayEmpleado.Add(Math.Round(movViaticosExenta, 2));
            arrayEmpleado.Add(Math.Round(matDidacticoExento, 2));
            arrayEmpleado.Add(Math.Round(remOtrosEmpRemBruta, 2));
            arrayEmpleado.Add(Math.Round(remOtrosEmpRetNoHab, 2));
            arrayEmpleado.Add(Math.Round(remOtrosEmpSAC1Grav, 2));
            arrayEmpleado.Add(Math.Round(remOtrosEmpSAC2Grav, 2));
            arrayEmpleado.Add(Math.Round(remOtrosEmpHsExtrasGrav, 2));
            arrayEmpleado.Add(Math.Round(remOtrosEmpMovViatGrav, 2));
            arrayEmpleado.Add(Math.Round(remOtrosEmpMatDidacticoGrav, 2));
            arrayEmpleado.Add(Math.Round(remOtrosEmpRemExenta, 2));
            arrayEmpleado.Add(Math.Round(remOtrosEmpHsExtrasExenta, 2));
            arrayEmpleado.Add(Math.Round(remOtrosEmpMovViatExenta, 2));
            arrayEmpleado.Add(Math.Round(remOtrosEmpMatDidacExento, 2));
            arrayEmpleado.Add(Math.Round(totRemuneracionGravada, 2));
            arrayEmpleado.Add(Math.Round(totRemuneracionExenta, 2));
            arrayEmpleado.Add(Math.Round(totalRemuneraciones, 2));
            arrayEmpleado.Add(Math.Round(retNoHabitualesExenta, 2));
            arrayEmpleado.Add(Math.Round(sacPrimerCuotaExenta, 2));
            arrayEmpleado.Add(Math.Round(sacSegCuotaExenta, 2));
            arrayEmpleado.Add(Math.Round(ajPerAntRemuGravada, 2));
            arrayEmpleado.Add(Math.Round(ajPerAntRemExenta, 2));
            arrayEmpleado.Add(Math.Round(remOtrosEmpRetNoHabExenta, 2));
            arrayEmpleado.Add(Math.Round(remOtrosEmpSAC1Exento, 2));
            arrayEmpleado.Add(Math.Round(RemOtrosEmpSAC2Exento, 2));
            arrayEmpleado.Add(Math.Round(RemOtrosEmpAjPerAntRemGravada, 2));
            arrayEmpleado.Add(Math.Round(RemOtrosEmpAjPerAntRemExenta, 2));
            arrayEmpleado.Add(Math.Round(remExentaLey27549, 2));
            arrayEmpleado.Add(Math.Round(remOtrosEmpleosLey27549, 2));
            arrayEmpleado.Add(Math.Round(bonoProductividadGravado, 2));
            arrayEmpleado.Add(Math.Round(falloCajaGravada, 2));
            arrayEmpleado.Add(Math.Round(similarNaturalezaGravada, 2));
            arrayEmpleado.Add(Math.Round(bonoProductividadExento, 2));
            arrayEmpleado.Add(Math.Round(falloCajaExento, 2));
            arrayEmpleado.Add(Math.Round(similarNaturalezaExento, 2));
            arrayEmpleado.Add(Math.Round(gastosTeletrabajoExento, 2));
            arrayEmpleado.Add(Math.Round(ley19101Exento, 2));
            arrayEmpleado.Add(Math.Round(RemOtrosEmpBonoProdGravado, 2));
            arrayEmpleado.Add(Math.Round(RemOtrosEmpFalloCajaGravado, 2));
            arrayEmpleado.Add(Math.Round(RemOtrosEmpSimilNaturalezaGrav, 2));
            arrayEmpleado.Add(Math.Round(RemOtrosEmpBonoProducExento, 2));
            arrayEmpleado.Add(Math.Round(RemOtrosEmpFalloCajaExento, 2));
            arrayEmpleado.Add(Math.Round(RemOtrosEmpSimilNatuExento, 2));
            arrayEmpleado.Add(Math.Round(RemOtrosEmpGastosTeletraExento, 2));
            arrayEmpleado.Add(Math.Round(RemOtrosEmpLey19101Exento, 2));
        }

        /// <summary>
        /// Extrae los datos, desde un objeto tipo List, del registro 04.
        /// </summary>
        /// <param name="arrayEmpleado">List. Guarda en el list los datos que extrae.</param>
        /// <param name="archivoTexto">List. Lista de donde extrae los datos.</param>
        /// <param name="i">Int. Indica el indice del List -> archivoTexto.</param>
        protected void LeerRegistro04(List<Object> arrayEmpleado, List<string> archivoTexto, int i, byte version)
        {
            Decimal serviciosEducativos = 0;

            // Tercer línea de registro correspondiente al empleado

            Decimal aporteJubilatorio = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(13, 15));
            Decimal aporteJubilatorioOtrosEmp = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(28, 15));
            Decimal aporteObraSocial = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(43, 15));
            Decimal aporteObraSocialOtrosEmp = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(58, 15));
            Decimal cuotaSindical = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(73, 15));
            Decimal cuotaSindicalOtrosEmpleos = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(88, 15));
            Decimal cuotaMedicoAsistencial = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(103, 15));
            Decimal primasSeguroVida = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(118, 15));
            Decimal seguroMuerteMixta = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(133, 15));
            Decimal seguroRetiroPrivado = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(148, 15));
            Decimal cuotaparteFCI = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(163, 15));
            Decimal gastosSepelio = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(178, 15));
            Decimal viajanteComercio = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(193, 15));
            Decimal donaciones = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(208, 15));
            Decimal dtosObligatorios = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(223, 15));
            Decimal honorariosServMedica = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(238, 15));
            Decimal intCreditoHipotecario = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(253, 15));
            Decimal fondoRiesgoSGR = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(269, 15));
            Decimal otrasDeducCajaComp = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(283, 15));
            Decimal alquileres = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(298, 15));
            Decimal empleadosDomestico = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(313, 15));
            Decimal viaticos = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(328, 15));
            Decimal indumentaria = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(343, 15));
            Decimal otrasDeducciones = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(358, 15));
            Decimal totalDeducciones = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(373, 17));
            Decimal otrasDeducApJub = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(390, 15));
            Decimal otrasDeducCajaProvNac = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(405, 15));
            Decimal otrasDeducRG2442 = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(420, 15));
            Decimal otrasDeducFondoCompPrev = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(435, 15));
            
            // Agregado versión 6
            if(version == 6)
            {
                serviciosEducativos = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(450, 15));
            }

            // Guarda datos en listado.
            arrayEmpleado.Add(Math.Round(aporteJubilatorio, 2));
            arrayEmpleado.Add(Math.Round(aporteJubilatorioOtrosEmp, 2));
            arrayEmpleado.Add(Math.Round(aporteObraSocial, 2));
            arrayEmpleado.Add(Math.Round(aporteObraSocialOtrosEmp, 2));
            arrayEmpleado.Add(Math.Round(cuotaSindical, 2));
            arrayEmpleado.Add(Math.Round(cuotaSindicalOtrosEmpleos, 2));
            arrayEmpleado.Add(Math.Round(cuotaMedicoAsistencial, 2));
            arrayEmpleado.Add(Math.Round(primasSeguroVida, 2));
            arrayEmpleado.Add(Math.Round(seguroMuerteMixta, 2));
            arrayEmpleado.Add(Math.Round(seguroRetiroPrivado, 2));
            arrayEmpleado.Add(Math.Round(cuotaparteFCI, 2));
            arrayEmpleado.Add(Math.Round(gastosSepelio, 2));
            arrayEmpleado.Add(Math.Round(viajanteComercio, 2));
            arrayEmpleado.Add(Math.Round(donaciones, 2));
            arrayEmpleado.Add(Math.Round(dtosObligatorios, 2));
            arrayEmpleado.Add(Math.Round(honorariosServMedica, 2));
            arrayEmpleado.Add(Math.Round(intCreditoHipotecario, 2));
            arrayEmpleado.Add(Math.Round(fondoRiesgoSGR, 2));
            arrayEmpleado.Add(Math.Round(otrasDeducCajaComp, 2));
            arrayEmpleado.Add(Math.Round(alquileres, 2));
            arrayEmpleado.Add(Math.Round(empleadosDomestico, 2));
            arrayEmpleado.Add(Math.Round(viaticos, 2));
            arrayEmpleado.Add(Math.Round(indumentaria, 2));
            arrayEmpleado.Add(Math.Round(otrasDeducciones, 2));
            arrayEmpleado.Add(Math.Round(totalDeducciones, 2));
            arrayEmpleado.Add(Math.Round(otrasDeducApJub, 2));
            arrayEmpleado.Add(Math.Round(otrasDeducCajaProvNac, 2));
            arrayEmpleado.Add(Math.Round(otrasDeducRG2442, 2));
            arrayEmpleado.Add(Math.Round(otrasDeducFondoCompPrev, 2));

            // Agregado versión 6
            if (version == 6)
            {
                arrayEmpleado.Add(serviciosEducativos);
            }            
        }

        /// <summary>
        /// Extrae los datos, desde un objeto tipo List, del registro 05.
        /// </summary>
        /// <param name="arrayEmpleado">List. Guarda en el list los datos que extrae.</param>
        /// <param name="archivoTexto">List. Lista de donde extrae los datos.</param>
        /// <param name="i">Int. Indica el indice del List -> archivoTexto.</param>
        protected void LeerRegistro05Version5(List<Object> arrayEmpleado, List<string> archivoTexto, int i)
        {
            // Cuarta línea de registro correspondiente al empleado
            Decimal gananciaNoImponible = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(13, 15));
            Decimal deduccionEspecial = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(28, 15));
            Decimal deduccionEspecifica = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(43, 15));
            Decimal conyuge = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(58, 15));
            byte cantidadHijos = byte.Parse(archivoTexto[i].Substring(73, 2));
            Decimal hijos = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(75, 15));
            Decimal totalCargasFamilia = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(90, 15));
            Decimal totalDeduccionesArt30 = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(105, 15));
            Decimal remSujetaImpAntes = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(120, 15));
            Decimal deduccionIncA = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(135, 15));
            Decimal deduccionIncB = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(150, 15));
            Decimal remSujetaImpuesto = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(165, 15));
            byte cantHijosInca = byte.Parse(archivoTexto[i].Substring(180, 2));
            Decimal hijosIncapacitados = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(182, 15));
            Decimal dedIncremPrimerParrafo = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(197, 15));
            Decimal dedIncremSegundoParrafo = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(212, 15));

            // Guarda datos en lista.
            arrayEmpleado.Add(gananciaNoImponible);
            arrayEmpleado.Add(deduccionEspecial);
            arrayEmpleado.Add(deduccionEspecifica);
            arrayEmpleado.Add(conyuge);
            arrayEmpleado.Add(cantidadHijos);
            arrayEmpleado.Add(hijos);
            arrayEmpleado.Add(totalCargasFamilia);
            arrayEmpleado.Add(totalDeduccionesArt30);
            arrayEmpleado.Add(remSujetaImpAntes);
            arrayEmpleado.Add(deduccionIncA);
            arrayEmpleado.Add(deduccionIncB);
            arrayEmpleado.Add(remSujetaImpuesto);
            arrayEmpleado.Add(cantHijosInca);
            arrayEmpleado.Add(hijosIncapacitados);
            arrayEmpleado.Add(dedIncremPrimerParrafo);
            arrayEmpleado.Add(dedIncremSegundoParrafo);
        }

        /// <summary>
        /// Guarda los registros tipo 05 para la versión 6.
        /// </summary>
        /// <param name="arrayEmpleado">List. Guarda en el list los datos que extrae.</param>
        /// <param name="archivoTexto">List. Lista de donde extrae los datos.</param>
        /// <param name="i">Int. Indica el indice del List -> archivoTexto.</param>
        protected void LeerRegistro05Version6(List<Object> arrayEmpleado, List<string> archivoTexto, int i)
        {
            // Cuarta línea de registro correspondiente al empleado
            Decimal gananciaNoImponible = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(13, 15));
            Decimal deduccionEspecial = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(28, 15));
            Decimal deduccionEspecifica = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(43, 15));
            Decimal conyuge = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(58, 15));
            Byte hijosAlCincuenta = Byte.Parse(archivoTexto[i].Substring(73, 2));
            Decimal hijos = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(75, 15));
            Decimal totalCargasFamilia = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(90, 15));
            Decimal totalDeduccionesArt30 = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(105, 15));
            Decimal remSujImpArt46 = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(120, 15));
            Decimal gni = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(135, 15));
            Decimal de = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(150, 15));
            Decimal remSujImp = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(165, 15));
            Byte hijoIncAlCincuenta = Byte.Parse(archivoTexto[i].Substring(180, 2));
            Decimal hijosInc = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(182, 15));
            Decimal dedEspIncPrimeraParte = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(197, 15));
            Decimal dedEspIncSegundaParte = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(212, 15));
            Byte hijosAlCien = Byte.Parse(archivoTexto[i].Substring(227, 2));
            Byte hijosIncAlCien = Byte.Parse(archivoTexto[i].Substring(229, 2));
            Byte hijosEduAlCincuenta = Byte.Parse(archivoTexto[i].Substring(231, 2));
            Byte hijosEduAlCien = Byte.Parse(archivoTexto[i].Substring(233, 2));


            // Guarda datos en lista.
            arrayEmpleado.Add(gananciaNoImponible);
            arrayEmpleado.Add(deduccionEspecial);
            arrayEmpleado.Add(deduccionEspecifica);
            arrayEmpleado.Add(conyuge);
            arrayEmpleado.Add(hijosAlCincuenta);
            arrayEmpleado.Add(hijos);
            arrayEmpleado.Add(totalCargasFamilia);
            arrayEmpleado.Add(totalDeduccionesArt30);
            arrayEmpleado.Add(remSujImpArt46);
            arrayEmpleado.Add(gni);
            arrayEmpleado.Add(de);
            arrayEmpleado.Add(remSujImp);
            arrayEmpleado.Add(hijoIncAlCincuenta);
            arrayEmpleado.Add(hijosInc);
            arrayEmpleado.Add(dedEspIncPrimeraParte);
            arrayEmpleado.Add(dedEspIncSegundaParte);
            arrayEmpleado.Add(hijosAlCien);
            arrayEmpleado.Add(hijosIncAlCien);
            arrayEmpleado.Add(hijosEduAlCincuenta);
            arrayEmpleado.Add(hijosEduAlCien);            
        }

        /// <summary>
        /// Extrae los datos, desde un objeto tipo List, del registro 06.
        /// </summary>
        /// <param name="arrayEmpleado">List. Guarda en el list los datos que extrae.</param>
        /// <param name="archivoTexto">List. Lista de donde extrae los datos.</param>
        /// <param name="i">Int. Indica el indice del List -> archivoTexto.</param>
        protected void LeerRegistro06(List<Object> arrayEmpleado, List<string> archivoTexto, int i)
        {
            // Lee los datos correspondientes al registro 06.
            Int32 alicuotaArt94 = Int32.Parse(archivoTexto[i].Substring(13, 1));
            Int32 alicuotaAplicable = Int32.Parse(archivoTexto[i].Substring(14, 1));
            Decimal impuestoDeterminado = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(15, 15));
            Decimal impuestoRetenido = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(30, 15));
            Decimal pagosCuenta = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(45, 15));
            Decimal saldo = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(60, 15));
            Decimal pagCtaCreditosDebitos = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(75, 15));
            Decimal pagCtaRetAduaneras = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(90, 15));
            Decimal pagCtaRG3819 = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(105, 15));
            Decimal pagCtaLey27424 = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(120, 15));
            Decimal pagCtaIncA = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(135, 15));
            Decimal pagCtaIncB = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(150, 15));
            Decimal pagCtaIncC = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(165, 15));
            Decimal pagCtaIncD = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(180, 15));
            Decimal pagCtaIncE = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(195, 15));
            Decimal pagCtaCredFondo = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(210, 15));
            Decimal pagCtaRG3819II = ConvertDecimal.StringToDecimal(archivoTexto[i].Substring(225, 15));

            // Guarda datos en lista.
            arrayEmpleado.Add(alicuotaArt94);
            arrayEmpleado.Add(alicuotaAplicable);
            arrayEmpleado.Add(impuestoDeterminado);
            arrayEmpleado.Add(impuestoRetenido);
            arrayEmpleado.Add(pagosCuenta);
            arrayEmpleado.Add(saldo);
            arrayEmpleado.Add(pagCtaCreditosDebitos);
            arrayEmpleado.Add(pagCtaRetAduaneras);
            arrayEmpleado.Add(pagCtaRG3819);
            arrayEmpleado.Add(pagCtaLey27424);
            arrayEmpleado.Add(pagCtaIncA);
            arrayEmpleado.Add(pagCtaIncB);
            arrayEmpleado.Add(pagCtaIncC);
            arrayEmpleado.Add(pagCtaIncD);
            arrayEmpleado.Add(pagCtaIncE);
            arrayEmpleado.Add(pagCtaCredFondo);
            arrayEmpleado.Add(pagCtaRG3819II);
        }
    }
}