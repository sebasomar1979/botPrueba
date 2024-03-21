using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;



namespace chatBotColegio
{
    internal class Conexion
    {
        SqlConnection SqlCon;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        public void Open()
        {
            string nombre_servidor = Dns.GetHostName();

            SqlCon = new SqlConnection("Data Source=" + nombre_servidor + "\\DESKTOP-MRLQRN9;Initial Catalog=colegioNuevoProyecto;Integrated Security=True");

            SqlCon.Open();
        }
    }
}