using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
namespace Nhom21
{
    class ConnectDb
    {
        public static SqlConnection getC()
        {
            String connectName = "Server=localhost;Database=HCG;Integrated Security=SSPI";
            return new SqlConnection(connectName);
        }

        static void main()
        {
            
        }
    }
}
