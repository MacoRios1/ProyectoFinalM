using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Reflection;

namespace ProyectoFinalMacoRios
{
    public partial class _Default : Page
    {
        List<Comunidad> comunidad = new List < Comunidad >();
        List<GastosInfo> gastosinfo = new List<GastosInfo>();
        List<Propiedades> propiedades = new List<Propiedades>();
        List<Propietarios> propietarios = new List<Propietarios>();
        List<GastosCalculo> gastoscalculo = new List<GastosCalculo>();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //abre el archivo comunidad y lee sus datos
            Assembly _assembly; Stream _imageStream;
            StreamReader _textStreamReader;
            _assembly = Assembly.GetExecutingAssembly();
            _imageStream = _assembly.GetManifestResourceStream("ProyectoFinalMacoRios.Comunidad.bmp");
            _textStreamReader = new StreamReader(_assembly.GetManifestResourceStream("ProyectoFinalMacoRios.Comunidad.txt"));
            while (_textStreamReader.Peek() > -1)
            {
                Comunidad comu = new Comunidad();
                comu.Identificacion1 = Convert.ToInt32 ( _textStreamReader.ReadLine());
                comu.NombreC1 = _textStreamReader.ReadLine();
                comu.LugarC1 = _textStreamReader.ReadLine();               
                comunidad.Add(comu);
            }
            _textStreamReader.Close();
            Label3.Text = comunidad[1].NombreC1;


           //abre el archivo Propiedades y lee sus datos
            StreamReader _textStreamReader1;
            _assembly = Assembly.GetExecutingAssembly();
            _imageStream = _assembly.GetManifestResourceStream("ProyectoFinalMacoRios.Propiedades.bmp");
            _textStreamReader1 = new StreamReader(_assembly.GetManifestResourceStream("ProyectoFinalMacoRios.Propiedades.txt"));         
                Propiedades propi = new Propiedades();
                if (propi.TipoPropiedad1 == "L")
                {
                    
                    propi.TipoPropiedad1 = _textStreamReader1.ReadLine();
                }
                int numeropropi = 1;
                propiedades.Add(propi);
                _textStreamReader1.Close();
                Label5.Text = Convert.ToString(numeropropi);




            // abre el archivo Propietarios  y lee datos
            StreamReader _textStreamReader2;
            _assembly = Assembly.GetExecutingAssembly();
            _imageStream = _assembly.GetManifestResourceStream("ProyectoFinalMacoRios.Propietarios.bmp");
            _textStreamReader2 = new StreamReader(_assembly.GetManifestResourceStream("ProyectoFinalMacoRios.Propietarios.txt"));
            while (_textStreamReader2.Peek() > -1)
            {
                Propietarios propieta = new Propietarios();
                propieta.NombrePropietario1 = _textStreamReader2.ReadLine();
                propieta.NitPropietario1 = _textStreamReader2.ReadLine();
                propieta.CorreoPropietario1 = _textStreamReader2.ReadLine();

                propietarios.Add(propieta);
            }
            _textStreamReader2.Close();


            // abre el archivo GastosCalculo
            StreamReader _textStreamReader3;
            _assembly = Assembly.GetExecutingAssembly();
            _imageStream = _assembly.GetManifestResourceStream("ProyectoFinalMacoRios.GastosCalculo.bmp");
            _textStreamReader3 = new StreamReader(_assembly.GetManifestResourceStream("ProyectoFinalMacoRios.GastosCalculo.txt"));
            while (_textStreamReader3.Peek() > -1)
            {
                GastosCalculo gcalcu = new GastosCalculo();
                gcalcu.IdGasto1 = _textStreamReader3.ReadLine();
                gcalcu.Descripcion1 = _textStreamReader3.ReadLine();
                gcalcu.Importe1 =Convert.ToInt32 (_textStreamReader3.ReadLine());
                gcalcu.TipodeZonadeReparto1 = _textStreamReader3.ReadLine();

                gastoscalculo.Add(gcalcu);
            }
            _textStreamReader3.Close();

            // abre el archivo GastosInfo
            StreamReader _textStreamReader4;
            _assembly = Assembly.GetExecutingAssembly();
            _imageStream = _assembly.GetManifestResourceStream("ProyectoFinalMacoRios.GastosInfo.bmp");
            _textStreamReader4 = new StreamReader(_assembly.GetManifestResourceStream("ProyectoFinalMacoRios.GastosInfo.txt"));
            while (_textStreamReader4.Peek() > -1)
            {
                GastosInfo ginfo = new GastosInfo();
                ginfo.IdentificacionG1 = _textStreamReader4.ReadLine();
                ginfo.NombreG1 = _textStreamReader4.ReadLine();
                ginfo.TipoDeRepartoG1 = _textStreamReader4.ReadLine();

                gastosinfo.Add(ginfo);
            }
            _textStreamReader4.Close();

        }
    }
}