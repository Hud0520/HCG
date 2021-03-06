using Nhom21.Control;
using Nhom21.Object;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Nhom21.Layout
{
    public partial class SuKien : Form
    {
        EventControl ec = new EventControl();
        Event similar = null;
        int row = -1;
        BindingList<Event> list = null;
        void load()
        {
            list = new BindingList<Event>(ec.getAllEvent());
            dgv_SuKien.DataSource = list;
        }
        private void textBoxClear()
        {
            txtThongTin.Text = "";
            txt_TenSuKien.Text = "";
            if (radioButton1.Checked)
            {
                radioButton1.Checked = false;
            }
            if (radioButton2.Checked)
            {
                radioButton2.Checked = false;
            }
        }
        public SuKien()
        {
            InitializeComponent();
            load();
            dgv_SuKien.Columns[0].HeaderText = "Mã sự kiện";
            dgv_SuKien.Columns[1].HeaderText = "Tên sự kiên";
            //517
            dgv_SuKien.Columns[0].Width = 150;
            dgv_SuKien.Columns[1].Width = 307;
        }

        private void SuKien_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if(!"".Equals(txt_TenSuKien.Text) &&(radioButton1.Checked || radioButton2.Checked))
            {
                similar = new Event();
                similar.id = radioButton1.Checked ? "r" : "e";
                similar.name = txt_TenSuKien.Text;
                similar.info = txtThongTin.Text;
                ec.addEvent(similar);
                load();
                if (similar.id.Equals("r"))
                {
                    dgv_SuKien.FirstDisplayedScrollingRowIndex = list.Count-1;
                }
                textBoxClear();
            }
            else
            {
                MessageBox.Show(null, "Bạn chư nhập đủ thông tin", "Thông báo",0, MessageBoxIcon.Information);
            }

        }
        private void dgv_SuKien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            similar = list[row];
            txt_TenSuKien.Text = similar.name;
            txtThongTin.Text = similar.info;
            Regex gex = new Regex("^e");
            if (gex.IsMatch(similar.id))
            {
                radioButton2.Checked= true;
            }
            else
            {
                radioButton1.Checked= true;
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if(row >= 0 && row< list.Count)
            {
                similar = new Event();
                similar.id = list[row].id;
                if (!"".Equals(txt_TenSuKien.Text) && (radioButton1.Checked || radioButton2.Checked))
                {
                    
                    String type = radioButton1.Checked ? "r" : "e";
                    if (similar.id.Contains(type))
                    {
                        
                        similar.name = txt_TenSuKien.Text;
                        similar.info = txtThongTin.Text;
                        ec.editEvent(similar);
                        load();
                        dgv_SuKien.FirstDisplayedScrollingRowIndex = row;
                    }
                    else
                    {
                        MessageBox.Show(null, "Bạn Không thể thay đổi thông tin phân loại của sự kiện này", "Thông báo", 0, MessageBoxIcon.Information);
                        if (similar.id.Contains("r"))
                        {
                            radioButton1.Checked = true;
                        }
                        else
                        {
                            radioButton2.Checked = true;
                        }
                    }
                    textBoxClear();
                }
                else
                {
                    MessageBox.Show(null, "Bạn chư nhập đủ thông tin", "Thông báo", 0, MessageBoxIcon.Information);
                }
            }
            
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (row >= 0 && row < list.Count)
            {
                DialogResult dr = MessageBox.Show(null, "Bạn có chắc muốn xóa sự kiện " + list[row].id , "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    similar = new Event();
                    similar.id = list[row].id;
                    ec.delEvent(similar);
                    load();
                    if (similar.id.Equals("r"))
                    {
                        dgv_SuKien.FirstDisplayedScrollingRowIndex = list.Count - 1;
                    }
                    textBoxClear();
                }
            }
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
