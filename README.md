# PyTFormulario1357
Con este programa, el usuario podra generar las presentaciones correspondientes al impuesto a las ganancias en la página de la AFIP (Argentina).


##Descripción

“PyT – Formulario 1357” permite generar el archivo a presentar en la declaración de ganancias que se realiza a la AFIP. El procedimiento para realizar el archivo txt es muy sencillo. Primero, se debe completar la información correspondiente a la presentación, en un archivo Excel, y luego el programa genera el txt. Vale la pena aclarar que, para completar la información en el archivo Excel, el usuario va a contar con template, dentro de la carpeta del programa, el cual le va a permitir completar los datos. El programa soporta las versiones 5 y 6 de la declaración y se recomienda al usuario leer la documentación oficial para saber los datos a completar en orden de evitar errores [Ver aquí].

##Lectura archivo excel a TXT - Versión 6

Este proceso genera el archivo txt a presentar a la AFIP. Para esto, primero se deben completar los datos correspondientes al primer registro (CUIT, periodo informado, secuencia y tipo de presentación). Luego, el programa solicitara que el usuario seleccione el archivo Excel (utilizar template de la versión 6) a procesar. Una vez realizado, se generará el archivo correspondiente a la presentación. Cabe aclarar que, si el usuario no especifico el directorio de salida para la generación de archivos (Configuración -> Directorio), el programa lo hará el directorio raíz del mismo.

##Lectura archivo excel a TXT - Versión 5

Tiene los mismos requisitos que el proceso anterior, con la salvedad que debe utilizarse el template correspondiente a la versión 5.

##Lectura archivo TXT a excel - Versión 5 / 6

Con esta opción podrás realizar el proceso inverso. Es decir, pasar la información del archivo de la declaración a un archivo Excel. Esto, le permitirá al usuario corregir probables errores que surjan en la presentación, sin tener que modificar la información desde el archivo TXT. Una vez realizas las modificaciones, el usuario podrá utilizar el mismo archivo para generar nuevamente la presentación.
