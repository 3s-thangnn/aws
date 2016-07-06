using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AWSDemo
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var connectionString  = ConfigurationManager.ConnectionStrings["AWS"].ConnectionString;
            var query = "Select * from Author";
            var con = new SqlConnection(connectionString);
            con.Open();
            var da = new SqlDataAdapter(query, con);
            var ds = new DataSet();

            da.Fill(ds);
        }
    }
}