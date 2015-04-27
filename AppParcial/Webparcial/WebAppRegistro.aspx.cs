using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Webparcial
{
    public partial class WebAppRegistro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string cadena = @"Data Source=(LocalDb)\v11.0;AttachDbFilename=c:\users\lab104bpc13\documents\visual studio 2012\Projects\Webparcial\Webparcial\App_Data\aspnet-Webparcial-20150424191146.mdf;Initial Catalog=aspnet-Webparcial-20150424191146;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cadena);
            cn.Open();

            string sqlCommand = "INSERT INTO empleados(cedula, nombre, apellido, correo, domicilio, ciudad, telefono) VALUES (104,'alexander', 'mejia', 'amejia@hotmail.com','niza', 'cucuta', '3003174456')";
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand, cn);
            SqlCommand comando = new SqlCommand(sqlCommand, cn);
            comando.ExecuteNonQuery();
            cn.Close();
        }
    }
}