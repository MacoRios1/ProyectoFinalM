using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinalMacoRios
{
    public class Comunidad
    {
        int Identificacion;
        string NombreC;
        string LugarC;

        public int Identificacion1
        {
            get
            {
                return Identificacion;
            }

            set
            {
                Identificacion = value;
            }
        }

        public string NombreC1
        {
            get
            {
                return NombreC;
            }

            set
            {
                NombreC = value;
            }
        }

        public string LugarC1
        {
            get
            {
                return LugarC;
            }

            set
            {
                LugarC = value;
            }
        }
    }
}