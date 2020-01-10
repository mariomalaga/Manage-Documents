/*
* PRÁCTICA.............: Práctica 6.
* NOMBRE Y APELLIDOS...: Mario Olivera Castañeda
* CURSO Y GRUPO........: 2o Desarrollo de Interfaces
* TÍTULO DE LA PRÁCTICA: Ordenación y Mezcla de Ficheros.
* FECHA DE ENTREGA.....: 28 de Noviembre de 2018
*/
using System;
using System.Collections.Generic;

namespace Practica6
{
    class OperacionesArchivos
    {
        #region Métodos
        #region CrearFicheroPersona
        public static void CrearFicheroPersona(string nombreArchivo1, string nombreArchivo2)
        {
            ArchivoPersona archivoPersona = new ArchivoPersona(nombreArchivo1);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nCreación del archivo: " + nombreArchivo1);
            archivoPersona.CrearArchivo();
            bool salir = false;
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n¿Quiere grabar registros en " + nombreArchivo1 + "? (s/n): ");
                string respuesta = Console.ReadLine();
                if (respuesta.Equals("s"))
                {
                    bool comprobar = false;
                    int dni = Auxiliar.LeerEnteroPositivo("Teclee el dni: ", 8, 8);
                    string nombre = Auxiliar.LeerCadenaSinNumero("Teclee mombre: ", 3, 15);
                    Persona persona = new Persona(dni, nombre);
                    List<Persona> personas = RellenarComprobante(nombreArchivo1, nombreArchivo2);
                    if (personas.Count > 0)
                    {
                        for (int i = 0; i < personas.Count; i++)
                        {
                            if (personas[i].Dni == persona.Dni)
                            {
                                comprobar = true;
                            }
                        }
                    }
                    if (comprobar == true)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Error, dni introducido ya en archivo");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Por favor introduzca un dni que no esté en el archivo\n");
                    }
                    else
                    {
                        archivoPersona.Grabar(persona);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Dato guardado correctamente\n");
                    }
                }
                else if (respuesta.Equals("n"))
                {
                    salir = true;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Pulsar 'Enter' para continuar");
                    Console.ReadLine();
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error, introduzca 's' o 'n'");
                }
            }
            while (salir == false);          
        }
        #endregion
        #region OrdenarArchivo
        public static void OrdenarArchivo(string nombreArchivo)
        {
            ArchivoPersona archivoPersona = new ArchivoPersona(nombreArchivo);
            List<Persona> personas = archivoPersona.LeerArchivo();
            personas.Sort();
            archivoPersona.BorrarCrearArchivo();
            for (int i = 0; i < personas.Count; i++)
            {
                archivoPersona.Grabar(personas[i]);
            }
        }
        #endregion
        #region ArchivoFusion
        public static void ArchivoFusion(string nombreArchivo1, string nombreArchivo2, string nombreFusion)
        {
            ArchivoPersona archivoPersona1 = new ArchivoPersona(nombreArchivo1);
            List<Persona> personas1 = archivoPersona1.LeerArchivo();
            ArchivoPersona archivoPersona2 = new ArchivoPersona(nombreArchivo2);
            List<Persona> personas2 = archivoPersona2.LeerArchivo();
            ArchivoPersona archivoFusion = new ArchivoPersona(nombreFusion);
            archivoFusion.CrearArchivo();
            Console.Clear();
            Console.WriteLine("\nCreación del archivo: " + nombreFusion);
            Console.WriteLine("\nGuardando datos en :" + nombreFusion);
            List<Persona> fusion = new List<Persona>();
            for (int i = 0; i < personas1.Count; i++)
            {
                fusion.Add(personas1[i]);
            }
            for (int i = 0; i < personas2.Count; i++)
            {
                fusion.Add(personas2[i]);
            }
            for (int i = 0; i < fusion.Count; i++)
            {
                archivoFusion.Grabar(fusion[i]);
            }
            OrdenarArchivo(nombreFusion);
            fusion = archivoFusion.LeerArchivo();
            Console.WriteLine("\nContenido del archivo resultante de la fusión\n");
            for (int i = 0; i < fusion.Count; i++)
            {
                string personaEscribir = fusion[i].ToString();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(personaEscribir);
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nFin del listado");
            Console.WriteLine("Pulsar 'Enter' para finalizar el programa");
            Console.ReadLine();
        }
        #endregion
        #region RellenarComprobante
        public static List<Persona> RellenarComprobante(string nombreArchivo1, string nombreArchivo2){
            ArchivoPersona archivoPersona1 = new ArchivoPersona(nombreArchivo1);
            List<Persona> personas1 = archivoPersona1.LeerArchivo();
            ArchivoPersona archivoPersona2 = new ArchivoPersona(nombreArchivo2);
            List<Persona> personas2 = archivoPersona2.LeerArchivo();
            List<Persona> comprobar = new List<Persona>();
            for (int i = 0; i < personas1.Count; i++)
            {
                comprobar.Add(personas1[i]);
            }
            for (int i = 0; i < personas2.Count; i++)
            {
                comprobar.Add(personas2[i]);
            }
            return comprobar;
        }
        #endregion
        #endregion
    }
}
