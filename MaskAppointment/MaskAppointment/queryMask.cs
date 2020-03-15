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
            MySqlDataReader reader = command.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                i++;
            }
            command.Dispose();
            if (i != 0)
            {
                MessageBox.Show("已中签！");
            }
            else
            {
                MessageBox.Show("未中签！");
            }
            conn.Close();
        }
    }
}
