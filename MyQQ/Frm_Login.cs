using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyQQ
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }
        DataOperator dataOper = new DataOperator();

        //登录提示
        public bool ValidateInput()
        {
            if (txtID.Text.Trim()=="")
            {
                MessageBox.Show("请输入登录账号", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtID.Focus();
                return false;
            }
            else if(int.Parse(txtID.Text.Trim())>65535)
            {
                MessageBox.Show("请输入正确的登录账号", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtID.Focus();
                return false;
            }
            else if(txtID.Text.Length>5&&txtPwd.Text.Trim()=="")
            {
                MessageBox.Show("请输入密码", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPwd.Focus();
                return false;
            }
            return true;
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            
        }
        //文本框改变事件
        private void txtID_TextChanged(object sender, EventArgs e)
        {
            ValidateInput();
            string sql = "select Pwd,Remember,AutoLogin from tb_User where ID=" + int.Parse(txtID.Text.Trim())+"";
            DataSet ds = dataOper.GetDataSet(sql);
            if(ds.Tables[0].Rows.Count>0)//如果获得数据
            {
                if(Convert.ToInt32(ds.Tables[0].Rows[0][1])==1)//判断是否记住密码
                {
                    cboxRemember.Checked = true;//记住密码框选中
                    txtPwd.Text = ds.Tables[0].Rows[0][0].ToString();//自动输入密码
                    if(Convert.ToInt32(ds.Tables[0].Rows[0][2])==1)
                    {
                        cboxAutoLogin.Checked = true;
                        pboxLogin_Click(sender, e);
                    }

                }
            }
        }

        //账号输入框键盘事件
        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || (e.KeyChar == '\r') || (e.KeyChar == '\b'))
                e.Handled = false;
            else
                e.Handled = true;
        }

        //登录按扭点击事件
        private void pboxLogin_Click(object sender, EventArgs e)
        {
            if (ValidateInput())//如果能够正常登录
            {
                string sql = "select count(*) from tb_User where ID=" + int.Parse(txtID.Text.Trim()) + "and Pwd='" + txtPwd.Text.Trim() +"'";
                int num = dataOper.ExecSQL(sql);//返回第一行第一列的查询结果
                if(num==1)
                {
                    PublicClass.loginID = int.Parse(txtID.Text.Trim());//设置登录的用户号码
                    //如果"记住密码"复选框选中
                    if(cboxRemember.Checked)
                    {
                        dataOper.ExecSQLResult("update tb_User set Remember=1 where ID=" + int.Parse(txtID.Text.Trim()));
                        if(cboxAutoLogin.Checked)//立即登录复选框选中
                        {
                            dataOper.ExecSQLResult("update tb_User set AutoLogin=1 where ID=" + int.Parse(txtID.Text.Trim()));
                        }
                    }
                    else
                    {
                        dataOper.ExecSQLResult("update tb_User set Remember=0 where ID=" + int.Parse(txtID.Text.Trim()));
                        dataOper.ExecSQLResult("update tb_User set AutoLogin=0 where ID=" + int.Parse(txtID.Text.Trim()));
                    }
                    dataOper.ExecSQLResult("update tb_User set Flag=1 where ID=" + int.Parse(txtID.Text.Trim()));
                    Frm_Main frmMain = new Frm_Main();
                    frmMain.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("输入的用户名或密码有误！", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        //密码输入框键盘事件
        private void txtPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')//回车键切换输入焦点
                pboxLogin_Click(sender, e);//切换至登录按扭
        }
        //复选框点击事件
        private void cboxRemember_CheckedChanged(object sender, EventArgs e)
        {
            if (!cboxRemember.Checked)//如果记住密码框没有选中
                cboxAutoLogin.Checked = false;//自动登录也不选中
        }

        private void linklblReg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_Register frmRegister = new Frm_Register();
            frmRegister.Show();
        }

        private void pboxMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;//设置窗体最小化
        }

        private void pboxClose_Click(object sender, EventArgs e)
        {
            Application.ExitThread();//设置退出应用程序
        }
    }
}
