/*
* PRÁCTICA.............: Práctica 6.
* NOMBRE Y APELLIDOS...: Mario Olivera Castañeda
* CURSO Y GRUPO........: 2o Desarrollo de Interfaces
* TÍTULO DE LA PRÁCTICA: Ordenación y Mezcla de Ficheros.
* FECHA DE ENTREGA.....: 28 de Noviembre de 2018
*/

using System.Collections.Generic;
using System;

namespace Practica6
{
    class Aplicacion
    {
        #region Main
        static void Main(string[] args)
        {
            List<string> nombresArchivos = new List<string>();
            bool control = false;
            string nombreArchivo1 = Auxiliar.LeerCadena("Nombre del archivo 1o a crear: ", 1, 10);
            nombreArchivo1 += ".txt";
            nombresArchivos.Add(nombreArchivo1);
            string nombreArchivo2;
            string nombreArchivo3;
            do
            {
                control = false;
                nombreArchivo2 = Auxiliar.LeerCadena("Nombre del archivo 2o a crear: ", 1, 10);
                nombreArchivo2 += ".txt";
                for (int i = 0; i < nombresArchivos.Count; i++)
                {
                    if (nombresArchivos[i].Equals(nombreArchivo2))
                    {
                        control = true;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Error, nombre de archivo ya existe");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Por favor introduzca un nombre de archivo diferente\n");
                    }
                }
            }
            while (control == true);
            nombresArchivos.Add(nombreArchivo2);
            do
            {
                control = false;
                nombreArchivo3 = Auxiliar.LeerCadena("Nombre del archivo de fusión: ", 1, 10);
                nombreArchivo3 += ".txt";
                for (int i = 0; i < nombresArchivos.Count; i++)
                {
                    if (nombresArchivos[i].Equals(nombreArchivo3))
                    {
                        control = true;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Error, nombre de archivo ya existe");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Por favor introduzca un nombre de archivo diferente\n");
                    }
                }
            }
            while (control == true);
            nombresArchivos.Add(nombreArchivo3);
            OperacionesArchivos.CrearFicheroPersona(nombreArchivo1, nombreArchivo2);
            OperacionesArchivos.OrdenarArchivo(nombreArchivo1);
            OperacionesArchivos.CrearFicheroPersona(nombreArchivo2, nombreArchivo1);
            OperacionesArchivos.OrdenarArchivo(nombreArchivo2);
            OperacionesArchivos.ArchivoFusion(nombreArchivo1, nombreArchivo2, nombreArchivo3);
        }
        #endregion
    }
}
