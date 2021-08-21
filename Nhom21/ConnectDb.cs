using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Nhom21
{
    class ConnectDb
    {
        private String connectName;
        public ConnectDb()
        {
            connectName = "Server=localhost;Database=HCG;Integrated Security=SSPI";
        }
        public SqlConnection getC()
        {
            SqlConnection cn = new SqlConnection(connectName);
            try
            {
               
                cn.Open();
                cn.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return cn;
        }
    }
}
