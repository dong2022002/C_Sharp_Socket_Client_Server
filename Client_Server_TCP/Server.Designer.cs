﻿namespace Server_TCP
{
    partial class form_Server
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.group_Chat = new System.Windows.Forms.GroupBox();
            this.btn_DoiPort = new System.Windows.Forms.Button();
            this.txt_Port = new System.Windows.Forms.TextBox();
            this.lv_KhungChat = new System.Windows.Forms.ListView();
            this.txt_TinNhan = new System.Windows.Forms.TextBox();
            this.btn_Gui = new System.Windows.Forms.Button();
            this.group_DanhSach = new System.Windows.Forms.GroupBox();
            this.lv_DanhSach = new System.Windows.Forms.ListView();
            this.btn_Nhom = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.group_Chat.SuspendLayout();
            this.group_DanhSach.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Port);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 58);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Port";
            // 
            // group_Chat
            // 
            this.group_Chat.Controls.Add(this.lv_KhungChat);
            this.group_Chat.Location = new System.Drawing.Point(13, 83);
            this.group_Chat.Name = "group_Chat";
            this.group_Chat.Size = new System.Drawing.Size(535, 225);
            this.group_Chat.TabIndex = 1;
            this.group_Chat.TabStop = false;
            this.group_Chat.Text = "Chat";
            // 
            // btn_DoiPort
            // 
            this.btn_DoiPort.Location = new System.Drawing.Point(204, 33);
            this.btn_DoiPort.Name = "btn_DoiPort";
            this.btn_DoiPort.Size = new System.Drawing.Size(75, 23);
            this.btn_DoiPort.TabIndex = 0;
            this.btn_DoiPort.Text = "Đổi Port";
            this.btn_DoiPort.UseVisualStyleBackColor = true;
            // 
            // txt_Port
            // 
            this.txt_Port.Location = new System.Drawing.Point(6, 22);
            this.txt_Port.Name = "txt_Port";
            this.txt_Port.ReadOnly = true;
            this.txt_Port.Size = new System.Drawing.Size(162, 23);
            this.txt_Port.TabIndex = 0;
            // 
            // lv_KhungChat
            // 
            this.lv_KhungChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_KhungChat.Location = new System.Drawing.Point(3, 19);
            this.lv_KhungChat.Name = "lv_KhungChat";
            this.lv_KhungChat.Size = new System.Drawing.Size(529, 203);
            this.lv_KhungChat.TabIndex = 0;
            this.lv_KhungChat.UseCompatibleStateImageBehavior = false;
            // 
            // txt_TinNhan
            // 
            this.txt_TinNhan.Location = new System.Drawing.Point(16, 315);
            this.txt_TinNhan.Multiline = true;
            this.txt_TinNhan.Name = "txt_TinNhan";
            this.txt_TinNhan.Size = new System.Drawing.Size(439, 36);
            this.txt_TinNhan.TabIndex = 2;
            // 
            // btn_Gui
            // 
            this.btn_Gui.Location = new System.Drawing.Point(470, 315);
            this.btn_Gui.Name = "btn_Gui";
            this.btn_Gui.Size = new System.Drawing.Size(75, 36);
            this.btn_Gui.TabIndex = 3;
            this.btn_Gui.Text = "Gửi";
            this.btn_Gui.UseVisualStyleBackColor = true;
            this.btn_Gui.Click += new System.EventHandler(this.button2_Click);
            // 
            // group_DanhSach
            // 
            this.group_DanhSach.Controls.Add(this.lv_DanhSach);
            this.group_DanhSach.Location = new System.Drawing.Point(563, 11);
            this.group_DanhSach.Name = "group_DanhSach";
            this.group_DanhSach.Size = new System.Drawing.Size(219, 343);
            this.group_DanhSach.TabIndex = 4;
            this.group_DanhSach.TabStop = false;
            this.group_DanhSach.Text = "Danh sách thành viên";
            // 
            // lv_DanhSach
            // 
            this.lv_DanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_DanhSach.Location = new System.Drawing.Point(3, 19);
            this.lv_DanhSach.Name = "lv_DanhSach";
            this.lv_DanhSach.Size = new System.Drawing.Size(213, 321);
            this.lv_DanhSach.TabIndex = 0;
            this.lv_DanhSach.UseCompatibleStateImageBehavior = false;
            // 
            // btn_Nhom
            // 
            this.btn_Nhom.Location = new System.Drawing.Point(433, 34);
            this.btn_Nhom.Name = "btn_Nhom";
            this.btn_Nhom.Size = new System.Drawing.Size(112, 23);
            this.btn_Nhom.TabIndex = 5;
            this.btn_Nhom.Text = "Tạo nhóm chat";
            this.btn_Nhom.UseVisualStyleBackColor = true;
            // 
            // form_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 366);
            this.Controls.Add(this.btn_Nhom);
            this.Controls.Add(this.group_DanhSach);
            this.Controls.Add(this.btn_Gui);
            this.Controls.Add(this.txt_TinNhan);
            this.Controls.Add(this.btn_DoiPort);
            this.Controls.Add(this.group_Chat);
            this.Controls.Add(this.groupBox1);
            this.Name = "form_Server";
            this.Text = "Server";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.group_Chat.ResumeLayout(false);
            this.group_DanhSach.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txt_Port;
        private GroupBox group_Chat;
        private Button btn_DoiPort;
        private ListView lv_KhungChat;
        private TextBox txt_TinNhan;
        private Button btn_Gui;
        private GroupBox group_DanhSach;
        private ListView lv_DanhSach;
        private Button btn_Nhom;
    }
}