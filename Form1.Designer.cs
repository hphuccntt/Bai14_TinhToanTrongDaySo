namespace Bai14_TinhToanTrongDaySo
{
    partial class Form1
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
            this.txtSo1 = new System.Windows.Forms.TextBox();
            this.txtSo2 = new System.Windows.Forms.TextBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.txtChan = new System.Windows.Forms.TextBox();
            this.txtLe = new System.Windows.Forms.TextBox();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtSo1
            // 
            this.txtSo1.Location = new System.Drawing.Point(41, 51);
            this.txtSo1.Name = "txtSo1";
            this.txtSo1.Size = new System.Drawing.Size(100, 24);
            this.txtSo1.TabIndex = 0;
            // 
            // txtSo2
            // 
            this.txtSo2.Location = new System.Drawing.Point(41, 92);
            this.txtSo2.Name = "txtSo2";
            this.txtSo2.Size = new System.Drawing.Size(100, 24);
            this.txtSo2.TabIndex = 0;
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(41, 139);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(100, 23);
            this.btnTinh.TabIndex = 1;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // txtChan
            // 
            this.txtChan.Location = new System.Drawing.Point(161, 51);
            this.txtChan.Name = "txtChan";
            this.txtChan.Size = new System.Drawing.Size(192, 24);
            this.txtChan.TabIndex = 0;
            // 
            // txtLe
            // 
            this.txtLe.Location = new System.Drawing.Point(161, 92);
            this.txtLe.Name = "txtLe";
            this.txtLe.Size = new System.Drawing.Size(192, 24);
            this.txtLe.TabIndex = 0;
            // 
            // txtTong
            // 
            this.txtTong.Location = new System.Drawing.Point(161, 138);
            this.txtTong.Name = "txtTong";
            this.txtTong.Size = new System.Drawing.Size(192, 24);
            this.txtTong.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 623);
            this.Controls.Add(this.txtTong);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.txtLe);
            this.Controls.Add(this.txtSo2);
            this.Controls.Add(this.txtChan);
            this.Controls.Add(this.txtSo1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSo1;
        private System.Windows.Forms.TextBox txtSo2;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.TextBox txtChan;
        private System.Windows.Forms.TextBox txtLe;
        private System.Windows.Forms.TextBox txtTong;
    }
}

