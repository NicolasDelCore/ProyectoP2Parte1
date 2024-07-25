using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorio1_Dominio
{
    public class Actividad
    {
        #region Atributos
        private int id;
        private static int ultimoId = 1;
        private string nombre;
        private Categoria categoria;
        private DateTime fechaYHora;
        private Lugar lugar;
        private string edadMinima;
        private static float precioEntrada;
        private int meGusta;
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
        public Categoria Categoria
        {
            get { return this.categoria; }
        }
        public DateTime FechaYHora
        {
            get { return this.fechaYHora; }
        }

        public Lugar Lugar
        {
            get { return this.lugar; }
        }
        public string EdadMinima
        {
            get { return this.edadMinima; }
        }
        public float PrecioEntrada
        {
            get { return this.precioEntrada; }
            set { this.precioEntrada = value; }
        }
        public int MeGusta
        {
            get { return this.meGusta; }
            //set { this.meGusta = value; } //para el futuro, cuando el valor de meGusta deba actualizarse
        }
        #endregion

        #region Constructores
        //*************** METODO CONSTRUCTOR DE ACTIVIDAD***************
        public Actividad(string nombre, Categoria miCategoria, DateTime fechaYHora, Lugar miLugar, string edadMinima, float precioEntrada)
        {
            this.id = Actividad.ultimoId; //asignamos el valor del atrib de clase "ultimoId" como atrib "id" de la instancia
            Actividad.ultimoId++; //aumentamos el atributo contador de clase, ultimoId
            this.nombre = nombre;
            this.categoria = miCategoria;
            this.fechaYHora = fechaYHora;
            this.lugar = miLugar;
            this.edadMinima = edadMinima;
            this.precioEntrada = precioEntrada;
            this.meGusta = 0; //Contador miembro de instancia que incrementará luego de creado el obj Actividad, cuando se implemente una función para aumentar los "Me Gusta"
        }
        #endregion

        #region ToString Actividad
        public override string ToString()
        {
            return $"\nNombre: {this.nombre}\nCategoría: {this.categoria}\nFecha: {this.fechaYHora}\nLugar: {this.lugar}\nEdad mínima: {this.edadMinima}"; //\nPrecio: ${this.precioEntrada}
        }
        #endregion
    }
}
