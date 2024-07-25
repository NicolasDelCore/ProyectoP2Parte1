using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorio1_Dominio
{
    public abstract class Lugar
    {
        #region Atributos
        private int id;
        private string nombre;
        private float dimensionesAncho;
        private float dimensionesLargo;
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
        public float DimensionesAncho
        {
            get { return this.dimensionesAncho; }
        }
        public float DimensionesLargo
        {
            get { return this.dimensionesLargo; }
        }

        #endregion

        #region Constructores
        //*************** METODO CONSTRUCTOR DE LUGAR***************
        public Lugar(int id, string nombre, float dimensionesLargo, float dimensionesAncho)
        {
            this.id = id;
            this.nombre = nombre;
            this.dimensionesLargo = dimensionesLargo;
            this.dimensionesAncho = dimensionesAncho;
        }
        #endregion

        #region ToString Actividad
        public override string ToString() 
        {
            return this.nombre;
        }
        #endregion
    }
}
