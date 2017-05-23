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
            Assembly _assembly; Stream _imageStream;
            StreamReader _textStreamReader;
            _assembly = Assembly.GetExecutingAssembly();
            _imageStream = _assembly.GetManifestResourceStream("ProyectoFinalMacoRios.Comunidad.bmp");
            _textStreamReader = new StreamReader(_assembly.GetManifestResourceStream("ProyectoFinalMacoRios.Comunidad.txt"));

         
            while (_textStreamReader.Peek() > -1)
            {
                Comunidad comu = new Comunidad();
           
                comu.Identificacion1 = Convert.ToInt32(_textStreamReader.ReadLine());
                comu.NombreC1= _textStreamReader.ReadLine();
                comu.LugarC1 = _textStreamReader.ReadLine();
                
                comunidad.Add(comu);
            }
            _textStreamReader.Close();
            GridView1.DataSource = null;
            GridView1.DataBind();
            GridView1.DataSource = comunidad;
            GridView1.DataBind();
        }
    }
}