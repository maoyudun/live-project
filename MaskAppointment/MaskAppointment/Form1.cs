using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace MaskAppointment
{

    public partial class Form1 : Form
    {
        public Boolean isTime;//是否在预约时间内
        public int listnumber = 0;//用来记录是第几次预约
        public Form1()
        {
            isTime = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer1_Tick(sender, e);
        }
        public static string GetNetDateTime()
        {
            //获取网络时间
            WebRequest request = null;
            WebResponse response = null;
            WebHeaderCollection headerCollection = null;
            string datetime = string.Empty;
            try
            {
                request = WebRequest.Create("https://www.baidu.com");
                request.Timeout = 3000;
                request.Credentials = CredentialCache.DefaultCredentials;
                response = request.GetResponse();
                headerCollection = response.Headers;
                foreach (var h in headerCollection.AllKeys)
                {
                    if (h == "Date")
                    {
                        datetime = headerCollection[h];
                    }
                }
                return datetime;
            }
            catch (Exception) { return datetime; }
            finally
            {
                if (request != null)
                { request.Abort(); }
                if (response != null)
                { response.Close(); }
                if (headerCollection != null)
                { headerCollection.Clear(); }
            }
        }

        private void TestStart_Click(object sender, EventArgs e)
        {
            if(isTime == false)
            {
                isTime = true;
                AboveTitle.Text = "预约已开放";
                listnumber++;
            }
        }

        private void TestEnd_Click(object sender, EventArgs e)
        {
            if(isTime == true)
            {
                isTime = false;
                SetRewardPerson(listnumber);
                AboveTitle.Text = "当前不在预约时间内";
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            //计时器,实现预约时间定时开放
            timer1.Enabled = false;//先禁用,用按钮测试
            timer1.Interval = 1000;//1000ms执行间隔
            string netTime = GetNetDateTime();//获取网络时间,需要转换
            DateTime netDateTime = Convert.ToDateTime(netTime);
            DateTime startTime = new DateTime(2020, 3, 15, 13, 20, 50);//设置开始时间 
            DateTime endTime = new DateTime(2020, 3, 15, 14, 22, 20);//设置结束时间
            int compNum1 = DateTime.Compare(startTime, netDateTime);
            int compNum2 = DateTime.Compare(endTime, netDateTime);
            if (compNum1 <= 0 && compNum2 >= 0)
            {
                isTime = true;
                AboveTitle.Text = "预约已开放";
            }
            else
            {
                isTime = false;
                AboveTitle.Text = "当前不在预约时间内";
            }

        }
        public static void SetRewardPerson(int listnumber)
        {
            int mask = 0;
            int listNumber = listnumber;
            String date = "";
            String deadline = "";
            String connectStr0 = "server=127.0.0.1;port=3306;user=root;password=123456;database=mask";
            MySqlConnection conn0 = new MySqlConnection(connectStr0);
            try
            {
                conn0.Open();
                Console.WriteLine("数据已打开1");
                string sql = "select * from appointment where listNumber = " + listNumber;
                MySqlCommand cmd = new MySqlCommand(sql, conn0);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                mask += reader.GetInt32("mask");
                date += reader.GetString("closetime");
                DateTime dateTime = Convert.ToDateTime(date);
                dateTime.AddDays(3);
                deadline = dateTime.ToShortDateString();
                Console.WriteLine(deadline);
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn0.Close();
            }

            int people = 0;
            int maxpeople = 0;
            int mask2 = 0;
            String connectStr = "server=127.0.0.1;port=3306;user=root;password=123456;database=mask";
            MySqlConnection conn = new MySqlConnection(connectStr);
            String[] name = new String[100];
            String[] ID = new String[100];
            String[] phone = new String[100];
            String[] registerID = new String[100];
            int[] maskNumber = new int[100];
            try
            {
                conn.Open();
                Console.WriteLine("数据已打开2");
                string sql = "select * from Register where listNumber = " + listNumber;
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                for (int i = 0; reader.Read(); ++i)
                {
                    name[i] = reader.GetString("name");
                    ID[i] = reader.GetString("ID");
                    phone[i] = reader.GetString("phone");
                    maskNumber[i] = reader.GetInt32("maskNumber");
                    registerID[i] = reader.GetString("registerID");
                    people++;
                }
                for (int i = 0; i < people; ++i)
                {
                    mask2 += maskNumber[i];
                    if (mask >= mask2) maxpeople++;
                    else break;
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            String connectStr2 = "server=127.0.0.1;port=3306;user=root;password=123456;database=mask";
            MySqlConnection conn2 = new MySqlConnection(connectStr2);
            try
            {
                conn2.Open();
                Console.WriteLine("数据已打开3");
                string sql = "";
                for (int i = 0; i < maxpeople; ++i)
                {
                    sql += "insert into list(listNumber,name,ID,phone,maskNumber,registerID,Date,deadline) values(" + listNumber + ",'" + name[i] + "','" + ID[i] + "','" + phone[i] + "'," + maskNumber[i] + ",'" + registerID[i] + "','" + date + "','" + deadline + "');";
                }
                MySqlCommand cmd = new MySqlCommand(sql, conn2);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn2.Close();
            }
        }

        private void 管理员登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4Login form4Login = new Form4Login();
            form4Login.Show();
            this.Hide();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            register();
        }
        public void register()
        {
            //负责进行登记
            string strSQLconn = "server=localhost;port=3306;database=mask;user=root;password=123456";
            MySqlConnection conn;
            conn = new MySqlConnection(strSQLconn);
            try
            {
                conn.Open();

                string name = nameInput.Text;
                string ID = IdInput.Text;
                string Phone = TelInput.Text;
                String Mask = OrderNumber.Value.ToString();
                int mask = Convert.ToInt32(Mask);
                Random rd = new Random();
                Int32 registerid = (Int16)(rd.NextDouble() * 1000000);
                if(registerid < 0)
                {
                    registerid = -registerid;
                }
                string registerID = Convert.ToString(registerid);
                isAllowed test1 = new isAllowed();
                if (test1.IfAppointmented(Phone, ID) == false || isTime == false)
                {
                    MessageBox.Show("无法预约！","提示");
                }
                else
                {

                    string strSQL = "INSERT INTO register(name,ID,phone,maskNumber,registerID,listNumber) VALUES('" + name + "','" + ID + "','" + Phone + "','" + mask + "','" + registerID + "','" + listnumber + "')";
                    MySqlCommand registerCmd = new MySqlCommand(strSQL, conn);
                    registerCmd.ExecuteNonQuery();
                    MessageBox.Show("预约成功!预约编号为:"+ registerID ,"提示");

                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button4Query_Click(object sender, EventArgs e)
        {
            QueryMask queryMask = new QueryMask();
            queryMask.Show();
        }
    }
}
