using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinalMacoRios
{
    public class GastosInfo
    {
        string IdentificacionG;
        string NombreG;
        string TipoDeRepartoG;

        public string IdentificacionG1
        {
            get
            {
                return IdentificacionG;
            }

            set
            {
                IdentificacionG = value;
            }
        }

        public string NombreG1
        {
            get
            {
                return NombreG;
            }

            set
            {
                NombreG = value;
            }
        }

        public string TipoDeRepartoG1
        {
            get
            {
                return TipoDeRepartoG;
            }

            set
            {
                TipoDeRepartoG = value;
            }
        }
    }
}