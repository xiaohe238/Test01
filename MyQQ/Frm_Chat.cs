using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MyQQ
{
    /// <summary>
    /// 聊天窗口
    /// 需要显示朋友账号 昵称 头像
    /// </summary>
    public partial class Frm_Chat : Form
    {
        public int friendID = 0;
        public string nickName;
        public int headID;
        DataOperator dataOper = new DataOperator();
        public Frm_Chat()
        {
            InitializeComponent();
        }

        private void Frm_Chat_Load(object sender, EventArgs e)
        {
            this.Text = "与\"" + nickName + "\"聊天中";//设置窗体标题
            pboxHead.Image = imglistHead.Images[headID];//获取好友头像
            lblFriend.Text = string.Format("{0}({1})", nickName, friendID);//设置好友名称
            rtxtMessage.ScrollToCaret();
        }


        private void pboxClose_Click(object sender, EventArgs e)
        {
            this.Close();//关闭窗口
        }

        /// <summary>
        /// 将显示出来的消息设置为已读
        /// </summary>
        /// <param name="messageID"></param>
        private void SetMessage(string messageID)
        {
            string[] messageIDs = messageID.Split('_');//分割出每个消息的ID
            string sql = "update tb_Message set MessageState=1 where ID=";//定义更新sql语句
            foreach ( string id in messageIDs)
            {
                if (id!="")
                {
                    sql += id;
                    int result = dataOper.ExecSQLResult(sql);//执行数据表更新操作
                }
            }
        }

        /// <summary>
        /// 读取所有的未读消息
        /// </summary>
        private void ShowMessage()
        {
            string messageID = "";//消息ID组成的字符串
            string message;//消息内容
            string messageTime;//消息发送时间
            //读取消息的SQL语句
            string sql = "select ID,Message,MessageTime from tb_Message where FromUserID=" + friendID + "and ToUserID=" + PublicClass.loginID + "and MessageTypeID=1 and MessageState=0";
            SqlDataReader datareader = dataOper.GetDataReader(sql);
            //循环将消息添加到窗体上 
            while (datareader.Read())
            {
                messageID += datareader["ID"] + "_";//消息ID
                message = datareader["Message"].ToString();//消息
                //消息发送的时间
                messageTime = Convert.ToDateTime(datareader["MessageTime"]).ToString();
                //设置消息显示格式
                rtxtMessage.Text += "\n" + nickName + " " + messageTime + "\n" + message + "";
            }
            DataOperator.connection.Close();
            if (messageID.Length>1)//判断是否存在消息
            {
                messageID.Remove(messageID.Length - 1);//去掉最后的连接符
                SetMessage(messageID);//将显示的消息设置为已读
            }
        }

    }
}
