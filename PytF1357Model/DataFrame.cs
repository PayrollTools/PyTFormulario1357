using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PytF1357Model
{
    internal class DataFrame
    {
        
        internal System.Data.DataTable tablaDatos = new System.Data.DataTable();

        /// <summary>
        /// Se generan las columnas para el DataTable con el cual se guardaran los datos en el archivo 
        /// excel.
        /// </summary>
        internal void CreateColumns(byte version)
        {
            // Faltan agregar los registros de la versión 6.

            // Registro 02
            tablaDatos.Columns.Add("CUIL", typeof(long));
            tablaDatos.Columns.Add("Periodo desde", typeof(string));
            tablaDatos.Columns.Add("Periodo hasta", typeof(string));
            tablaDatos.Columns.Add("Meses", typeof(byte));
            tablaDatos.Columns.Add("Beneficio", typeof(byte));
            tablaDatos.Columns.Add("Transporte larga distancia", typeof(byte));
            tablaDatos.Columns.Add("Ley n° 27424", typeof(byte));
            tablaDatos.Columns.Add("Ley n° 27549", typeof(byte));
            tablaDatos.Columns.Add("Ley n° 27555", typeof(byte));
            tablaDatos.Columns.Add("Ley n° 19101", typeof(byte));
            //Agregado versión 6.
            if (version == 6)
            {
                tablaDatos.Columns.Add("Convenio 40/1989", typeof(byte));
            }

            // Registro 03
            tablaDatos.Columns.Add("Rem. gravada", typeof(decimal));
            tablaDatos.Columns.Add("Ret. no hab", typeof(decimal));
            tablaDatos.Columns.Add("SAC primer cuota", typeof(decimal));
            tablaDatos.Columns.Add("SAC seg. cuota", typeof(decimal));
            tablaDatos.Columns.Add("HE gravadas", typeof(decimal));
            tablaDatos.Columns.Add("Mov y viaticos", typeof(decimal));
            tablaDatos.Columns.Add("Material didactico", typeof(decimal));
            tablaDatos.Columns.Add("Rem. no alcanzada", typeof(decimal));
            tablaDatos.Columns.Add("Rem. exenta HE", typeof(decimal));
            tablaDatos.Columns.Add("Mov y viaticos - Exento", typeof(decimal));
            tablaDatos.Columns.Add("Mat. didac. - Exento", typeof(decimal));
            tablaDatos.Columns.Add("OE - Rem. Gravada", typeof(decimal));
            tablaDatos.Columns.Add("OE - Ret. no hab.", typeof(decimal));
            tablaDatos.Columns.Add("OE - SAC primer cuota", typeof(decimal));
            tablaDatos.Columns.Add("OE - SAC seg. cuota", typeof(decimal));
            tablaDatos.Columns.Add("OE - HE gravadas", typeof(decimal));
            tablaDatos.Columns.Add("OE - mov y viaticos", typeof(decimal));
            tablaDatos.Columns.Add("OE - material didactico", typeof(decimal));
            tablaDatos.Columns.Add("OE - rem. no alc", typeof(decimal));
            tablaDatos.Columns.Add("OE - HE exentas", typeof(decimal));
            tablaDatos.Columns.Add("OE - mov. y viaticos exento", typeof(decimal));
            tablaDatos.Columns.Add("OE - mat. didactico exento", typeof(decimal));
            tablaDatos.Columns.Add("Remuneración gravada", typeof(decimal));
            tablaDatos.Columns.Add("Remuneración no gravada", typeof(decimal));
            tablaDatos.Columns.Add("Total remuneraciones", typeof(decimal));
            tablaDatos.Columns.Add("Ret. no hab. exentas", typeof(decimal));
            tablaDatos.Columns.Add("SAC primer cuota exenta", typeof(decimal));
            tablaDatos.Columns.Add("SAC seg. cuota exenta", typeof(decimal));
            tablaDatos.Columns.Add("Aj. Rem. gravadas", typeof(decimal));
            tablaDatos.Columns.Add("Aj. Rem. exenta", typeof(decimal));
            tablaDatos.Columns.Add("OE - Ret. no hab. exento", typeof(decimal));
            tablaDatos.Columns.Add("OE - SAC primer cuota exenta", typeof(decimal));
            tablaDatos.Columns.Add("OE - SAC seg. cuota exenta", typeof(decimal));
            tablaDatos.Columns.Add("OE - Aj - Rem. gravada", typeof(decimal));
            tablaDatos.Columns.Add("OE - Aj- Ret. no Hab", typeof(decimal));
            tablaDatos.Columns.Add("Rem. exenta Ley 27549", typeof(decimal));
            tablaDatos.Columns.Add("OE - Ley 27549", typeof(decimal));
            tablaDatos.Columns.Add("Bono prod. grav.", typeof(decimal));
            tablaDatos.Columns.Add("Fallo caja grav.", typeof(decimal));
            tablaDatos.Columns.Add("simil nat. grav.", typeof(decimal));
            tablaDatos.Columns.Add("Bono prod. exento", typeof(decimal));
            tablaDatos.Columns.Add("Fallo caja exento", typeof(decimal));
            tablaDatos.Columns.Add("Simil nat. exento", typeof(decimal));
            tablaDatos.Columns.Add("Gastos teletrabajo exento", typeof(decimal));
            tablaDatos.Columns.Add("Ley 19101", typeof(decimal));
            tablaDatos.Columns.Add("OE - bono prod. grav.", typeof(decimal));
            tablaDatos.Columns.Add("OE - Fallo caja grav.", typeof(decimal));
            tablaDatos.Columns.Add("OE - Simil nat. grav.", typeof(decimal));
            tablaDatos.Columns.Add("OE - Bono prod. exento", typeof(decimal));
            tablaDatos.Columns.Add("OE - Fallo caja exento", typeof(decimal));
            tablaDatos.Columns.Add("OE - Simil nat. exento", typeof(decimal));
            tablaDatos.Columns.Add("OE - Teletrabajo exento", typeof(decimal));
            tablaDatos.Columns.Add("OE - Ley 19101 exento", typeof(decimal));

            // Registro 04
            tablaDatos.Columns.Add("Jubilación", typeof(decimal));
            tablaDatos.Columns.Add("OE - Jubilación", typeof(decimal));
            tablaDatos.Columns.Add("Ap. Obra social", typeof(decimal));
            tablaDatos.Columns.Add("OE - Ap. obra social", typeof(decimal));
            tablaDatos.Columns.Add("Cuota sindical", typeof(decimal));
            tablaDatos.Columns.Add("OE - Cuota sindical", typeof(decimal));
            tablaDatos.Columns.Add("Cuota med. asist.", typeof(decimal));
            tablaDatos.Columns.Add("Seg. muerte", typeof(decimal));
            tablaDatos.Columns.Add("Seg. muerte mixtos", typeof(decimal));
            tablaDatos.Columns.Add("Seg. ret. privados", typeof(decimal));
            tablaDatos.Columns.Add("Ad. cuotapartes FCI", typeof(decimal));
            tablaDatos.Columns.Add("Gastos sepelio", typeof(decimal));
            tablaDatos.Columns.Add("Viajantes comercio", typeof(decimal));
            tablaDatos.Columns.Add("Donaciones", typeof(decimal));
            tablaDatos.Columns.Add("Dtos. oblig. ley", typeof(decimal));
            tablaDatos.Columns.Add("Honorarios med.", typeof(decimal));
            tablaDatos.Columns.Add("Int. Cred. Hip.", typeof(decimal));
            tablaDatos.Columns.Add("Fondo de riesgo", typeof(decimal));
            tablaDatos.Columns.Add("OD - Ap. cajas comp.", typeof(decimal));
            tablaDatos.Columns.Add("Alquiler", typeof(decimal));
            tablaDatos.Columns.Add("Serv. domestico", typeof(decimal));
            tablaDatos.Columns.Add("Viaticos", typeof(decimal));
            tablaDatos.Columns.Add("Indumentaria", typeof(decimal));
            tablaDatos.Columns.Add("Otras ded.", typeof(decimal));
            tablaDatos.Columns.Add("Total deducciones", typeof(decimal));
            tablaDatos.Columns.Add("OD - Ap. jub", typeof(decimal));
            tablaDatos.Columns.Add("OD - Caja comp.", typeof(decimal));
            tablaDatos.Columns.Add("OD - RG 2442/08", typeof(decimal));
            tablaDatos.Columns.Add("OD - Fondo prev.", typeof(decimal));
            //Agregado versión 6
            if(version == 6)
            {
                tablaDatos.Columns.Add("Servicios educativos", typeof(decimal));
            }

            // Registro 05
            if(version == 5)
            {
                tablaDatos.Columns.Add("Ganan. no imp.", typeof(decimal));
                tablaDatos.Columns.Add("Ded. especial", typeof(decimal));
                tablaDatos.Columns.Add("Ded. especifica", typeof(decimal));
                tablaDatos.Columns.Add("Conyuge", typeof(decimal));
                tablaDatos.Columns.Add("Cant. hijos", typeof(string));
                tablaDatos.Columns.Add("Hijos", typeof(decimal));
                tablaDatos.Columns.Add("Tot. cargas fam.", typeof(decimal));
                tablaDatos.Columns.Add("Tot. ded. art 30", typeof(decimal));
                tablaDatos.Columns.Add("Rem. suj. imp. antes ley 27541", typeof(decimal));
                tablaDatos.Columns.Add("Ded. inc. a)", typeof(decimal));
                tablaDatos.Columns.Add("Ded. inc. c)", typeof(decimal));
                tablaDatos.Columns.Add("Rem. suj. imp.", typeof(decimal));
                tablaDatos.Columns.Add("Cant. hijos inc.", typeof(string));
                tablaDatos.Columns.Add("Hijos inc.", typeof(decimal));
                tablaDatos.Columns.Add("Ded. esp. inc. primera parte", typeof(decimal));
                tablaDatos.Columns.Add("Ded. esp. inc. seg. parte", typeof(decimal));
            }
            else if(version == 6)
            {
                tablaDatos.Columns.Add("Ganancia no imp.", typeof(decimal));
                tablaDatos.Columns.Add("Deduccion especial", typeof(decimal));
                tablaDatos.Columns.Add("Deduccion especifica", typeof(decimal));
                tablaDatos.Columns.Add("Cónyuge", typeof(decimal));
                tablaDatos.Columns.Add("Cant. Hijos/Hijastros al 50%", typeof(byte));
                tablaDatos.Columns.Add("Hijos/Hijastros", typeof(decimal));
                tablaDatos.Columns.Add("Total cargas de familia", typeof(decimal));
                tablaDatos.Columns.Add("Total deducciones art. 30", typeof(decimal));
                tablaDatos.Columns.Add("Rem. suj. imp. antes ded. art. 46", typeof(decimal));
                tablaDatos.Columns.Add("Ded Inc. A) ART 46 LEY 27541 (GNI)", typeof(decimal));
                tablaDatos.Columns.Add("Ded Inc. C) ART 46 LEY 27541 (DE)", typeof(decimal));
                tablaDatos.Columns.Add("Rem. sujeta a imp.", typeof(decimal));
                tablaDatos.Columns.Add("Cant. Hijos/Hijastros al 50% Inc.", typeof(byte));
                tablaDatos.Columns.Add("Hijos/Hijastros Incapacitados", typeof(decimal));
                tablaDatos.Columns.Add("Deducción Especial Incrementada Primera parte", typeof(decimal));
                tablaDatos.Columns.Add("Deducción Especial Incrementada Segunda parte", typeof(decimal));
                tablaDatos.Columns.Add("Cant. Hijos/Hijastros al 100% ", typeof(byte));
                tablaDatos.Columns.Add("Cant. Hijos/Hijastros al 100% Inc", typeof(byte));
                tablaDatos.Columns.Add("Cant. Hijos educación al 50% Inc.", typeof(byte));
                tablaDatos.Columns.Add("Cant. Hijos educación al 100% Inc.", typeof(byte));
            }

            // Registro 06
            tablaDatos.Columns.Add("Alícuota art. 94", typeof(int));
            tablaDatos.Columns.Add("Alícuota aplicable (sin HE)", typeof(int));
            tablaDatos.Columns.Add("Imp. determinado", typeof(decimal));
            tablaDatos.Columns.Add("Imp. ret.", typeof(decimal));
            tablaDatos.Columns.Add("Pagos a cta.", typeof(decimal));
            tablaDatos.Columns.Add("Saldo", typeof(decimal));
            tablaDatos.Columns.Add("PC - Imp. cred. deb", typeof(decimal));
            tablaDatos.Columns.Add("PC - Ret. ad.", typeof(decimal));
            tablaDatos.Columns.Add("PC - Resol. 3819/2015", typeof(decimal));
            tablaDatos.Columns.Add("PC - Ley 27424", typeof(decimal));
            tablaDatos.Columns.Add("PC - Ley 27541 inc a", typeof(decimal));
            tablaDatos.Columns.Add("PC - Ley 27541 inc b", typeof(decimal));
            tablaDatos.Columns.Add("PC - Ley 27541 inc c", typeof(decimal));
            tablaDatos.Columns.Add("PC - Ley 27541 inc d", typeof(decimal));
            tablaDatos.Columns.Add("PC - Ley 27541 inc e", typeof(decimal));
            tablaDatos.Columns.Add("PC - Imp. Cred. Deb -", typeof(decimal));
            tablaDatos.Columns.Add("PC - Resol. 3819/2015 -", typeof(decimal));
        }
    }
}
