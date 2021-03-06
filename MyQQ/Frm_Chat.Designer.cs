﻿namespace MyQQ
{
    partial class Frm_Chat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Chat));
            this.lblFriend = new System.Windows.Forms.Label();
            this.pboxHead = new System.Windows.Forms.PictureBox();
            this.pboxMin = new System.Windows.Forms.PictureBox();
            this.pboxClose = new System.Windows.Forms.PictureBox();
            this.pboxInfo = new System.Windows.Forms.PictureBox();
            this.rtxtMessage = new System.Windows.Forms.RichTextBox();
            this.rtxtChat = new System.Windows.Forms.RichTextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.tmShowMessage = new System.Windows.Forms.Timer(this.components);
            this.imglistHead = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pboxHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFriend
            // 
            this.lblFriend.BackColor = System.Drawing.Color.LightGray;
            this.lblFriend.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblFriend.Location = new System.Drawing.Point(57, 6);
            this.lblFriend.Name = "lblFriend";
            this.lblFriend.Size = new System.Drawing.Size(519, 24);
            this.lblFriend.TabIndex = 0;
            this.lblFriend.Text = "label1";
            this.lblFriend.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pboxHead
            // 
            this.pboxHead.Location = new System.Drawing.Point(7, 3);
            this.pboxHead.Name = "pboxHead";
            this.pboxHead.Size = new System.Drawing.Size(44, 42);
            this.pboxHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxHead.TabIndex = 1;
            this.pboxHead.TabStop = false;
            // 
            // pboxMin
            // 
            this.pboxMin.BackColor = System.Drawing.Color.Transparent;
            this.pboxMin.Location = new System.Drawing.Point(647, 2);
            this.pboxMin.Name = "pboxMin";
            this.pboxMin.Size = new System.Drawing.Size(27, 28);
            this.pboxMin.TabIndex = 2;
            this.pboxMin.TabStop = false;
            // 
            // pboxClose
            // 
            this.pboxClose.BackColor = System.Drawing.Color.Transparent;
            this.pboxClose.Location = new System.Drawing.Point(704, 2);
            this.pboxClose.Name = "pboxClose";
            this.pboxClose.Size = new System.Drawing.Size(27, 28);
            this.pboxClose.TabIndex = 3;
            this.pboxClose.TabStop = false;
            this.pboxClose.Click += new System.EventHandler(this.pboxClose_Click);
            // 
            // pboxInfo
            // 
            this.pboxInfo.BackColor = System.Drawing.Color.Transparent;
            this.pboxInfo.Location = new System.Drawing.Point(504, 480);
            this.pboxInfo.Name = "pboxInfo";
            this.pboxInfo.Size = new System.Drawing.Size(89, 20);
            this.pboxInfo.TabIndex = 4;
            this.pboxInfo.TabStop = false;
            // 
            // rtxtMessage
            // 
            this.rtxtMessage.BackColor = System.Drawing.Color.White;
            this.rtxtMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtMessage.Location = new System.Drawing.Point(0, 51);
            this.rtxtMessage.Name = "rtxtMessage";
            this.rtxtMessage.Size = new System.Drawing.Size(594, 427);
            this.rtxtMessage.TabIndex = 5;
            this.rtxtMessage.Text = "";
            // 
            // rtxtChat
            // 
            this.rtxtChat.BackColor = System.Drawing.Color.White;
            this.rtxtChat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtChat.Location = new System.Drawing.Point(0, 502);
            this.rtxtChat.Name = "rtxtChat";
            this.rtxtChat.Size = new System.Drawing.Size(594, 76);
            this.rtxtChat.TabIndex = 6;
            this.rtxtChat.Text = "";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.Font = new System.Drawing.Font("宋体", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.Location = new System.Drawing.Point(431, 580);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(71, 28);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("宋体", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSend.Location = new System.Drawing.Point(505, 580);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(71, 28);
            this.btnSend.TabIndex = 8;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // tmShowMessage
            // 
            this.tmShowMessage.Enabled = true;
            this.tmShowMessage.Interval = 2000;
            // 
            // imglistHead
            // 
            this.imglistHead.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglistHead.ImageStream")));
            this.imglistHead.TransparentColor = System.Drawing.Color.Transparent;
            this.imglistHead.Images.SetKeyName(0, "1.bmp");
            this.imglistHead.Images.SetKeyName(1, "2.bmp");
            this.imglistHead.Images.SetKeyName(2, "3.bmp");
            this.imglistHead.Images.SetKeyName(3, "4.bmp");
            this.imglistHead.Images.SetKeyName(4, "5.bmp");
            this.imglistHead.Images.SetKeyName(5, "6.bmp");
            this.imglistHead.Images.SetKeyName(6, "7.bmp");
            this.imglistHead.Images.SetKeyName(7, "8.bmp");
            this.imglistHead.Images.SetKeyName(8, "9.bmp");
            this.imglistHead.Images.SetKeyName(9, "10.bmp");
            this.imglistHead.Images.SetKeyName(10, "11.bmp");
            this.imglistHead.Images.SetKeyName(11, "12.bmp");
            this.imglistHead.Images.SetKeyName(12, "13.bmp");
            this.imglistHead.Images.SetKeyName(13, "14.bmp");
            this.imglistHead.Images.SetKeyName(14, "15.bmp");
            this.imglistHead.Images.SetKeyName(15, "16.bmp");
            this.imglistHead.Images.SetKeyName(16, "17.bmp");
            this.imglistHead.Images.SetKeyName(17, "18.bmp");
            this.imglistHead.Images.SetKeyName(18, "19.bmp");
            this.imglistHead.Images.SetKeyName(19, "20.bmp");
            this.imglistHead.Images.SetKeyName(20, "21.bmp");
            this.imglistHead.Images.SetKeyName(21, "22.bmp");
            this.imglistHead.Images.SetKeyName(22, "23.bmp");
            this.imglistHead.Images.SetKeyName(23, "24.bmp");
            this.imglistHead.Images.SetKeyName(24, "25.bmp");
            this.imglistHead.Images.SetKeyName(25, "26.bmp");
            this.imglistHead.Images.SetKeyName(26, "27.bmp");
            this.imglistHead.Images.SetKeyName(27, "28.bmp");
            this.imglistHead.Images.SetKeyName(28, "29.bmp");
            this.imglistHead.Images.SetKeyName(29, "30.bmp");
            this.imglistHead.Images.SetKeyName(30, "31.bmp");
            this.imglistHead.Images.SetKeyName(31, "32.bmp");
            this.imglistHead.Images.SetKeyName(32, "33.bmp");
            this.imglistHead.Images.SetKeyName(33, "34.bmp");
            this.imglistHead.Images.SetKeyName(34, "35.bmp");
            this.imglistHead.Images.SetKeyName(35, "36.bmp");
            this.imglistHead.Images.SetKeyName(36, "37.bmp");
            this.imglistHead.Images.SetKeyName(37, "38.bmp");
            this.imglistHead.Images.SetKeyName(38, "39.bmp");
            this.imglistHead.Images.SetKeyName(39, "40.bmp");
            this.imglistHead.Images.SetKeyName(40, "41.bmp");
            this.imglistHead.Images.SetKeyName(41, "42.bmp");
            this.imglistHead.Images.SetKeyName(42, "43.bmp");
            this.imglistHead.Images.SetKeyName(43, "44.bmp");
            this.imglistHead.Images.SetKeyName(44, "45.bmp");
            this.imglistHead.Images.SetKeyName(45, "46.bmp");
            this.imglistHead.Images.SetKeyName(46, "47.bmp");
            this.imglistHead.Images.SetKeyName(47, "48.bmp");
            this.imglistHead.Images.SetKeyName(48, "49.bmp");
            this.imglistHead.Images.SetKeyName(49, "50.bmp");
            this.imglistHead.Images.SetKeyName(50, "51.bmp");
            this.imglistHead.Images.SetKeyName(51, "52.bmp");
            this.imglistHead.Images.SetKeyName(52, "53.bmp");
            this.imglistHead.Images.SetKeyName(53, "54.bmp");
            this.imglistHead.Images.SetKeyName(54, "55.bmp");
            this.imglistHead.Images.SetKeyName(55, "56.bmp");
            this.imglistHead.Images.SetKeyName(56, "57.bmp");
            this.imglistHead.Images.SetKeyName(57, "58.bmp");
            this.imglistHead.Images.SetKeyName(58, "59.bmp");
            this.imglistHead.Images.SetKeyName(59, "60.bmp");
            this.imglistHead.Images.SetKeyName(60, "61.bmp");
            this.imglistHead.Images.SetKeyName(61, "62.bmp");
            this.imglistHead.Images.SetKeyName(62, "63.bmp");
            this.imglistHead.Images.SetKeyName(63, "64.bmp");
            this.imglistHead.Images.SetKeyName(64, "65.bmp");
            this.imglistHead.Images.SetKeyName(65, "66.bmp");
            this.imglistHead.Images.SetKeyName(66, "67.bmp");
            this.imglistHead.Images.SetKeyName(67, "68.bmp");
            this.imglistHead.Images.SetKeyName(68, "69.bmp");
            this.imglistHead.Images.SetKeyName(69, "70.bmp");
            this.imglistHead.Images.SetKeyName(70, "71.bmp");
            this.imglistHead.Images.SetKeyName(71, "72.bmp");
            this.imglistHead.Images.SetKeyName(72, "73.bmp");
            this.imglistHead.Images.SetKeyName(73, "74.bmp");
            this.imglistHead.Images.SetKeyName(74, "75.bmp");
            this.imglistHead.Images.SetKeyName(75, "76.bmp");
            this.imglistHead.Images.SetKeyName(76, "77.bmp");
            this.imglistHead.Images.SetKeyName(77, "78.bmp");
            this.imglistHead.Images.SetKeyName(78, "79.bmp");
            this.imglistHead.Images.SetKeyName(79, "80.bmp");
            this.imglistHead.Images.SetKeyName(80, "81.bmp");
            this.imglistHead.Images.SetKeyName(81, "82.bmp");
            this.imglistHead.Images.SetKeyName(82, "83.bmp");
            this.imglistHead.Images.SetKeyName(83, "84.bmp");
            this.imglistHead.Images.SetKeyName(84, "85.bmp");
            this.imglistHead.Images.SetKeyName(85, "86.bmp");
            this.imglistHead.Images.SetKeyName(86, "87.bmp");
            this.imglistHead.Images.SetKeyName(87, "88.bmp");
            this.imglistHead.Images.SetKeyName(88, "89.bmp");
            this.imglistHead.Images.SetKeyName(89, "90.bmp");
            this.imglistHead.Images.SetKeyName(90, "91.bmp");
            this.imglistHead.Images.SetKeyName(91, "92.bmp");
            this.imglistHead.Images.SetKeyName(92, "93.bmp");
            this.imglistHead.Images.SetKeyName(93, "94.bmp");
            this.imglistHead.Images.SetKeyName(94, "95.bmp");
            this.imglistHead.Images.SetKeyName(95, "96.bmp");
            this.imglistHead.Images.SetKeyName(96, "97.bmp");
            this.imglistHead.Images.SetKeyName(97, "98.bmp");
            this.imglistHead.Images.SetKeyName(98, "99.bmp");
            this.imglistHead.Images.SetKeyName(99, "100.bmp");
            this.imglistHead.Images.SetKeyName(100, "back.bmp");
            // 
            // Frm_Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(737, 610);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.rtxtChat);
            this.Controls.Add(this.rtxtMessage);
            this.Controls.Add(this.pboxInfo);
            this.Controls.Add(this.pboxClose);
            this.Controls.Add(this.pboxMin);
            this.Controls.Add(this.pboxHead);
            this.Controls.Add(this.lblFriend);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Chat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Chat";
            this.Load += new System.EventHandler(this.Frm_Chat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFriend;
        private System.Windows.Forms.PictureBox pboxHead;
        private System.Windows.Forms.PictureBox pboxMin;
        private System.Windows.Forms.PictureBox pboxClose;
        private System.Windows.Forms.PictureBox pboxInfo;
        private System.Windows.Forms.RichTextBox rtxtMessage;
        private System.Windows.Forms.RichTextBox rtxtChat;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Timer tmShowMessage;
        private System.Windows.Forms.ImageList imglistHead;
    }
}