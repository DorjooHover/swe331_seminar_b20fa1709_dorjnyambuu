using swe331_seminar_b20fa1709_dorjnyambuu.models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swe331_seminar_b20fa1709_dorjnyambuu
{
    internal class GlobalVar
    {
        private static SqlConnection conn;
        public static SqlConnection Connection
        {
            get { return conn; }
            set { conn = value; }
        }

        public static DataTable getData(String query)
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                DataTable dt = new DataTable();
                DataSet sd = new DataSet();
                conn.Open();
                sda.SelectCommand = new SqlCommand( query, conn);
               
                sda.Fill(dt);
                conn.Close();
                return dt;
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        
        public static bool delete(String query)
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                DataTable dt = new DataTable();
                DataSet sd = new DataSet();
                conn.Open();
                sda.DeleteCommand = new SqlCommand(query, conn);
                sda.DeleteCommand.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public static bool exec(string query, List<SqlParameter> param)
        {
            try
            {
                SqlCommand sc = new SqlCommand(query, conn);
                sc.CommandType = CommandType.StoredProcedure;

                for (int i = 0; i < param.Count; i++)
                {
                    sc.Parameters.Add(param[i]);
                }
                
                SqlDataAdapter sd = new SqlDataAdapter(sc);
                
                conn.Open();
                sc.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public static User  login(User user)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand sc = new SqlCommand("login", conn);
                sc.CommandType = CommandType.StoredProcedure;
                sc.Parameters.Add(new SqlParameter("@username" , user.UserName));
                sc.Parameters.Add(new SqlParameter("@password" , user.Password));

                SqlDataAdapter sd = new SqlDataAdapter(sc);
                sd.Fill(dt);
                conn.Open();
                sc.ExecuteNonQuery();
                conn.Close();
                User user1= new User();
                if (dt.Rows.Count > 0)
                {
                    user1.Id = Int32.Parse(dt.Rows[0][0].ToString());
                    user1.UserName = dt.Rows[0][1].ToString();
                    user1.Lastname = dt.Rows[0][2].ToString();
                    user1.Firstname = dt.Rows[0][3].ToString();
                    user1.RegisterNumber = dt.Rows[0][4].ToString();
                    user1.Mobile = dt.Rows[0][5].ToString();
                    user1.Email = dt.Rows[0][6].ToString();
                    user1.Address = dt.Rows[0][7].ToString();
                    user1.Password = dt.Rows[0][8].ToString();

                    
                    return user1;
                } else
                {
                    return null;
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

    }
}
