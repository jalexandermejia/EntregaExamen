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
    public partial class WebAppconsulta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            string cadena = @"Data Source=(LocalDb)\v11.0;AttachDbFilename=c:\users\lab104bpc13\documents\visual studio 2012\Projects\Webparcial\Webparcial\App_Data\aspnet-Webparcial-20150424191146.mdf;Initial Catalog=aspnet-Webparcial-20150424191146;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cadena);


            string sqlCommand = "SELECT * FROM empleados";
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand, cn);
            DataTable datatable = new DataTable();

            cn.Open();
            int recordsAffected = da.Fill(datatable);
            TABLA2.DataSource = datatable;
            TABLA2.DataBind();
            cn.Close();
        }
    }
}