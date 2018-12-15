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
using System.Media;

namespace MyQQ
{
    public partial class Frm_Main : Form
    {
        int fromUserID;//发送消息者
        int friendHeadID;//发消息好友的头像ID
        int messageImageIndex = 0;//工具栏中的消息图标的索引
        public static string nickName = "";//自己的昵称
        public static string strFlag = "[离线]";
        DataOperator dataOper = new DataOperator();//创建数据操作类的对象
        public Frm_Main()
        {
            InitializeComponent();
        }
        //用来判断某个用户是否在表中
        private bool HasShowUser(int ID)
        {
            bool find = false;
            for (int i = 0; i < 2; i++)
            {
                //循环每个组里的好友，寻找发消息的人是否在列表中
                for (int j = 0; j < lvFruend.Groups[i].Items.Count; j++)
                {
                    if (Convert.ToInt32(lvFruend.Groups[i].Items[j].Name) == ID)
                        find = true;
                }
            }
            return find;
        }
        //显示陌生人列表
        private void UpdateStranger(int ID)
        {
            lvFruend.Items.Clear();//清空列表
            string sql = "select NickName,HeadID from tb_User where ID=" + ID;
            SqlDataReader dataReader = dataOper.GetDataReader(sql);//查询昵称和头像ID
            int i = lvFruend.Items.Count;//记录添加到LvFruend中的项索引
            //循环添加陌生人
            while(dataReader.Read())
            {
                string strTemp = dataReader["NickName"].ToString();//保存昵称
                string strName = strTemp;//处理昵称
                if (strTemp.Length < 9)
                    strName = strTemp.PadLeft(9, ' ');//如果昵称小于9个字，就向右对齐
                else
                    //如果大于9个字，就取前2个字省略于下的字并向右对齐
                    strName = (strTemp.Substring(0, 2) + "...").PadLeft(9, ' ');
                //添加发送消息者，处理后的昵称以及头像ID
                lvFruend.Items.Add(fromUserID.ToString(), strName, (int)dataReader["HeadID"]);
                lvFruend.Items[i].Group = lvFruend.Groups[1];//将控件中的第i项设为第二组
                i++;
            }
            dataReader.Close();
            DataOperator.connection.Close();
        }

        //个人信息
        public void ShowInfo()
        {
            int headID = 0;
            //获取当前用户的昵称、头像
            string sql = "select NickName,HeadID,Sign from tb_User where ID=" + PublicClass.loginID + "";
            SqlDataReader dataReader = dataOper.GetDataReader(sql);
            if (dataReader.Read())
            {
                if (!(dataReader["NickName"] is DBNull))//判断NickName不为空
                {
                    nickName = dataReader["NickName"].ToString();//记录自己的昵称
                }
                headID = Convert.ToInt32(dataReader["HeadID"]);//记录自己的头像ID
                txtSign.Text = dataReader["Sign"].ToString();
            }
            dataReader.Close();//关闭读取器
            DataOperator.connection.Close();//关闭数据库连接
            this.Text = PublicClass.loginID.ToString();//设置窗体标题为当前用户账号
            pboxHead.Image = imglisHedad.Images[headID];//显示用户图像
            lblName.Text = nickName + "(" + PublicClass.loginID + ")";//显示昵称及账号
        }
        //当前登录用户的好友列表信息方法
        private void ShowFriendList()
        {
            lvFruend.Items.Clear();
            //定义查打好友的SQL语句
            string sql = "select FriendID,NickName,HeadID,Flag from tb_User,tb_Friend where tb_Friend.HostID=" + PublicClass.loginID + "and tb_User.ID=tb_Friend.FriendID";
            SqlDataReader dataReader = dataOper.GetDataReader(sql);//执行查询
            int i = lvFruend.Items.Count;//记录添加到ListView中的项索引
            while(dataReader .Read ())
            {
                if (dataReader["Flag"].ToString() == "0")
                    strFlag = "[离线]";
                else
                    strFlag = "[在线]";
                string strTemp = dataReader["NickName"].ToString();//记录好友昵称
                //对好友昵称进行处理
                string strFriendName = strTemp;
                if (strTemp.Length < 9)
                    strFriendName = strTemp.PadLeft(9, ' ');//向右对齐
                else
                    strFriendName = (strTemp.Substring(0, 2) + "...").PadLeft(9, ' ');//取前两个字符加省略号然后右对齐
                //向ListView中添加项，Name:好友ID，值：昵称，要显示的头像
                lvFruend.Items.Add(dataReader["FriendID"].ToString(), strFriendName + strFlag, (int)dataReader["HeadID"]);
                lvFruend.Items[i].Group = lvFruend.Groups[0];
                i++;
            }
            dataReader.Close();
            DataOperator.connection.Close();
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            tsbtnMessageReading.Image = imglistMessage.Images[0];//工具栏的消息图标
            ShowInfo();//显示个人信息
            ShowFriendList();//显示好友列表
        }
        //个人信息窗体
        private void tsbtnlnfo_Click(object sender, EventArgs e)
        {
            Frm_EditInfo frmInfo = new Frm_EditInfo();
            frmInfo.Show();
        }

        //查找好友窗体
        private void tsbtnSearchFriend_Click(object sender, EventArgs e)
        {
            Frm_AddFriend frmAddFriend= new Frm_AddFriend();
            frmAddFriend.Show();

        }
        //刷新列表窗体
        private void tsbtnUpdateFriendList_Click(object sender, EventArgs e)
        {
            ShowFriendList();
        }

        private void tsbtnMessageReading_Click(object sender, EventArgs e)
        {
            tmAddFriend.Stop();//停止消息提醒定时器
            messageImageIndex = 0;//头像恢复正常
            //显示正常的系统消息提醒图标
            tsbtnMessageReading.Image = imglistMessage.Images[messageImageIndex];
            Frm_Remind frmRemind = new Frm_Remind();
            frmRemind.Show();
        }
        //退出程序
        private void tsbtnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确实要退出吗？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Application.ExitThread();
        }

        //聊天窗口点击事件
        Frm_Chat frmChat;//聊天窗体对象
        private void lvFruend_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(lvFruend.SelectedItems.Count >0)//如果当前被选中项的集合个数大于0，判断是否有选中项
            {
                if(frmChat ==null)//判断聊天窗口对象是否为空
                {
                    frmChat = new Frm_Chat();
                    //记录聊天的账号
                    frmChat.friendID = Convert.ToInt32(lvFruend.SelectedItems[0].Name);
                    frmChat.nickName = dataOper.GetDataSet("select NickName from tb_User where ID=" + frmChat.friendID).Tables[0].Rows[0][0].ToString();//记录昵称
                    frmChat.headID =Convert.ToInt32 (dataOper.GetDataSet("select HeadID from tb_User where ID="+frmChat.friendID).Tables[0].Rows[0][0])+1;//记录头像ID
                    frmChat.ShowDialog();
                    frmChat = null;
                }
                if(tmChat.Enabled==true )
                {
                    tmChat.Stop();
                    lvFruend.SelectedItems[0].ImageIndex = friendHeadID;
                }
            }
            
        }

        //实时获取未读消息并进行相应声音提示
        private void tmMessage_Tick(object sender, EventArgs e)
        {
            if(lvFruend.SelectedItems.Count>0)//判断好友列表中有选中项
            {
                if(lvFruend.SelectedItems[0].Group==lvFruend.Groups[0])//如果选中项属于第一组
                {
                    tsMenuDel.Visible = true;//显示删除菜单
                    tsMenuAdd.Visible = false;//隐藏添加好友菜单
                }
                //如果选中属于第2组
                else if(lvFruend.SelectedItems[0].Group==lvFruend.Groups[1])
                {
                    tsMenuDel.Visible = false;
                    tsMenuAdd.Visible = true;
                }
            }
            int messageTypeID = 1;//消息类型，1：聊天消息，2：添加好友消息
            int messageState = 1;//消息状态，1：已读，0：未读
            string sql = "select top 1 FromUserID,MessageTypeID,MessageState from tb_Message where ToUserID=" + PublicClass.loginID + "and MessageState=0";//查找未读消息对应的好友ID
            SqlDataReader dataReader = dataOper.GetDataReader(sql);
            if(dataReader.Read())
            {
                fromUserID = (int)dataReader["FromUserID"];//记录消息发送者
                messageTypeID = (int)dataReader["MessageTypeID"];//记录消息类型
                messageState = (int)dataReader["MessageState"];//记录消息状态
            }
            dataReader.Close();//关闭读取器
            DataOperator.connection.Close();//关闭数据库连接
            if(messageTypeID ==2&&messageState==0)//如果是添加好友消息并且消息未读
            {
                SoundPlayer player = new SoundPlayer("system.wav");//系统消息提示
                player.Play();//播放指定声音文件
                tmAddFriend.Start();//启动消息提醒定时器
            }
            //如果是聊天消息，启动聊天定时器，例好友头像闪烁
            else if(messageTypeID==1&&messageState==0)
            {
                sql = "select HeadID from tb_User where ID=" + fromUserID;
                friendHeadID = dataOper.ExecSQL(sql);//设置发消息好友的头像ID
                //如果好消息的人不在好友列表中，将其添加到陌生人列表中
                if(!HasShowUser(fromUserID))
                {
                    UpdateStranger(fromUserID);//显示陌生人列表
                }
                SoundPlayer player = new SoundPlayer("msg.wav");
                player.Play();
                tmChat.Start();//启动聊天定时器
            }
        }

        //消息提醒定时器事件
        private void tmAddFriend_Tick(object sender, EventArgs e)
        {
            messageImageIndex = messageImageIndex == 0 ? 1 : 0;//实时获取系统消息图像索引
            //工具栏中显示消息读取状态图像
            tsbtnMessageReading.Image = imglistMessage.Images[messageImageIndex];
        }
        //触发聊天定时器事件
        private void tmChat_Tick(object sender, EventArgs e)
        {
             //循环好友列表两个组中的每项，找到消息发送者，使其头像闪烁
             for(int i=0;i<2;i++)
            {
                for (int j = 0; j < lvFruend.Groups[i].Items.Count; j++)
                {
                    //判断是否为消息发送者
                    if(Convert.ToInt32(lvFruend.Groups[i].Items[j].Name)==fromUserID)
                    {
                        if(frmChat!=null&&frmChat.friendID!=0)
                        {
                            //直接显示头像，避免闪烁效果
                            lvFruend.SelectedItems[0].ImageIndex = friendHeadID;
                        }
                        else
                        {
                            if (lvFruend.Groups[i].Items[j].ImageIndex<100)
                            {
                                //索引为100的图片是一个空白图片，为了实现闪烁效果
                                lvFruend.Groups[i].Items[j].ImageIndex = 100;
                            }
                            else
                            {
                                //要显示的消息发送者头像索引
                                lvFruend.Groups[i].Items[j].ImageIndex = friendHeadID;
                            }
                        }
                    }
                }
            }
        }
    }
}
