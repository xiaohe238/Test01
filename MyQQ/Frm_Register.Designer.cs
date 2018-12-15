namespace MyQQ
{
    partial class Frm_Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Register));
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.grpBaseInfo = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblNickName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.lblPwdAgain = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblStar = new System.Windows.Forms.Label();
            this.lblBloodType = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.bntCancel = new System.Windows.Forms.Button();
            this.txtNickName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtPwdAgain = new System.Windows.Forms.TextBox();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cboxStar = new System.Windows.Forms.ComboBox();
            this.cboxBoolType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.grpBaseInfo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(12, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(95, 310);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // grpBaseInfo
            // 
            this.grpBaseInfo.BackColor = System.Drawing.Color.Transparent;
            this.grpBaseInfo.Controls.Add(this.rbtnFemale);
            this.grpBaseInfo.Controls.Add(this.rbtnMale);
            this.grpBaseInfo.Controls.Add(this.txtPwdAgain);
            this.grpBaseInfo.Controls.Add(this.txtPwd);
            this.grpBaseInfo.Controls.Add(this.txtAge);
            this.grpBaseInfo.Controls.Add(this.txtNickName);
            this.grpBaseInfo.Controls.Add(this.lblPwdAgain);
            this.grpBaseInfo.Controls.Add(this.lblPwd);
            this.grpBaseInfo.Controls.Add(this.lblSex);
            this.grpBaseInfo.Controls.Add(this.lblAge);
            this.grpBaseInfo.Controls.Add(this.lblNickName);
            this.grpBaseInfo.Location = new System.Drawing.Point(114, 10);
            this.grpBaseInfo.Name = "grpBaseInfo";
            this.grpBaseInfo.Size = new System.Drawing.Size(259, 180);
            this.grpBaseInfo.TabIndex = 1;
            this.grpBaseInfo.TabStop = false;
            this.grpBaseInfo.Text = "注册基本资料";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboxBoolType);
            this.groupBox2.Controls.Add(this.cboxStar);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.lblBloodType);
            this.groupBox2.Controls.Add(this.lblStar);
            this.groupBox2.Controls.Add(this.lblName);
            this.groupBox2.Location = new System.Drawing.Point(114, 206);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 116);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "选填详细资料";
            // 
            // lblNickName
            // 
            this.lblNickName.AutoSize = true;
            this.lblNickName.Location = new System.Drawing.Point(41, 30);
            this.lblNickName.Name = "lblNickName";
            this.lblNickName.Size = new System.Drawing.Size(44, 18);
            this.lblNickName.TabIndex = 0;
            this.lblNickName.Text = "昵称";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(41, 60);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(44, 18);
            this.lblAge.TabIndex = 1;
            this.lblAge.Text = "年龄";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(41, 87);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(44, 18);
            this.lblSex.TabIndex = 2;
            this.lblSex.Text = "性别";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(41, 119);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(44, 18);
            this.lblPwd.TabIndex = 3;
            this.lblPwd.Text = "密码";
            // 
            // lblPwdAgain
            // 
            this.lblPwdAgain.AutoSize = true;
            this.lblPwdAgain.Location = new System.Drawing.Point(5, 147);
            this.lblPwdAgain.Name = "lblPwdAgain";
            this.lblPwdAgain.Size = new System.Drawing.Size(80, 18);
            this.lblPwdAgain.TabIndex = 4;
            this.lblPwdAgain.Text = "重复密码";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(10, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(80, 18);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "真实姓名";
            // 
            // lblStar
            // 
            this.lblStar.AutoSize = true;
            this.lblStar.Location = new System.Drawing.Point(45, 54);
            this.lblStar.Name = "lblStar";
            this.lblStar.Size = new System.Drawing.Size(44, 18);
            this.lblStar.TabIndex = 6;
            this.lblStar.Text = "星座";
            // 
            // lblBloodType
            // 
            this.lblBloodType.AutoSize = true;
            this.lblBloodType.Location = new System.Drawing.Point(45, 82);
            this.lblBloodType.Name = "lblBloodType";
            this.lblBloodType.Size = new System.Drawing.Size(44, 18);
            this.lblBloodType.TabIndex = 7;
            this.lblBloodType.Text = "血型";
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRegister.Location = new System.Drawing.Point(234, 326);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 3;
            this.btnRegister.Text = "注册";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // bntCancel
            // 
            this.bntCancel.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bntCancel.Location = new System.Drawing.Point(303, 326);
            this.bntCancel.Name = "bntCancel";
            this.bntCancel.Size = new System.Drawing.Size(70, 23);
            this.bntCancel.TabIndex = 4;
            this.bntCancel.Text = "取消";
            this.bntCancel.UseVisualStyleBackColor = true;
            this.bntCancel.Click += new System.EventHandler(this.bntCancel_Click);
            // 
            // txtNickName
            // 
            this.txtNickName.Location = new System.Drawing.Point(85, 26);
            this.txtNickName.Multiline = true;
            this.txtNickName.Name = "txtNickName";
            this.txtNickName.Size = new System.Drawing.Size(142, 21);
            this.txtNickName.TabIndex = 5;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(85, 56);
            this.txtAge.Multiline = true;
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(42, 21);
            this.txtAge.TabIndex = 6;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(85, 115);
            this.txtPwd.Multiline = true;
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(142, 21);
            this.txtPwd.TabIndex = 8;
            // 
            // txtPwdAgain
            // 
            this.txtPwdAgain.Location = new System.Drawing.Point(85, 143);
            this.txtPwdAgain.Multiline = true;
            this.txtPwdAgain.Name = "txtPwdAgain";
            this.txtPwdAgain.PasswordChar = '*';
            this.txtPwdAgain.Size = new System.Drawing.Size(142, 21);
            this.txtPwdAgain.TabIndex = 9;
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Checked = true;
            this.rbtnMale.Location = new System.Drawing.Point(85, 85);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(51, 22);
            this.rbtnMale.TabIndex = 10;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "男";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Location = new System.Drawing.Point(135, 85);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(51, 22);
            this.rbtnFemale.TabIndex = 11;
            this.rbtnFemale.Text = "女";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(89, 22);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(142, 21);
            this.txtName.TabIndex = 8;
            // 
            // cboxStar
            // 
            this.cboxStar.Font = new System.Drawing.Font("宋体", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboxStar.FormattingEnabled = true;
            this.cboxStar.Items.AddRange(new object[] {
            "白羊座",
            "金牛座",
            "双子座",
            "巨蟹座",
            "狮子座",
            "处女座",
            "天秤座",
            "天蝎座",
            "射手座",
            "摩羯座",
            "水瓶座",
            "双鱼座"});
            this.cboxStar.Location = new System.Drawing.Point(89, 50);
            this.cboxStar.Name = "cboxStar";
            this.cboxStar.Size = new System.Drawing.Size(142, 22);
            this.cboxStar.TabIndex = 9;
            // 
            // cboxBoolType
            // 
            this.cboxBoolType.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboxBoolType.FormattingEnabled = true;
            this.cboxBoolType.Items.AddRange(new object[] {
            "A型",
            "B型",
            "O型",
            "AB型"});
            this.cboxBoolType.Location = new System.Drawing.Point(97, 82);
            this.cboxBoolType.Name = "cboxBoolType";
            this.cboxBoolType.Size = new System.Drawing.Size(121, 24);
            this.cboxBoolType.TabIndex = 10;
            // 
            // Frm_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 361);
            this.Controls.Add(this.bntCancel);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpBaseInfo);
            this.Controls.Add(this.picLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Register";
            this.Text = "申请账号";
            this.Load += new System.EventHandler(this.Frm_Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.grpBaseInfo.ResumeLayout(false);
            this.grpBaseInfo.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.GroupBox grpBaseInfo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblPwdAgain;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblNickName;
        private System.Windows.Forms.Label lblBloodType;
        private System.Windows.Forms.Label lblStar;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button bntCancel;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.TextBox txtPwdAgain;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtNickName;
        private System.Windows.Forms.ComboBox cboxBoolType;
        private System.Windows.Forms.ComboBox cboxStar;
        private System.Windows.Forms.TextBox txtName;
    }
}