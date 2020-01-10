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
    class Persona : IComparable<Persona>
    {
        #region Atributos
        private int dni;
        private string nombre;
        #endregion
        #region CompareTo
        public int CompareTo(Persona persona)
        {
            return dni.CompareTo(persona.dni);
        }
        #endregion
        #region Constructores
        #region ConstructorParámetros
        public Persona(int dni, string nombre)
        {
            this.dni = dni;
            this.nombre = nombre;
        }
        #endregion
        #region ContructorVacío
        public Persona()
        {
        }
        #endregion
        #endregion
        #region Métodos
        #region ToString (override)
        override
        public string ToString()
        {
            return dni + "," + nombre;
        }
        #endregion
        #endregion
        #region Propiedades
        public int Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        #endregion
    }
}
