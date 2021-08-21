using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nhom21.Layout;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Nhom21
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ConnectDb db = new ConnectDb();
            try
            {
                SqlConnection cn = db.getC();
                Application.Run(new Main());
            }
            catch (SqlException ex)
            {
                MessageBox.Show(null, "Kết nối thất bại \n" + ex.Message, "Thông báo", 0, MessageBoxIcon.Error);
            }
        }
    }
}
