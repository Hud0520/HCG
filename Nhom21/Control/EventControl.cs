using Nhom21.Object;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Text.RegularExpressions;

namespace Nhom21.Control
{
    class EventControl
    {
        public const string TYPE_EVENT = "e";
        public const string TYPE_REVENT = "r";
        private SqlConnection cn = ConnectDb.getC();

        public List<Event> getAllEvent()
        {
            List<Event> ls = new List<Event>();
            String sql = "SELECT * FROM tbl_event ORDER BY eid DESC ";
            cn.Open();
            using (SqlCommand cm = new SqlCommand(sql, cn))
            {
                SqlDataReader rs = cm.ExecuteReader();
                while (rs.Read())
                {
                    Event e = new Event();
                    e.id = "e" + rs.GetInt32(0);
                    e.name = rs.GetString(1);
                    ls.Add(e);
                }
                rs.Close();
            }

            sql = "SELECT * FROM tbl_eresult";
            using (SqlCommand cm1 = new SqlCommand(sql, cn))
            {
                SqlDataReader rs = cm1.ExecuteReader();
                while (rs.Read())
                {
                    Event e = new Event();
                    e.id = "r" + rs.GetInt32(0);
                    e.name = rs.GetString(1);
                    if (!rs.IsDBNull(2))
                    {
                        e.info = rs.GetString(2);
                    }
                    ls.Add(e);
                }
                rs.Close();
            }
            cn.Close();
            return ls;
        }

        public List<Event> getAllSyEvent()
        {
            List<Event> ls = new List<Event>();
            String sql = "SELECT * FROM tbl_event";
            cn.Open();
            using (SqlCommand cm = new SqlCommand(sql, cn))
            {
                SqlDataReader rs = cm.ExecuteReader();
                while (rs.Read())
                {
                    Event e = new Event();
                    e.id = "e" + rs.GetInt32(0);
                    e.name = rs.GetString(1);
                    ls.Add(e);
                }
                rs.Close();
            }
            return ls;
        }

        public void addEvent(Event similar)
        {
            if (similar != null)
            { 
                cn.Open();
                
                if ("e".Equals(similar.id))
                {

                    String sql = "INSERT INTO tbl_event (ename) VALUES (@name)";
                    using (SqlCommand cm = new SqlCommand(sql, cn))
                    {
                        cm.Parameters.Add("@name", SqlDbType.NVarChar).Value = similar.name;
                        cm.ExecuteNonQuery();
                    }
                }
                else if("r".Equals(similar.id))
                {
                    String sql = "INSERT INTO tbl_eresult (rname, rinfo) VALUES (@name,@info)";
                    using (SqlCommand cm = new SqlCommand(sql, cn))
                    {
                        cm.Parameters.Add("@name", SqlDbType.NVarChar).Value = similar.name;
                        cm.Parameters.Add("@info", SqlDbType.NVarChar).Value = similar.info;
                        cm.ExecuteNonQuery();
                    }
                }
                cn.Close();
            }
        }
        public void editEvent(Event similar)
        {
            if (similar != null)
            {
                cn.Open();
                Regex reg = new Regex("^e");
                Regex reg2 = new Regex("^r");
                if (reg.IsMatch(similar.id))
                {

                    String sql = "UPDATE tbl_event SET ename=@name WHERE eid=@id";
                    using (SqlCommand cm = new SqlCommand(sql, cn))
                    {
                        cm.Parameters.Add("@id", SqlDbType.NVarChar).Value = similar.id.Substring(1);
                        cm.Parameters.Add("@name", SqlDbType.NVarChar).Value = similar.name;
                        cm.ExecuteNonQuery();
                    }
                }
                if (reg2.IsMatch(similar.id))
                {
                    String sql = "UPDATE tbl_eresult SET rname=@name, rinfo=@info WHERE rid =@id";
                    using (SqlCommand cm = new SqlCommand(sql, cn))
                    {
                        cm.Parameters.Add("@id", SqlDbType.NVarChar).Value = similar.id.Substring(1);
                        cm.Parameters.Add("@name", SqlDbType.NVarChar).Value = similar.name;
                        cm.Parameters.Add("@info", SqlDbType.NVarChar).Value = similar.info;
                        cm.ExecuteNonQuery();
                    }
                }
                cn.Close();
            }
        }
        public void delEvent(Event similar)
        {
            if (similar != null)
            {
                cn.Open();
                Regex reg = new Regex("^e");
                Regex reg2 = new Regex("^r");
                if (reg.IsMatch(similar.id))
                {

                    String sql = "DELETE FROM tbl_event WHERE eid=@id";
                    using (SqlCommand cm = new SqlCommand(sql, cn))
                    {
                        cm.Parameters.Add("@id", SqlDbType.NVarChar).Value = similar.id.Substring(1);
                        cm.ExecuteNonQuery();
                    }
                }
                if (reg2.IsMatch(similar.id))
                {
                    String sql = "DELETE FROM tbl_eresult WHERE rid=@id";
                    using (SqlCommand cm = new SqlCommand(sql, cn))
                    {
                        cm.Parameters.Add("@id", SqlDbType.NVarChar).Value = similar.id.Substring(1);
                        cm.ExecuteNonQuery();
                    }
                }
                cn.Close();
            }
        }
    }
}
