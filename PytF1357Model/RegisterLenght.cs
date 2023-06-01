using System;

namespace PytF1357Model
{
    internal class RegisterLenght
    {
        public string ConvertToRegisterLenght(object obj, int lenght)
        {
            // Convierte el objeto recibo a string.
            string toConvert = obj.ToString();

            // Elimina caracteres de tipo "." y ","
            if (toConvert.Contains(","))
            {
                toConvert = toConvert.Replace(",", "");
            }

            if (toConvert.Contains("."))
            {
                toConvert = toConvert.Replace(".", "");
            }

            // Verifica que el largo del registro a convertir no sea mas grande
            // que el especificado.

            // Implementar un log para verificar errores.
            
            // Convierte el objeto al formato de registro del txt.
            while (toConvert.Length < lenght)
            {
                toConvert = "0" + toConvert;
            }

            return toConvert;
        }
    }
}
