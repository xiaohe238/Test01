using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyQQ
{
    public partial class Frm_Register : Form
    {
        public Frm_Register()
        {
            InitializeComponent();
        }

        //窗口加载事件
        private void Frm_Register_Load(object sender, EventArgs e)
        {
            cboxStar.SelectedIndex = cboxBoolType.SelectedIndex = 0;//获取控件索引，加载时默认
        }

        //注册按扭点击事件
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(txtNickName.Text.Trim()==""&&txtNickName.Text.Length>20)
            {
                MessageBox.Show("昵称输入有误", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNickName.Focus();
                return;
            }
            if (txtAge.Text.Trim() == "" )
            {
                MessageBox.Show("请输入年龄", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAge.Focus();
                return;
            }
            if (!rbtnMale.Checked&&!rbtnFemale.Checked)
            {
                MessageBox.Show("请选择性别", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblSex.Focus();
                return;
            }
            if (txtPwd.Text.Trim() == "" )
            {
                MessageBox.Show("请输入密码！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPwd.Focus();
                return;
            }
            if (txtPwdAgain.Text.Trim() == "")
            {
                MessageBox.Show("请输入确认密码！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPwdAgain.Focus();
                return;
            }
            if (txtPwd.Text.Trim() != txtPwdAgain.Text.Trim())
            {
                MessageBox.Show("两次输入的密码不一样！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPwdAgain.Focus();
                return;
            }
            int myQQNum = 0;
            string message;
            string sex = rbtnMale.Checked ? rbtnMale.Text : rbtnFemale.Text;//a为真则返回b,否则c
            //格式化，insert into为插入数据，select @@Identity 为获取上次插入时自动产生的ID
            string sql=string.Format("insert into tb_User(Pwd,NickName,Sex,Age,Name,Star,BloodType) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}');select @@Identity from tb_User",txtPwd.Text.Trim(),txtNickName.Text.Trim(),sex,int.Parse(txtAge.Text.Trim()),txtName.Text.Trim(),cboxStar.Text,cboxBoolType.Text);
            SqlCommand command = new SqlCommand(sql, DataOperator.connection);
            DataOperator.connection.Open();
            int result = command.ExecuteNonQuery();
            if(result==1)
            {
                sql = "select SCOPE_IDENTITY() from tb_User";
                command = new SqlCommand(sql, DataOperator.connection);
                myQQNum = Convert.ToInt32(command.ExecuteScalar());
                message = string.Format("注册成功！你的MyQQ号码是" + myQQNum);
            }
            else
            {
                message = "注册失败，请重试！";
            }
            DataOperator.connection.Close();
            MessageBox.Show(message, "注册结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void bntCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
