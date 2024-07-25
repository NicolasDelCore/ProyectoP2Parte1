using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorio1_Dominio
{
    public class LugarCerrado : Lugar
    {

        #region Atributos
        private bool accesibilidad;
        private float valorMantenimiento;
        private static float porcentajeAforoMaximo = 43;
        #endregion

        #region Constructores
        //*************** METODO CONSTRUCTOR DE LUGAR CERRADO***************
        public LugarCerrado(int id, string nombre, float dimensionesLargo, float dimensionesAncho, bool accesibilidad, float valorMantenimiento, float precioCerrado) : base(id, nombre, dimensionesLargo, dimensionesAncho)
        {
            this.accesibilidad = accesibilidad;
            this.valorMantenimiento = valorMantenimiento;
            this.precioCerrado = precioCerrado;
        }
        #endregion

        #region Propiedades
        public static float PorcentajeAforoMaximo 
        {
            set { LugarCerrado.porcentajeAforoMaximo = value; }
            get { return LugarCerrado.porcentajeAforoMaximo; }
        }
        #endregion
    }
}
