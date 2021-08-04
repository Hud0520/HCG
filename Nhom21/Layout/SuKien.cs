using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Nhom21.Layout
{
    public partial class SuKien : Form
    {
        
        public SuKien()
        {
            InitializeComponent();
        }

        private void SuKien_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
           

        }
        int row;
        private void dgv_SuKien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            if (row >= 0)
            {
                txt_MaSuKien.Text = dgv_SuKien.Rows[row].Cells["masukien"].Value.ToString();
                txt_TenSuKien.Text = dgv_SuKien.Rows[row].Cells["tensukien"].Value.ToString();
                txtThongTin.Text = dgv_SuKien.Rows[row].Cells["source"].Value.ToString();

            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
