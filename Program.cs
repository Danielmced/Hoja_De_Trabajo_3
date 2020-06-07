using System;

namespace Hoja_de_trabajo_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroArgumentos = args.Length;
            char delimitadorDeTexto = ' ';
            string textoDocumento;
            string[] palabrasEnDocumento;
            int numeroPalabrasEnDocumento;
            string textoSalidaCSV = "";
            int contadorArgumentos = 0, contadorPalabras = 0;

               if (numeroArgumentos == 0)
               {
                   Console.WriteLine("Ningún argumento encontrado en el comando");
                   Console.WriteLine("Útilice: Hoja_de_trabajo_3 <ruta documento txt>");
                   return;
               }else{
                   do
                   {
                       textoDocumento = System.IO.File.ReadAllText(args[contadorArgumentos]);
                       palabrasEnDocumento = textoDocumento.Split(delimitadorDeTexto);
                       numeroPalabrasEnDocumento = palabrasEnDocumento.Length;
                       textoSalidaCSV = " ";
                       contadorPalabras = 0;

                       do
                       {
                           textoSalidaCSV += palabrasEnDocumento[contadorPalabras];

                           if(contadorPalabras < numeroPalabrasEnDocumento-1)
                           {
                               textoSalidaCSV += ",";
                           }
                           contadorPalabras++;
                       } while (contadorPalabras < numeroPalabrasEnDocumento);

                       Console.WriteLine("Texto en documento " + args[contadorArgumentos] + ": " + textoSalidaCSV);
                       contadorArgumentos++;
                   } while (contadorArgumentos < numeroArgumentos);
               }
        }
    }
}
