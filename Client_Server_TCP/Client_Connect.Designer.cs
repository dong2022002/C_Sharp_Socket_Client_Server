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
            this.txt_Port = new System.Windows.Forms.TextBox();
            this.lbl_C_P = new System.Windows.Forms.Label();
            this.btn_KetNoi = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Port
            // 
            this.txt_Port.Location = new System.Drawing.Point(12, 38);
            this.txt_Port.Name = "txt_Port";
            this.txt_Port.Size = new System.Drawing.Size(210, 23);
            this.txt_Port.TabIndex = 0;
            // 
            // lbl_C_P
            // 
            this.lbl_C_P.AutoSize = true;
            this.lbl_C_P.Location = new System.Drawing.Point(48, 9);
            this.lbl_C_P.Name = "lbl_C_P";
            this.lbl_C_P.Size = new System.Drawing.Size(127, 15);
            this.lbl_C_P.TabIndex = 1;
            this.lbl_C_P.Text = "Nhập Port để tham gia";
            // 
            // btn_KetNoi
            // 
            this.btn_KetNoi.Location = new System.Drawing.Point(12, 78);
            this.btn_KetNoi.Name = "btn_KetNoi";
            this.btn_KetNoi.Size = new System.Drawing.Size(75, 23);
            this.btn_KetNoi.TabIndex = 2;
            this.btn_KetNoi.Text = "Kết nối";
            this.btn_KetNoi.UseVisualStyleBackColor = true;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(147, 78);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_Thoat.TabIndex = 3;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            // 
            // form_ClientConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 115);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_KetNoi);
            this.Controls.Add(this.lbl_C_P);
            this.Controls.Add(this.txt_Port);
            this.Name = "form_ClientConnect";
            this.Text = "Client_Connect";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_Port;
        private Label lbl_C_P;
        private Button btn_KetNoi;
        private Button btn_Thoat;
    }
}