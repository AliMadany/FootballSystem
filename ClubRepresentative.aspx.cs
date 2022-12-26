using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace M3gogo
{
    public partial class ClubRepresentative : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["master"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            // SqlCommand matches = new SqlCommand("availableMatchesToAttend", conn);
            // matches.CommandType = System.Data.CommandType.Text;
            // matches.CommandText = "SELECT fn_availableMatchesToAttend()";

            SqlCommand matches = conn.CreateCommand();
            matches.CommandText = "SELECT * FROM allMatches";

            conn.Open();

            SqlDataReader rdr = matches.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

            DataTable dt = new DataTable();
            DataRow dr;

            dt.Columns.Add("Host");
            dt.Columns.Add("Guest");
            dt.Columns.Add("stadiumName");
            while (rdr.Read())
            {
                dr = dt.NewRow();
                string host = rdr.GetString(rdr.GetOrdinal("Host"));
                string guest = rdr.GetString(rdr.GetOrdinal("Guest"));
                DateTime startTime = rdr.GetDateTime(rdr.GetOrdinal("startTime"));
                dr[0] = host;
                dr[1] = guest;
                dr[2] = startTime;
                dt.Rows.Add(dr);


            }
            DataView dv = new DataView(dt);
            itemsGrid.DataSource = dv;
            itemsGrid.DataBind();
        }
    }
}