using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinalMacoRios
{
    public class Pisos:Propiedades
    {
        string vhun;
        int habitaciones;

        public string Vhun
        {
            get
            {
                return vhun;
            }

            set
            {
                vhun = value;
            }
        }

        public int Habitaciones
        {
            get
            {
                return habitaciones;
            }

            set
            {
                habitaciones = value;
            }
        }
    }
}