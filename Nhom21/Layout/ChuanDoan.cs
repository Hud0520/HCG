using Nhom21.Control;
using Nhom21.Object;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom21.Layout
{
    public partial class ChuanDoan : Form 
    {
        RuleControl rc = new RuleControl();
        EventControl ec = new EventControl();
        BindingList<Event> List = null;
        BindingList<Event> GT = new BindingList<Event>();
        int ESelected=-1,ConfESelected =-1;

        public ChuanDoan()
        {
            InitializeComponent();
        }


        private void Main_Load(object sender, EventArgs e)
        {
            List = new BindingList<Event>(ec.getAllSyEvent());
            dgv_SuKien.DataSource = List;
            dgv_SuKien.Columns[1].Width = 300;
            dgv_SuKien.Columns[0].HeaderText = "Mã";
            dgv_SuKien.Columns[1].HeaderText = "Triệu Chứng";

            dgv_XacNhanSuKien.DataSource = GT;
            dgv_XacNhanSuKien.Columns[1].Width = 300;
            dgv_XacNhanSuKien.Columns[0].HeaderText = "Mã";
            dgv_XacNhanSuKien.Columns[1].HeaderText = "Triệu Chứng";
        }

        private void btn_ThemSuKien_Click(object sender, EventArgs e)
        {
           if(ESelected != -1)
            {
                if (!GT.Contains<Event>(List[ESelected]))
                {
                    GT.Add(List[ESelected]);
                    dgv_XacNhanSuKien.DataSource = GT;
                    dgv_XacNhanSuKien.Columns[1].Width = 300;
                    ESelected = -1;
                }
                else
                {
                    MessageBox.Show(null, "Chiệu chứng đã được chọn", "Thông báo", MessageBoxButtons.OK);
                }
            }


        }
        
        private void dgv_SuKien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ESelected = e.RowIndex;
        }

        private void btn_XoaSuKien_Click(object sender, EventArgs e)
        {
            if (ConfESelected != -1)
            {
                GT.RemoveAt(ConfESelected);
               
                dgv_XacNhanSuKien.DataSource = GT;
                dgv_XacNhanSuKien.Columns[1].Width = 300;
                ConfESelected = -1;
            }
        }
        
        private void dgv_XacNhanSuKien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                ConfESelected = e.RowIndex;
            }
            else
            {
                Console.WriteLine("Sai ở đâu đó");
            }
           
        }

        private void btn_SuyDien_Click(object sender, EventArgs e)
        {
            
        }
  

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_CacBuocSuyDien_Click(object sender, EventArgs e)
        {
            CacBuocSuyDien frm = new CacBuocSuyDien();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            GT.Clear();
            dgv_XacNhanSuKien.DataSource = GT;
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            String keyword = txtTim.Text.Trim();
            BindingList<Event> sublist = new BindingList<Event>();
            foreach(Event ev in List)
            {
                if (ev.name.Contains(keyword)){
                    sublist.Add(ev);
                }
            }
            dgv_SuKien.DataSource = sublist;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtTim.Text = "";
        }

        private void dgv_SuKien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listbox_KetQua_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
