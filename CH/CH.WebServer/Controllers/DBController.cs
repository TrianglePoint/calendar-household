using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CH.WebServer.Controllers
{
    public class DBController : ApiController
    {
        // TEST.
        // App_Start/WebApiConfig.cs
        // GET api/db
        public string Get()
        {
            string server = "127.0.0.1";
            string db = "test";
            string uId = "user";
            string pwd = "user";
            string connStr = string.Format("Server={0};Database={1};Uid={2};Pwd={3};Charset=utf8", server, db, uId, pwd);
            MySql.Data.MySqlClient.MySqlConnection conn;
            conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            
            string result = "";
            try
            {
                conn.Open();
                string sql = "SELECT * FROM testT";
                MySql.Data.MySqlClient.MySqlCommand mySqlCommand = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                MySql.Data.MySqlClient.MySqlCommand cmd = mySqlCommand;
                MySql.Data.MySqlClient.MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result += reader[0] + " " + reader[1];
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conn.Close();
            }
            return "result : " + result;
        }
    }
}
