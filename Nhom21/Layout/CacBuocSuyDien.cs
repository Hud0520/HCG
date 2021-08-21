using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Nhom21.Object;

namespace Nhom21.Layout
{
    public partial class CacBuocSuyDien : Form
    {

        public CacBuocSuyDien()
        {
            InitializeComponent();
        }

        private void frm_CacBuocSuyDien_Load(object sender, EventArgs e)
        {
            rtb_CacBuocSuyDien.Text = FileLog.readfile();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
