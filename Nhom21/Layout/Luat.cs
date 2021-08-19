using Nhom21.Control;
using Nhom21.Object;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;


namespace Nhom21.Layout
{
    public partial class Luat : Form
    {
        RuleControl rc = new RuleControl();
        EventControl ec = new EventControl();
        BindingList<Rule> list = null;
        List<Event> listEvent = null;
        int row;
        void load()
        {
            list = new BindingList<Rule>(rc.getAllRule());
            dgv_Luat.DataSource = rc.getAllRule();
            
        }
        public Luat()
        {
            InitializeComponent();
            load();
            dgv_Luat.Columns[0].HeaderText = "Mã tập luật";
            dgv_Luat.Columns[1].HeaderText = "Vế trái";
            dgv_Luat.Columns[2].HeaderText = "Vế phải";
            //517
            dgv_Luat.Columns[0].Width = 117;
            dgv_Luat.Columns[1].Width = 215;
            dgv_Luat.Columns[2].Width = 100;
            listEvent = ec.getAllEvent();
        }

        private void Luat_Load(object sender, EventArgs e)
        {
            load();
        }

       
        private void dgv_Luat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            txt_MaLuat.Text = list[row].id;
            txt_VeTrai.Text = list[row].left;
            txt_VePhai.Text = list[row].right;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            String vt = txt_VeTrai.Text, vp = txt_VePhai.Text;
            if (!vt.Equals("") && !vp.Equals(""))
            {
                if (isChecked(vt,vp))
                {
                    Rule similar = new Rule();
                    similar.left = vt;
                    similar.right = vp;
                    rc.addRule(similar);
                    load();
                    dgv_Luat.FirstDisplayedScrollingRowIndex = list.Count - 1;
                }
                else
                {
                    MessageBox.Show(null, "Sự kiện chưa tồn tại", "Thông báo", 0, MessageBoxIcon.Warning);
                }
            }
        }
        private bool isChecked(string vt, string vp) {
            bool flag = true;
            vt += "^" + vp;
            string[] tmp = vt.Split("^");
            foreach (String str in tmp)
            {
                if (!isfind(str))
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
        private bool isfind(String t)
        {
            foreach(Event e in listEvent)
            {
                if (e.id.Equals(t))
                {
                    return true;
                }
            }
            return false;
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (row >= 0 && row < list.Count)
            {
                Rule similar = new Rule();
                similar.id = list[row].id;
                rc.delRule(similar);
                load();
            }
            else
            {
                MessageBox.Show(null, "Bạn cần lựa chọn tập luật trước khi chỉnh sửa", "Thông báo", 0, MessageBoxIcon.Error);
            }
        }
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (row >= 0 && row < list.Count)
            {
                String vt = txt_VeTrai.Text, vp = txt_VePhai.Text;
                if (!vt.Equals("") && !vp.Equals(""))
                {
                    Rule similar = new Rule();
                    similar.id = list[row].id;
                    similar.left = vt;
                    similar.right = vp;
                    rc.editRule(similar);
                    load();
                    dgv_Luat.FirstDisplayedScrollingRowIndex = row;
                }
                else
                {
                    MessageBox.Show(null, "Dữ liệu không được bỏ trống", "Thông báo", 0, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(null, "Bạn cần lựa chọn tập luật trước khi chỉnh sửa", "Thông báo", 0, MessageBoxIcon.Error);
            }
        }
    }
}
