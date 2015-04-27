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
    public partial class WebAppActualizar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void btnbuscar_Click(object sender, EventArgs e)
        {
            string buscarced;
            buscarced = txtcedula.Text;

            string cadena = @"Data Source=(LocalDb)\v11.0;AttachDbFilename=c:\users\lab104bpc13\documents\visual studio 2012\Projects\Webparcial\Webparcial\App_Data\aspnet-Webparcial-20150424191146.mdf;Initial Catalog=aspnet-Webparcial-20150424191146;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cadena);


            string consulta = "SELECT * FROM empleados where cedula='"+buscarced+"'";

            SqlDataAdapter da = new SqlDataAdapter(consulta, cn);
            DataTable datatable = new DataTable();

            cn.Open();
            
            int recordsAffected = da.Fill(datatable);
            TABLA.DataSource = datatable;
            TABLA.DataBind();
            cn.Close();
        }

        protected void btnactualizar_Click(object sender, EventArgs e)
        {

            string nombre=tnombre.Text;
            string apellido = tapellido.Text;
            string correo = tcorreo.Text;
            string domicilio = tdomicilio.Text;
            string ciudad = tciudad.Text;
            string tel = ttelefono.Text;


            string cadena = @"Data Source=(LocalDb)\v11.0;AttachDbFilename=c:\users\lab104bpc13\documents\visual studio 2012\Projects\Webparcial\Webparcial\App_Data\aspnet-Webparcial-20150424191146.mdf;Initial Catalog=aspnet-Webparcial-20150424191146;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cadena);
            cn.Open();

            string sqlCommand =" update empleados set nombre='"+nombre+"',apellido='"+apellido+"',correo='"+correo+"',domicilio='"+domicilio+"',ciudad='"+ciudad+"',telefono='"+tel+"'";
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand, cn);
            SqlCommand comando = new SqlCommand(sqlCommand, cn);
            comando.ExecuteNonQuery();
            cn.Close();
































        }
    }
}