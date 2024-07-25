using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorio1_Dominio
{
    public class Compra
    {
        #region Atributos
        private int id;
        private Actividad actividad;
        private int cantidadEntradas;
        private DateTime fechaYHora;
        private bool estaActiva;
        private float precioFinal;
        private UsuarioRegistrado usuarioComprador;
        #endregion

        #region Constructores
        //*************** METODO CONSTRUCTOR DE COMPRA***************
        public Compra(int id, Actividad actividad, int cantidadEntradas, float precioFinal, UsuarioRegistrado usuarioComprador)
        {
            this.id = id;
            this.actividad = actividad;
            this.cantidadEntradas = cantidadEntradas;
            this.fechaYHora = DateTime.Now; //La compra se efectúa en el momento en que se da de alta un objeto tipo Compra
            this.estaActiva = true; //Por defecto, al crear la instancia, el atributo estaActiva será true, dado que la compra acaba de ocurrir
            this.precioFinal = precioFinal;
            this.usuarioComprador = usuarioComprador;
        }
        #endregion

        #region Propiedades
        public int Id
        {
            get { return this.id; }
        }
        public Actividad Actividad
        {
            get { return this.actividad; }
            set { this.actividad = value; } //para actualizar si la compra se canceló o no
        }
        public int CantidadEntradas
        {
            get { return this.cantidadEntradas; }
        }
        public DateTime FechaYHora
        {
            get { return this.fechaYHora; }
        }
        public bool EstaActiva
        {
            get { return this.estaActiva; }
        }
        public float PrecioFinal
        {
            get { return this.precioFinal; }
        }
        public UsuarioRegistrado UsuarioComprador
        {
            get { return this.usuarioComprador; }
        }
        #endregion
    }
}
