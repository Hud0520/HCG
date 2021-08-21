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
using Rule = Nhom21.Object.Rule;

namespace Nhom21.Layout
{
    public partial class ChuanDoan : Form 
    {
        RuleControl rc = new RuleControl();
        EventControl ec = new EventControl();
        BindingList<Event> List = null;
        BindingList<Event> GT = new BindingList<Event>(); // Tập giả thiết
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
            //Xóa ô kết quả
            listbox_KetQua.Items.Clear();

            //Lấy các dữ liệu
            if (GT.Count != 0)
            {
                Queue<Object.Rule> SAT = new Queue<Object.Rule>(); // Tập chứa các tập thỏa
                List<Object.Rule> R = rc.getAllRule(); //Tập chứa các luật
                List<Event> KL = ec.getResult(); //Tập chứa các kết luận
                // Clear file log hoặc tạo file
                FileLog.clearFile();
                FileLog.writeRule(R);
                List<string> TG = new List<string>(); //Tập chứa các sự kiện đúng
                foreach (Event ev in GT)
                {
                    TG.Add(ev.id);
                }
                
                FileLog.writeln("Bước 1: ");
                //Ghi tập trung gian
                FileLog.writeGT(TG);

                string result = "";

                Object.Rule r = null;

                filter_sat(SAT, TG, R);
                FileLog.writeSAT(SAT);
                if (SAT.Count == 0)
                {
                    FileLog.writeln("Tập SAT rỗng, dừng lặp");
                }
                else
                {
                    int loop = 0;
                    while (SAT.Count > 0)
                    {
                        FileLog.writeln("--------- Lần lặp " + ++loop + " ---------");
                        FileLog.writeln("Bước 2: ");
                        FileLog.writeln("Lấy luật " + SAT.Peek().id + "trong tập SAT :" + Helper.getRuleById(R, SAT.Peek().id));

                        r = SAT.Dequeue();
                        result = r.right;
                        if (!TG.Contains(r.right))
                        {
                            TG.Add(r.right);
                            FileLog.writeln("Thêm vế phải của luật " + r.right + " vào tập trung gian");
                        }
                        FileLog.writeln("Loại bỏ luât " + r.id + " khỏi tập R");
                        R.Remove(r);

                        FileLog.writeln("Bước 3: Kiểm tra : ");
                        if (Helper.getEventById(KL, result) != null)
                        {
                            FileLog.writeln("Trong tập TG có kết luận, dừng lặp:");
                            FileLog.writeGT(TG);
                            break;
                        }
                        else
                        {
                            FileLog.writeln("Trong tập TG không có kết luận");
                            FileLog.writeGT(TG);
                        }
                        FileLog.writeln("Lọc lại tập SAT từ tập TG và R");
                        filter_sat(SAT, TG, R);
                        if (SAT.Count == 0)
                        {
                            FileLog.writeln("Tập SAT rỗng, dừng lặp");
                        }
                        else
                        {
                            FileLog.writeSAT(SAT);
                        }
                    }
                }
                Event evresult = Helper.getEventById(KL,result);
                if(evresult != null)
                {
                    listbox_KetQua.Items.Add("");
                    listbox_KetQua.Items.Add("------------------------- Kết quả chuẩn đoán -------------------------");
                    listbox_KetQua.Items.Add("Mắc bệnh : " + evresult.name);
                    listbox_KetQua.Items.Add("Thông tin : " + evresult.info);
                    listbox_KetQua.Items.Add("--------------------------------------------------------------------------------");

                    FileLog.writeln("-------------------------------------------------");
                    FileLog.writeln("Các sự kiện đã chọn:");
                    foreach (Event ev in GT)
                    {
                        FileLog.writeln(ev.name);
                    }
                    FileLog.writeln("----- Kết quả -----\n---------> " + evresult.name);
                }
                else
                {
                    listbox_KetQua.Items.Add("-----> Chưa thể suy diễn, hãy chọn thêm triệu chứng");
                    FileLog.writeln("----- Kết quả -----\n---------> Chưa thể suy diễn");
                }
            }
            else
            {
                MessageBox.Show(null, "Bạn chưa chọn triệu chứng nào", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        
        private void filter_sat(Queue<Rule> SAT, List<string> TG, List<Object.Rule> R)
        {
            foreach (Object.Rule item in R)
            {
                if (check_sat(TG,item)){
                    SAT.Enqueue(item);
                }
            }
        }
        private bool check_sat(List<string> TG,Object.Rule R)
        {
            
            string[] rspl = R.left.Split("^");
            foreach(string r in rspl)
            {
                if (!TG.Contains(r))
                {
                    return false;
                }
            }
            return true;
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
            listbox_KetQua.Items.Clear();
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

    }
}
