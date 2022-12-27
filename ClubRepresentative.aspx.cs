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
            string connStr = WebConfigurationManager.ConnectionStrings["FootballContext"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            //name clubname username password

            if (Session["isClubRepresentativeLoggedIn"] == "true")
            {
                Control signup = Page.FindControl("signup");
                form1.Controls.Remove(signup);

            }
            else
            {
                Control login = Page.FindControl("login");
                form1.Controls.Remove(login);
            }
    
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

        protected void signUp(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["FootballContext"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            String n = name.Text;
            String cn = clubName.Text;
            String u = username.Text;
            String p = password.Text;


            SqlCommand cmd =  new SqlCommand("addRepresentative", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@representativeName", n));
            cmd.Parameters.Add(new SqlParameter("@clubName", cn));
            cmd.Parameters.Add(new SqlParameter("@representativeUsername", u));
            cmd.Parameters.Add(new SqlParameter("@representativePassword", p));

            //SqlParameter success = cmd.Parameters.Add("@success",SqlDbType.Int);
            //SqlParameter type = cmd.Parameters.Add("@type", SqlDbType.Int);
            //success.Direction = ParameterDirection.Output;
            //type.Direction = ParameterDirection.Output;

            try
            {
                conn.Open();
                int success = cmd.ExecuteNonQuery();
                conn.Close();

                if (success == 1)
                {
                    Response.Write("nice");
                }
                else
                {
                    Response.Write("not nice");
                }
            }
            catch
            {
                Response.Write("not nice");
            }

        }
    }
}