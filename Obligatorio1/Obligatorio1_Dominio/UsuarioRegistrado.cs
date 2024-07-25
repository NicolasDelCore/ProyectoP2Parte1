using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorio1_Dominio
{
    public class UsuarioRegistrado
    {
        #region Atributos
        private int id;
        private static int ultimoId = 1;
        private string nombre;
        private string apellido;
        private string mail;
        private DateTime fechaNacimiento;
        #endregion

        #region Propiedades
        public int Id
        {
            get { return this.id; }
        }
        public string Nombre
        {
            get { return this.nombre; }
        }
        public string Apellido
        {
            get { return this.apellido; }
        }
        public string Mail
        {
            get { return this.mail; }
        }
        public DateTime FechaNacimiento
        {
            get { return this.fechaNacimiento; }
        }
        #endregion

        #region Constructores
        //*************** METODO CONSTRUCTOR DE USUARIO***************
        public UsuarioRegistrado(string nombre, string apellido, string mail, DateTime fechaNacimiento)
        {
            this.id = UsuarioRegistrado.ultimoId; //id autonumérico de instancia
            UsuarioRegistrado.ultimoId++; //+1 al contador de instancias de la clase UsuarioRegistrado
            this.nombre = nombre;
            this.apellido = apellido;
            this.mail = mail;
            this.fechaNacimiento = fechaNacimiento;
        }
        #endregion
    }
}
