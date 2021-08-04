namespace Nhom21.Layout
{
    partial class SuKien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_SuKien = new System.Windows.Forms.DataGridView();
            this.masukien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensukien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.source = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_MaSuKien = new System.Windows.Forms.TextBox();
            this.txt_TenSuKien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.txtThongTin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SuKien)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_SuKien
            // 
            this.dgv_SuKien.AllowUserToAddRows = false;
            this.dgv_SuKien.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_SuKien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_SuKien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SuKien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masukien,
            this.tensukien,
            this.source});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_SuKien.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_SuKien.Location = new System.Drawing.Point(34, 77);
            this.dgv_SuKien.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgv_SuKien.Name = "dgv_SuKien";
            this.dgv_SuKien.ReadOnly = true;
            this.dgv_SuKien.Size = new System.Drawing.Size(517, 426);
            this.dgv_SuKien.TabIndex = 2;
            this.dgv_SuKien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SuKien_CellClick);
            // 
            // masukien
            // 
            this.masukien.DataPropertyName = "mask";
            this.masukien.HeaderText = "Mã";
            this.masukien.Name = "masukien";
            this.masukien.ReadOnly = true;
            this.masukien.Width = 60;
            // 
            // tensukien
            // 
            this.tensukien.DataPropertyName = "tensukien";
            this.tensukien.HeaderText = "Tên sự kiện";
            this.tensukien.Name = "tensukien";
            this.tensukien.ReadOnly = true;
            this.tensukien.Width = 180;
            // 
            // source
            // 
            this.source.DataPropertyName = "source";
            this.source.HeaderText = "Thông tin";
            this.source.Name = "source";
            this.source.ReadOnly = true;
            this.source.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(421, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quản lý sự kiện";
            // 
            // txt_MaSuKien
            // 
            this.txt_MaSuKien.Enabled = false;
            this.txt_MaSuKien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_MaSuKien.Location = new System.Drawing.Point(707, 123);
            this.txt_MaSuKien.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_MaSuKien.Name = "txt_MaSuKien";
            this.txt_MaSuKien.Size = new System.Drawing.Size(291, 26);
            this.txt_MaSuKien.TabIndex = 4;
            // 
            // txt_TenSuKien
            // 
            this.txt_TenSuKien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_TenSuKien.Location = new System.Drawing.Point(707, 196);
            this.txt_TenSuKien.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_TenSuKien.Name = "txt_TenSuKien";
            this.txt_TenSuKien.Size = new System.Drawing.Size(291, 26);
            this.txt_TenSuKien.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(581, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã sự kiện";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(581, 200);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tên sự kiện";
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Them.Image = global::Nhom21.Properties.Resources.Add;
            this.btn_Them.Location = new System.Drawing.Point(584, 367);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(133, 63);
            this.btn_Them.TabIndex = 8;
            this.btn_Them.Text = "Thêm  ";
            this.btn_Them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Them.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Sua.Image = global::Nhom21.Properties.Resources.Modify;
            this.btn_Sua.Location = new System.Drawing.Point(738, 367);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(118, 63);
            this.btn_Sua.TabIndex = 9;
            this.btn_Sua.Text = "Sửa  ";
            this.btn_Sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Sua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Xoa.Image = global::Nhom21.Properties.Resources.Delete;
            this.btn_Xoa.Location = new System.Drawing.Point(879, 367);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(120, 63);
            this.btn_Xoa.TabIndex = 11;
            this.btn_Xoa.Text = "Xóa  ";
            this.btn_Xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Xoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // txtThongTin
            // 
            this.txtThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtThongTin.Location = new System.Drawing.Point(707, 263);
            this.txtThongTin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtThongTin.Name = "txtThongTin";
            this.txtThongTin.Size = new System.Drawing.Size(291, 26);
            this.txtThongTin.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(579, 270);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Thông tin";
            // 
            // SuKien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 519);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtThongTin);
            this.Controls.Add(this.txt_TenSuKien);
            this.Controls.Add(this.txt_MaSuKien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_SuKien);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "SuKien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sự kiện";
            this.Load += new System.EventHandler(this.SuKien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SuKien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_SuKien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_MaSuKien;
        private System.Windows.Forms.TextBox txt_TenSuKien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn masukien;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensukien;
        private System.Windows.Forms.DataGridViewTextBoxColumn source;
        private System.Windows.Forms.TextBox txtThongTin;
        private System.Windows.Forms.Label label4;
    }
}