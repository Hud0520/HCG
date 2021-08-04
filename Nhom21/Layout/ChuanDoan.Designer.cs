namespace Nhom21.Layout
{
    partial class ChuanDoan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_SuKien = new System.Windows.Forms.DataGridView();
            this.mask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensukien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_XacNhanSuKien = new System.Windows.Forms.DataGridView();
            this.mask1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensukien1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_ThemSuKien = new System.Windows.Forms.Button();
            this.btn_XoaSuKien = new System.Windows.Forms.Button();
            this.btn_SuyDien = new System.Windows.Forms.Button();
            this.listbox_KetQua = new System.Windows.Forms.ListBox();
            this.picturebox_KetQua = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SuKien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_XacNhanSuKien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_KetQua)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_SuKien
            // 
            this.dgv_SuKien.AllowUserToAddRows = false;
            this.dgv_SuKien.AllowUserToDeleteRows = false;
            this.dgv_SuKien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SuKien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mask,
            this.tensukien});
            this.dgv_SuKien.Location = new System.Drawing.Point(9, 31);
            this.dgv_SuKien.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgv_SuKien.Name = "dgv_SuKien";
            this.dgv_SuKien.ReadOnly = true;
            this.dgv_SuKien.Size = new System.Drawing.Size(409, 352);
            this.dgv_SuKien.TabIndex = 1;
            this.dgv_SuKien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SuKien_CellClick);
            this.dgv_SuKien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SuKien_CellContentClick);
            // 
            // mask
            // 
            this.mask.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.mask.DataPropertyName = "mask";
            this.mask.HeaderText = "Mã sự kiện";
            this.mask.Name = "mask";
            this.mask.ReadOnly = true;
            this.mask.Width = 105;
            // 
            // tensukien
            // 
            this.tensukien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tensukien.DataPropertyName = "tensukien";
            this.tensukien.HeaderText = "Tên sự kiện";
            this.tensukien.Name = "tensukien";
            this.tensukien.ReadOnly = true;
            // 
            // dgv_XacNhanSuKien
            // 
            this.dgv_XacNhanSuKien.AllowUserToAddRows = false;
            this.dgv_XacNhanSuKien.AllowUserToDeleteRows = false;
            this.dgv_XacNhanSuKien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_XacNhanSuKien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mask1,
            this.tensukien1});
            this.dgv_XacNhanSuKien.Location = new System.Drawing.Point(9, 31);
            this.dgv_XacNhanSuKien.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgv_XacNhanSuKien.Name = "dgv_XacNhanSuKien";
            this.dgv_XacNhanSuKien.ReadOnly = true;
            this.dgv_XacNhanSuKien.Size = new System.Drawing.Size(388, 280);
            this.dgv_XacNhanSuKien.TabIndex = 2;
            this.dgv_XacNhanSuKien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_XacNhanSuKien_CellClick);
            this.dgv_XacNhanSuKien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_XacNhanSuKien_CellContentClick);
            // 
            // mask1
            // 
            this.mask1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.mask1.DataPropertyName = "mask";
            this.mask1.HeaderText = "Mã sự kiện";
            this.mask1.Name = "mask1";
            this.mask1.ReadOnly = true;
            this.mask1.Width = 105;
            // 
            // tensukien1
            // 
            this.tensukien1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tensukien1.DataPropertyName = "tensukien";
            this.tensukien1.HeaderText = "Tên sự kiện";
            this.tensukien1.Name = "tensukien1";
            this.tensukien1.ReadOnly = true;
            // 
            // btn_ThemSuKien
            // 
            this.btn_ThemSuKien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThemSuKien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ThemSuKien.Image = global::Nhom21.Properties.Resources.Forward;
            this.btn_ThemSuKien.Location = new System.Drawing.Point(462, 48);
            this.btn_ThemSuKien.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_ThemSuKien.Name = "btn_ThemSuKien";
            this.btn_ThemSuKien.Size = new System.Drawing.Size(141, 55);
            this.btn_ThemSuKien.TabIndex = 3;
            this.btn_ThemSuKien.UseVisualStyleBackColor = true;
            this.btn_ThemSuKien.Click += new System.EventHandler(this.btn_ThemSuKien_Click);
            // 
            // btn_XoaSuKien
            // 
            this.btn_XoaSuKien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XoaSuKien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_XoaSuKien.Image = global::Nhom21.Properties.Resources.Back;
            this.btn_XoaSuKien.Location = new System.Drawing.Point(462, 138);
            this.btn_XoaSuKien.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_XoaSuKien.Name = "btn_XoaSuKien";
            this.btn_XoaSuKien.Size = new System.Drawing.Size(141, 55);
            this.btn_XoaSuKien.TabIndex = 4;
            this.btn_XoaSuKien.UseVisualStyleBackColor = true;
            this.btn_XoaSuKien.Click += new System.EventHandler(this.btn_XoaSuKien_Click);
            // 
            // btn_SuyDien
            // 
            this.btn_SuyDien.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_SuyDien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SuyDien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_SuyDien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SuyDien.Location = new System.Drawing.Point(462, 411);
            this.btn_SuyDien.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_SuyDien.Name = "btn_SuyDien";
            this.btn_SuyDien.Size = new System.Drawing.Size(141, 55);
            this.btn_SuyDien.TabIndex = 5;
            this.btn_SuyDien.Text = "Chẩn Đoán";
            this.btn_SuyDien.UseVisualStyleBackColor = false;
            this.btn_SuyDien.Click += new System.EventHandler(this.btn_SuyDien_Click);
            // 
            // listbox_KetQua
            // 
            this.listbox_KetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listbox_KetQua.FormattingEnabled = true;
            this.listbox_KetQua.ItemHeight = 20;
            this.listbox_KetQua.Location = new System.Drawing.Point(9, 40);
            this.listbox_KetQua.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listbox_KetQua.Name = "listbox_KetQua";
            this.listbox_KetQua.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listbox_KetQua.Size = new System.Drawing.Size(385, 124);
            this.listbox_KetQua.TabIndex = 6;
            this.listbox_KetQua.SelectedIndexChanged += new System.EventHandler(this.listbox_KetQua_SelectedIndexChanged);
            // 
            // picturebox_KetQua
            // 
            this.picturebox_KetQua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picturebox_KetQua.Location = new System.Drawing.Point(7, 327);
            this.picturebox_KetQua.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picturebox_KetQua.Name = "picturebox_KetQua";
            this.picturebox_KetQua.Size = new System.Drawing.Size(292, 12);
            this.picturebox_KetQua.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturebox_KetQua.TabIndex = 7;
            this.picturebox_KetQua.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_SuKien);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(2, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(422, 388);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sự kiện";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_XacNhanSuKien);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(629, 3);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(402, 318);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sự kiện đã chọn";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listbox_KetQua);
            this.groupBox3.Controls.Add(this.picturebox_KetQua);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(632, 345);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(399, 170);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kết quả";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Refresh.Location = new System.Drawing.Point(462, 228);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(141, 55);
            this.btn_Refresh.TabIndex = 16;
            this.btn_Refresh.Text = "Reset";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // txtTim
            // 
            this.txtTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTim.Location = new System.Drawing.Point(114, 422);
            this.txtTim.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTim.Multiline = true;
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(262, 33);
            this.txtTim.TabIndex = 17;
            this.txtTim.TextChanged += new System.EventHandler(this.txtTim_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 430);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Tìm dấu hiệu:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::Nhom21.Properties.Resources.Delete;
            this.btnXoa.Location = new System.Drawing.Point(384, 422);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(36, 33);
            this.btnXoa.TabIndex = 21;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // ChuanDoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1032, 519);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_SuyDien);
            this.Controls.Add(this.btn_XoaSuKien);
            this.Controls.Add(this.btn_ThemSuKien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "ChuanDoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ chuyên gia";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SuKien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_XacNhanSuKien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_KetQua)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_SuKien;
        private System.Windows.Forms.DataGridView dgv_XacNhanSuKien;
        private System.Windows.Forms.Button btn_ThemSuKien;
        private System.Windows.Forms.Button btn_XoaSuKien;
        private System.Windows.Forms.Button btn_SuyDien;
        private System.Windows.Forms.ListBox listbox_KetQua;
        private System.Windows.Forms.PictureBox picturebox_KetQua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn mask1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensukien1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mask;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensukien;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXoa;
    }
}

