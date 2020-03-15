using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MaskAppointment
{
    public partial class Form1 : Form
    {
        public Boolean isTime;//是否在预约时间内
        int listnumber = 0;
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
            isTime = true;
            AboveTitle.Text = "预约已开放";
            listnumber++;
        }

        private void TestEnd_Click(object sender, EventArgs e)
        {
            isTime = false;
            AboveTitle.Text = "当前不在预约时间内";
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            //计时器,实现预约时间定时开放
            timer1.Enabled = false;//先禁用,用按钮测试
            timer1.Interval = 1000;//1000ms执行间隔
            string netTime = GetNetDateTime();//获取网络时间,需要转换
            DateTime netDateTime = Convert.ToDateTime(netTime);
            DateTime startTime = new DateTime(2020, 3, 15, 13, 20, 50);//设置开始时间 
            DateTime endTime = new DateTime(2020, 3, 15, 14, 22,20);//设置结束时间
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
            public void register()
            {
            //负责进行登记
            string strSQLconn = "server=localhost;port=3306;database=mask;user=root;password=123456";
            MySqlConnection conn;
            conn = new MySqlConnection(strSQLconn);
            conn.Open();

            string name = nameInput.Text;
            string ID = IdInput.Text;
            string Phone = TelInput.Text;
            int mask = OrderNumber.DecimalPlaces;
            Random rd = new Random();
            Int32 registerid = (Int16)(rd.NextDouble() * 1000000);
            string registerID = Convert.ToString(registerid);
            isAllowed test1 = new isAllowed();
            if (test1.IfAppointmented(Phone, ID) == false)
            {
                MessageBox.Show("无法预约！");
            }
            else
            {

                MessageBox.Show("预约成功!");

                string strSQL = "INSERT INTO info(name,ID,phone,maskNumber,registerID,listNumber) VALUES('" + name + "','" + ID + "','" + Phone + "','" + mask + "','" + registerID + "','" + listnumber + ")";
                MySqlCommand registerCmd= new MySqlCommand(strSQL, conn);

             }
            }

        private void Submit_Click(object sender, EventArgs e)
        {
            register();
        }
    }
}
