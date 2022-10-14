using System.Windows.Forms;

namespace TCP_MultiChat
{
    partial class form_ClientConnect
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
            this.components = new System.ComponentModel.Container();
            this.txt_Port = new System.Windows.Forms.TextBox();
            this.lbl_C_P = new System.Windows.Forms.Label();
            this.btn_KetNoi = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.lbltaikhoan = new System.Windows.Forms.Label();
            this.lblmk = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtMK = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_Port
            // 
            this.txt_Port.Location = new System.Drawing.Point(102, 33);
            this.txt_Port.Name = "txt_Port";
            this.txt_Port.Size = new System.Drawing.Size(165, 22);
            this.txt_Port.TabIndex = 0;
            // 
            // lbl_C_P
            // 
            this.lbl_C_P.AutoSize = true;
            this.lbl_C_P.Location = new System.Drawing.Point(18, 38);
            this.lbl_C_P.Name = "lbl_C_P";
            this.lbl_C_P.Size = new System.Drawing.Size(70, 16);
            this.lbl_C_P.TabIndex = 1;
            this.lbl_C_P.Text = "Nhập Port:";
            // 
            // btn_KetNoi
            // 
            this.btn_KetNoi.Location = new System.Drawing.Point(102, 141);
            this.btn_KetNoi.Name = "btn_KetNoi";
            this.btn_KetNoi.Size = new System.Drawing.Size(68, 25);
            this.btn_KetNoi.TabIndex = 2;
            this.btn_KetNoi.Text = "Kết nối";
            this.btn_KetNoi.UseVisualStyleBackColor = true;
            this.btn_KetNoi.Click += new System.EventHandler(this.btn_KetNoi_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(192, 141);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 25);
            this.btn_Thoat.TabIndex = 3;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // lbltaikhoan
            // 
            this.lbltaikhoan.AutoSize = true;
            this.lbltaikhoan.Location = new System.Drawing.Point(18, 74);
            this.lbltaikhoan.Name = "lbltaikhoan";
            this.lbltaikhoan.Size = new System.Drawing.Size(67, 16);
            this.lbltaikhoan.TabIndex = 1;
            this.lbltaikhoan.Text = "Tài khoản";
            // 
            // lblmk
            // 
            this.lblmk.AutoSize = true;
            this.lblmk.Location = new System.Drawing.Point(18, 107);
            this.lblmk.Name = "lblmk";
            this.lblmk.Size = new System.Drawing.Size(61, 16);
            this.lblmk.TabIndex = 1;
            this.lblmk.Text = "Mật khẩu";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(102, 71);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(165, 22);
            this.txtTaiKhoan.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(102, 104);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(165, 22);
            this.txtMK.TabIndex = 4;
            // 
            // form_ClientConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 190);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_KetNoi);
            this.Controls.Add(this.lblmk);
            this.Controls.Add(this.lbltaikhoan);
            this.Controls.Add(this.lbl_C_P);
            this.Controls.Add(this.txt_Port);
            this.Name = "form_ClientConnect";
            this.Text = "Client_Connect";
            this.Load += new System.EventHandler(this.form_ClientConnect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_Port;
        private Label lbl_C_P;
        private Button btn_KetNoi;
        private Button btn_Thoat;
        private Label lbltaikhoan;
        private Label lblmk;
        private TextBox txtTaiKhoan;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtMK;
    }
}