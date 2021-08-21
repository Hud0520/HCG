namespace Nhom21.Layout
{
    partial class CacBuocSuyDien
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
            this.rtb_CacBuocSuyDien = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtb_CacBuocSuyDien
            // 
            this.rtb_CacBuocSuyDien.Location = new System.Drawing.Point(13, 43);
            this.rtb_CacBuocSuyDien.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rtb_CacBuocSuyDien.Name = "rtb_CacBuocSuyDien";
            this.rtb_CacBuocSuyDien.Size = new System.Drawing.Size(1006, 464);
            this.rtb_CacBuocSuyDien.TabIndex = 0;
            this.rtb_CacBuocSuyDien.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(404, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quá trình suy diễn";
            // 
            // CacBuocSuyDien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1032, 519);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtb_CacBuocSuyDien);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "CacBuocSuyDien";
            this.Text = "Các bước suy diễn";
            this.Load += new System.EventHandler(this.frm_CacBuocSuyDien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_CacBuocSuyDien;
        private System.Windows.Forms.Label label1;
    }
}