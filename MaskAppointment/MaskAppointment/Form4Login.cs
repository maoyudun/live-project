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
    public partial class Form4Login : Form
    {
        public Form4Login()
        {
            InitializeComponent();
        }

        private void button4Pass_Click(object sender, EventArgs e)
        {
            if (textBox4Pass.Text.Equals("123456"))
            {
                Form4Admin form4Admin = new Form4Admin();
                form4Admin.Show();
                this.Hide();
            }
            else
            {
                textBox4Pass.Text = "";
                MessageBox.Show("密码错误，请重新输入！", "登录提示");
            }
        }
    }
}
