using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinalMacoRios
{
    public class GastosCalculo
    {
        string IdGasto;
        string Descripcion;
        int Importe;
        string TipodeZonadeReparto;

        public string IdGasto1
        {
            get
            {
                return IdGasto;
            }

            set
            {
                IdGasto = value;
            }
        }

        public string Descripcion1
        {
            get
            {
                return Descripcion;
            }

            set
            {
                Descripcion = value;
            }
        }

        public int Importe1
        {
            get
            {
                return Importe;
            }

            set
            {
                Importe = value;
            }
        }

        public string TipodeZonadeReparto1
        {
            get
            {
                return TipodeZonadeReparto;
            }

            set
            {
                TipodeZonadeReparto = value;
            }
        }
    }
}