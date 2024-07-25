using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorio1_Dominio
{

    public class LugarAbierto : Lugar
    {
        #region Atributos
        private static float precioButaca = 150;
        #endregion

        #region Constructores
        //*************** METODO CONSTRUCTOR DE LUGAR ABIERTO***************
        public LugarAbierto(int id, string nombre, float dimensionesLargo, float dimensionesAncho) : base(id, nombre, dimensionesLargo, dimensionesAncho)
        {
        }
        #endregion

        #region Propiedades
        public static float PrecioButaca
        {
            set { LugarAbierto.precioButaca = value; }
            get { return LugarAbierto.precioButaca; }
        }
        #endregion
    }
}
