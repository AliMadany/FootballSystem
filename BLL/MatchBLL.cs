using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using M3gogo.DBLayer;
using M3gogo.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace M3gogo.BLL
{
    public class MatchBLL
    {



        public List<Match> Viewupcomingtest(DateTime dateTime) // 2.2D All upcoming matches
        {
            List<Match> upcomingList1 = new List<Match>();
            string connectionString = ConfigurationManager.ConnectionStrings["FootballContext"].ConnectionString;





            using (SqlConnection connection = new SqlConnection(connectionString))
            {
 
                SqlCommand cmd = new SqlCommand("select * from availableMatchesToAttend(" +"'"+dateTime+"'"+")", connection);
                DateTime currenttime= DateTime.Now;
                /*SqlParameter parm1 = new SqlParameter();
                parm1.ParameterName = "@StartTime";
                parm1.SqlDbType = SqlDbType.DateTime;
                parm1.Value = DateTime.Now;*/
                // cmd.Parameters.Add(parm1);
                cmd.CommandType = CommandType.Text;
           
                connection.Open();

                SqlDataReader dr = cmd.ExecuteReader();

            //    cmd.Parameters.AddWithValue("@dateTime", dateTime );

                while (dr.Read())
                {
                    Match upmatches = new Match();

                    upmatches.HostClub = dr["club_name"].ToString();
                    upmatches.GuestClub = dr["Guest_Club"].ToString();
                    upmatches.StartTime = Convert.ToDateTime(dr["Start_time"]);
                    upmatches.Stadium = dr["Stadium_hosting"].ToString();



                    upcomingList1.Add(upmatches);

                }

            }
            return (upcomingList1);

        }



        public List<Match> ViewAlreadyPlayed(DateTime dateTime1) // 22.E Already played matches
        {
            List<Match> upcomingList1 = new List<Match>();
            string connectionString = ConfigurationManager.ConnectionStrings["FootballContext"].ConnectionString;


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                
                SqlCommand cmd = new SqlCommand("select * from availableMatchesToAttend(" + "'" + dateTime1 + "'" + ")", connection);
               
             
               
                DateTime currenttime = DateTime.Now;
                /*SqlParameter parm1 = new SqlParameter();
                parm1.ParameterName = "@StartTime";
                parm1.SqlDbType = SqlDbType.DateTime;
                parm1.Value = DateTime.Now;*/
                // cmd.Parameters.Add(parm1);
                cmd.CommandType = CommandType.Text;

                connection.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                //    cmd.Parameters.AddWithValue("@dateTime", dateTime );
               
                    while (dr.Read())
                    {
                        Match upmatches = new Match();

                        upmatches.HostClub = dr["club_name"].ToString();
                        upmatches.GuestClub = dr["Guest_Club"].ToString();
                        upmatches.StartTime = Convert.ToDateTime(dr["Start_time"]);
                        upmatches.Stadium = dr["Stadium_hosting"].ToString();

                        upcomingList1.Add(upmatches);

                    }
                

            }
            return (upcomingList1);

        }












    }




}
    
















          /*   public void test(Match match)
            {
                {

                    {


                        using (SqlConnection cn = new SqlConnection(connectionString))
                        {

                            SqlCommand cmd = new SqlCommand("select * from availableMatchesToAttend('2020-10-05')", cn);
                            cn.Open();
                            IDataReader reader = cmd.ExecuteReader();
                            while (reader.Read())
                            {
                                Console.WriteLine(reader[1].ToString());
                            }
                        }








                    }
                }
          }
       */
        
   

