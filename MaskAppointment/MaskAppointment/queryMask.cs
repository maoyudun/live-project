using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaskAppointment
{
    public partial class QueryMask : Form
    {
        public QueryMask()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string strSQLconn = "server=localhost;port=3306;database=mask;user=root;password=123456";
            MySqlConnection conn;
            conn = new MySqlConnection(strSQLconn);
            conn.Open();

            string sql = "select * from list where registerID='" + this.numInput.Text + "'";
            MySqlCommand command = new MySqlCommand(sql, conn);
            int i = Convert.ToInt32(command.ExecuteScalar());
            command.Dispose();
            conn.Close();
            if (i > 0)
            {
                MySqlConnection conn1;
                conn1 = new MySqlConnection(strSQLconn);
                conn1.Open();
                MySqlCommand command1 = new MySqlCommand(sql, conn1);
                MySqlDataReader reader = command1.ExecuteReader();
                reader.Read();
                MessageBox.Show("已中签！\r\n"+"姓名:"+reader[1]+"\r\n身份证号:"+reader[2]+"\r\n电话号:"+ reader[3]+ "\r\n购买次数:"+reader[4]
                    +"\r\n预约编号:" + reader[5] + "\r\n起始日期:" + reader[6] + "\r\n有效日期至:" + reader[7]);
                command1.Dispose();
                conn1.Close();
            }
            else
            {
                MessageBox.Show("未中签！");
            }
            
        }
    }
}
