/*
* PRÁCTICA.............: Práctica 6.
* NOMBRE Y APELLIDOS...: Mario Olivera Castañeda
* CURSO Y GRUPO........: 2o Desarrollo de Interfaces
* TÍTULO DE LA PRÁCTICA: Ordenación y Mezcla de Ficheros.
* FECHA DE ENTREGA.....: 28 de Noviembre de 2018
*/
using System;

namespace Practica6
{
    class Auxiliar
    {
        #region Métodos
        #region LeerCadena
        public static string LeerCadena(string mensaje, int minimo, int maximo)
        {
            string introducir;
            bool correcto = false;
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(mensaje);
                introducir = Console.ReadLine();
                if (introducir.Equals(""))
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error al dejar sin contestar");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Por favor conteste el apartado\n");
                }
                else
                {
                    if (introducir.Length > maximo || introducir.Length < minimo)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Error, valor introducido fuera de rango");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Por favor introduzca un valor entre " + minimo + " y " + maximo + " de caracteres\n");
                    }
                    else
                    {
                        correcto = true;
                    }
                }
            }
            while (!correcto);
            return introducir;
        }
        #endregion
        #region LeerEnteroPositivo
        public static int LeerEnteroPositivo(string mensaje, int minimo, int maximo)
        {
            bool salir = false;
            int comprobar;
            string introducir;
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(mensaje);
                introducir = Console.ReadLine();
                if (!(int.TryParse(introducir, out comprobar)))
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error al introducir");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Por favor introduzca un número entero\n");
                }
                else
                {
                    if (introducir.Length > maximo || introducir.Length < minimo)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Error, valor introducido fuera de rango");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Por favor introduzca un valor entre " + minimo + " y " + maximo + "\n");
                    }
                    else
                    {
                        salir = true;
                    }
                }
            }
            while (!salir);
            return int.Parse(introducir);
        }
        #endregion
        #region LeerCadenaSinNumero
        public static string LeerCadenaSinNumero(string mensaje, int minimo, int maximo)
        {
            string introducir;
            bool correcto = false;
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(mensaje);
                introducir = Console.ReadLine();
                if (introducir.Equals(""))
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error al dejar sin contestar");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Por favor conteste el apartado\n");
                }
                else
                {
                    if (introducir.Length > maximo || introducir.Length < minimo)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Error, valor introducido fuera de rango");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Por favor introduzca un valor entre " + minimo + " y " + maximo + " de caracteres\n");
                    }
                    else
                    {
                        if (ComprobarNombre(introducir) == false)
                        {
                            correcto = true;
                        }
                        else
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Error al introducir");
                        }
                    }
                }
            }
            while (!correcto);
            return introducir;
        }
        #endregion
        #region ComprobarNombre
        static bool ComprobarNombre(string nombre)
        {
            bool checkChar = false;
            foreach (char c in nombre)
            {
                if (!Char.IsLetter(c) && !Char.IsWhiteSpace(c))
                {
                    checkChar = true;
                }
            }
            return checkChar;
        }
        #endregion
        #endregion
    }
}
