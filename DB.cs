﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncfusionWinFormsApp1
{
    class DB
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-7VG9T54;Initial Catalog=sql;Integrated Security=True");

        public void openConnection()
        {
            if (sqlCon.State == System.Data.ConnectionState.Closed)
            {
                sqlCon.Open();
            }
        }

        public void closeConnection()
        {
            if (sqlCon.State == System.Data.ConnectionState.Open)
            {
                sqlCon.Close();
            }
        }


        public SqlConnection GetSqlConnection()
        {
            return sqlCon;
        }
    }
}
