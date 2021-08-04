namespace Nhom21.Layout
{
    partial class Luat
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_Luat = new System.Windows.Forms.DataGridView();
            this.MaLuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VeTrai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VePhai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_MaLuat = new System.Windows.Forms.TextBox();
            this.txt_VeTrai = new System.Windows.Forms.TextBox();
            this.txt_VePhai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Luat)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Luat
            // 
            this.dgv_Luat.AllowUserToAddRows = false;
            this.dgv_Luat.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Luat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Luat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Luat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLuat,
            this.VeTrai,
            this.VePhai});
            this.dgv_Luat.Location = new System.Drawing.Point(56, 93);
            this.dgv_Luat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgv_Luat.Name = "dgv_Luat";
            this.dgv_Luat.ReadOnly = true;
            this.dgv_Luat.Size = new System.Drawing.Size(475, 396);
            this.dgv_Luat.TabIndex = 0;
            this.dgv_Luat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Luat_CellClick);
            // 
            // MaLuat
            // 
            this.MaLuat.DataPropertyName = "maluat";
            this.MaLuat.HeaderText = "Mã luật";
            this.MaLuat.Name = "MaLuat";
            this.MaLuat.ReadOnly = true;
            this.MaLuat.Width = 90;
            // 
            // VeTrai
            // 
            this.VeTrai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VeTrai.DataPropertyName = "vetrai";
            this.VeTrai.HeaderText = "Vế trái";
            this.VeTrai.Name = "VeTrai";
            this.VeTrai.ReadOnly = true;
            // 
            // VePhai
            // 
            this.VePhai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.VePhai.DataPropertyName = "vephai";
            this.VePhai.HeaderText = "Vế phải";
            this.VePhai.Name = "VePhai";
            this.VePhai.ReadOnly = true;
            this.VePhai.Width = 88;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(420, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Quản lý tập luật";
            // 
            // txt_MaLuat
            // 
            this.txt_MaLuat.Enabled = false;
            this.txt_MaLuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_MaLuat.Location = new System.Drawing.Point(654, 115);
            this.txt_MaLuat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_MaLuat.Name = "txt_MaLuat";
            this.txt_MaLuat.Size = new System.Drawing.Size(322, 26);
            this.txt_MaLuat.TabIndex = 5;
            // 
            // txt_VeTrai
            // 
            this.txt_VeTrai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_VeTrai.Location = new System.Drawing.Point(654, 187);
            this.txt_VeTrai.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_VeTrai.Name = "txt_VeTrai";
            this.txt_VeTrai.Size = new System.Drawing.Size(322, 26);
            this.txt_VeTrai.TabIndex = 6;
            // 
            // txt_VePhai
            // 
            this.txt_VePhai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_VePhai.Location = new System.Drawing.Point(654, 260);
            this.txt_VePhai.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_VePhai.Name = "txt_VePhai";
            this.txt_VePhai.Size = new System.Drawing.Size(322, 26);
            this.txt_VePhai.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(574, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mã luật";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(574, 191);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Vế trái";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(574, 263);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Vế phải";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Xoa.Image = global::Nhom21.Properties.Resources.Delete;
            this.btn_Xoa.Location = new System.Drawing.Point(857, 328);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(119, 63);
            this.btn_Xoa.TabIndex = 11;
            this.btn_Xoa.Text = "Xóa  ";
            this.btn_Xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Xoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Sua.Image = global::Nhom21.Properties.Resources.Modify;
            this.btn_Sua.Location = new System.Drawing.Point(720, 328);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(119, 63);
            this.btn_Sua.TabIndex = 12;
            this.btn_Sua.Text = "Sửa    ";
            this.btn_Sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Sua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Them.Image = global::Nhom21.Properties.Resources.Add;
            this.btn_Them.Location = new System.Drawing.Point(573, 328);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(117, 63);
            this.btn_Them.TabIndex = 13;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Them.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // Luat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 519);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_VePhai);
            this.Controls.Add(this.txt_VeTrai);
            this.Controls.Add(this.txt_MaLuat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Luat);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Luat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý tập luật";
            this.Load += new System.EventHandler(this.Luat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Luat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Luat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_MaLuat;
        private System.Windows.Forms.TextBox txt_VeTrai;
        private System.Windows.Forms.TextBox txt_VePhai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn VeTrai;
        private System.Windows.Forms.DataGridViewTextBoxColumn VePhai;
    }
}