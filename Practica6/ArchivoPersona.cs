/*
* PRÁCTICA.............: Práctica 6.
* NOMBRE Y APELLIDOS...: Mario Olivera Castañeda
* CURSO Y GRUPO........: 2o Desarrollo de Interfaces
* TÍTULO DE LA PRÁCTICA: Ordenación y Mezcla de Ficheros.
* FECHA DE ENTREGA.....: 28 de Noviembre de 2018
*/
using System.IO;
using System.Collections.Generic;

namespace Practica6
{
    class ArchivoPersona
    {
        #region Atributos
        private string nombreArchivo;
        #endregion
        #region Constructor
        public ArchivoPersona(string nombreArchivo)
        {
            this.nombreArchivo = nombreArchivo;
        }
        #endregion
        #region Métodos
        #region CrearArchivo
        public void CrearArchivo()
        {
            FileStream stream = new FileStream(nombreArchivo, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            CerrarWriter(writer);
        }
        #endregion
        #region Grabar
        public void Grabar(Persona persona)
        {
            StreamWriter writer = File.AppendText(nombreArchivo);
            string personaEscribir = persona.ToString();
            writer.WriteLine(personaEscribir);
            CerrarWriter(writer);
        }
        #endregion
        #region LeerArchivo
        public List<Persona> LeerArchivo()
        {
            List<Persona> personas = new List<Persona>();
            FileStream stream = new FileStream(nombreArchivo, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            string linea = "";
            while (linea != null)
            {
                linea = reader.ReadLine();
                if (linea != null)
                {
                    string[] personaLeida = linea.Split(',');
                    Persona persona = new Persona(int.Parse(personaLeida[0]), personaLeida[1]);
                    personas.Add(persona);
                }
            }
            CerrarReader(reader);
            return personas;
        }
        #endregion
        #region CerrarWriter
        public void CerrarWriter(StreamWriter writer)
        {
            writer.Close();
        }
        #endregion
        #region CerrrarReader
        public void CerrarReader(StreamReader reader)
        {
            reader.Close();
        }
        #endregion
        #region BorrarCrearArchivo
        public void BorrarCrearArchivo()
        {
            File.Delete(nombreArchivo);
            CrearArchivo();
        }
        #endregion
        #endregion
    }
}
