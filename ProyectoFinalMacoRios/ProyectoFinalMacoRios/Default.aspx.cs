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
        public void mostrar(bool a, bool b, bool c, bool d, bool z)
        {

            if (a == true)
            {
                Assembly _assembly; Stream _imageStream;
                StreamReader _textStreamReader;
                _assembly = Assembly.GetExecutingAssembly();
                _imageStream = _assembly.GetManifestResourceStream("ProyectoFinalMacoRios.Comunidad.bmp");
                _textStreamReader = new StreamReader(_assembly.GetManifestResourceStream("ProyectoFinalMacoRios.Comunidad.txt"));

                while (_textStreamReader.Peek() > -1)
                {
                    Comunidad comu = new Comunidad();
                    comu.Identificacion1 = Convert.ToInt32(_textStreamReader.ReadLine());
                    comu.NombreC1 = _textStreamReader.ReadLine();
                    comu.LugarC1 = _textStreamReader.ReadLine();
                    comunidad.Add(comu);
                }
                _textStreamReader.Close();
            }
            if (b == true)
            {

                Assembly _assembly; Stream _imageStream;
                StreamReader _textStreamReader1;
                _assembly = Assembly.GetExecutingAssembly();
                _imageStream = _assembly.GetManifestResourceStream("ProyectoFinalMacoRios.GastosInfo.bmp");
                _textStreamReader1 = new StreamReader(_assembly.GetManifestResourceStream("ProyectoFinalMacoRios.GastosInfo.txt"));

                while (_textStreamReader1.Peek() > -1)
                {
                    GastosInfo ginfo = new GastosInfo();
                    ginfo.IdentificacionG1 = _textStreamReader1.ReadLine();
                    ginfo.NombreG1 = _textStreamReader1.ReadLine();
                    ginfo.TipoDeRepartoG1 = _textStreamReader1.ReadLine();

                    gastosinfo.Add(ginfo);
                }
                _textStreamReader1.Close();
            }

            if (c == true)
            {

                Assembly _assembly; Stream _imageStream;
                StreamReader _textStreamReader2;
                _assembly = Assembly.GetExecutingAssembly();
                _imageStream = _assembly.GetManifestResourceStream("ProyectoFinalMacoRios.Propiedades.bmp");
                _textStreamReader2 = new StreamReader(_assembly.GetManifestResourceStream("ProyectoFinalMacoRios.Propiedades.txt"));

                while (_textStreamReader2.Peek() > -1)
                {
                    if (_textStreamReader2.ReadLine()== "L"  )
                    {

                    }
                    LocalComercial propi = new LocalComercial();
                    propi.TipoPropiedad1 = _textStreamReader2.ReadLine();
                    propi.CodigoPropiedad1 = _textStreamReader2.ReadLine();
                    propi.AreaPropiedad1 = Convert.ToInt32(_textStreamReader2.ReadLine());
                    propi.NitPropietario1 = _textStreamReader2.ReadLine();
                    
                    propi.InfoTipoPropiedad1 = _textStreamReader2.ReadLine();


                    propiedades.Add(propi);
                }
                _textStreamReader2.Close();
            }

            if (d == true)
            {

                Assembly _assembly; Stream _imageStream;
                StreamReader _textStreamReader3;
                _assembly = Assembly.GetExecutingAssembly();
                _imageStream = _assembly.GetManifestResourceStream("ProyectoFinalMacoRios.Propietarios.bmp");
                _textStreamReader3 = new StreamReader(_assembly.GetManifestResourceStream("ProyectoFinalMacoRios.Propietarios.txt"));

                while (_textStreamReader3.Peek() > -1)
                {
                    Propietarios tarios = new Propietarios();
                    tarios.NombrePropietario1 = _textStreamReader3.ReadLine();
                    tarios.NitPropietario1 = _textStreamReader3.ReadLine();
                    tarios.CorreoPropietario1 = _textStreamReader3.ReadLine();

                    propietarios.Add(tarios);
                }
                _textStreamReader3.Close();
            }
            if (z == true)
            {

                Assembly _assembly; Stream _imageStream;
                StreamReader _textStreamReader4;
                _assembly = Assembly.GetExecutingAssembly();
                _imageStream = _assembly.GetManifestResourceStream("ProyectoFinalMacoRios.GastosCalculo.bmp");
                _textStreamReader4 = new StreamReader(_assembly.GetManifestResourceStream("ProyectoFinalMacoRios.GastosCalculo.txt"));

                while (_textStreamReader4.Peek() > -1)
                {
                    GastosCalculo gcalculo = new GastosCalculo();
                    gcalculo.IdGasto1 = _textStreamReader4.ReadLine();
                    gcalculo.Descripcion1 = _textStreamReader4.ReadLine();
                    gcalculo.Importe1 = Convert.ToInt32(_textStreamReader4.ReadLine());
                    gcalculo.TipodeZonadeReparto1 = _textStreamReader4.ReadLine();


                    gastoscalculo.Add(gcalculo);
                }
                _textStreamReader4.Close();
            }

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            bool a = true;
            bool b = true;
            bool c = false;
            bool d = true;
            bool z = true;
            mostrar(a, b, c, d, z);
            data();
            data1();
            data2();
            data3();


        }
        public void data()
        {

            GridView1.DataSource = null;
            GridView1.DataBind();
            GridView1.DataSource = comunidad;
            GridView1.DataBind();
        }

        public void data1()
        {

            GridView2.DataSource = null;
            GridView2.DataBind();
            GridView2.DataSource = gastosinfo;
            GridView2.DataBind();
        }

        public void data2()
        {

            GridView3.DataSource = null;
            GridView3.DataBind();
            GridView3.DataSource = propietarios;
            GridView3.DataBind();
        }

        public void data3()
        {

            GridView4.DataSource = null;
            GridView4.DataBind();
            GridView4.DataSource = gastoscalculo;
            GridView4.DataBind();
        }
    }
}