using Nhom21.Object;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace Nhom21.Control
{
    class RuleControl
    {
        private SqlConnection cn = ConnectDb.getC();

        public List<Object.Rule> getAllRule()
        {
            
            List<Object.Rule> ls = new List<Object.Rule>();
            cn.Open();
            String sql = "SELECT * FROM tbl_rule";
            using (SqlCommand cm1 = new SqlCommand(sql, cn))
            {
                SqlDataReader rs = cm1.ExecuteReader();
                while (rs.Read())
                {
                    Object.Rule r = new Object.Rule();
                    r.id = "R" + rs.GetInt32(0);
                    r.left = rs.GetString(1);
                    r.right = "r"+rs.GetInt32(2);
                    ls.Add(r);
                }
                rs.Close();
            }
            cn.Close();


            return ls;
        }

        public void addRule(Object.Rule similar)
        {
            if(similar != null)
            {
                cn.Open();

                string sql = "INSERT INTO tbl_rule (ruleleft, ruleright) VALUES (@vt,@vp)";
                using (SqlCommand cm = new SqlCommand(sql, cn))
                {
                    cm.Parameters.Add("@vt", SqlDbType.NVarChar).Value = similar.left;
                    cm.Parameters.Add("@vp", SqlDbType.Int).Value = similar.right.Substring(1);
                    cm.ExecuteNonQuery();
                }

                cn.Close();
            }
        }

        public void editRule(Object.Rule similar)
        {
            if (similar != null)
            {
                cn.Open();

                string sql = "UPDATE tbl_rule set ruleleft= @vt, ruleright= @vp WHERE ruleid = @id";
                using (SqlCommand cm = new SqlCommand(sql, cn))
                {
                    cm.Parameters.Add("@id", SqlDbType.Int).Value = similar.id.Substring(1);
                    cm.Parameters.Add("@vt", SqlDbType.NVarChar).Value = similar.left;
                    cm.Parameters.Add("@vp", SqlDbType.Int).Value = similar.right.Substring(1);
                    cm.ExecuteNonQuery();
                }

                cn.Close();
            }
        }

        public void delRule(Object.Rule similar)
        {
            if (similar != null)
            {
                cn.Open();

                string sql = "DELETE FROM tbl_rule WHERE ruleid = @id";
                using (SqlCommand cm = new SqlCommand(sql, cn))
                {
                    cm.Parameters.Add("@id", SqlDbType.Int).Value = similar.id.Substring(1);
                    cm.ExecuteNonQuery();
                }

                cn.Close();
            }
        }
    }
}
