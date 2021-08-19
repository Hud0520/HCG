
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom21.Layout
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            panel2.Width =1048;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            ChuanDoan fm = new ChuanDoan();
            AddForm(fm);
        }
        private void AddForm(Form f)
        {
            panel3.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            panel3.Size = new System.Drawing.Size(f.PreferredSize.Width, f.PreferredSize.Height);
            panel3.Controls.Add(f);
            f.Show();
        }

        private void trangChủToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ChuanDoan fm = new ChuanDoan();
            AddForm(fm);
        }
        
        private void tậpLuậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Luat fl = new Luat();
            AddForm(fl);
        }

        private void sựKiệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SuKien fs = new SuKien();
            AddForm(fs);
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GioiThieu fg = new GioiThieu();
            fg.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hệThốngSuyDiễnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CacBuocSuyDien frm = new CacBuocSuyDien();
            AddForm(frm);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip3_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
