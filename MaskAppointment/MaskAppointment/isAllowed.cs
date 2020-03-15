using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace MaskAppointment
{
    class test
    {
        /*
         * TODO:判断是否能预约
         * PhoneNumber:电话号码 
         * IdNumber:身份证号
         */
        public Boolean ifAppointmented(int PhoneNumber, int IdNumber)
        {
            Boolean isPermmited = true;//是否允许预约
            /*
             * 获取数据库连接
             * 这里的数据库连接信息需要改成本地连接信息，或者直接获取本地连接
             */
            String connetStr = "server=127.0.0.1;port=3306;user=root;password=123456; database=mask;";
            MySqlConnection conn = new MySqlConnection(connetStr);
            MySqlDataReader reader;
            try
            {
                conn.Open();
                int CurrentTime = 0;//当前开放的预约是第几次
                //看看这是第几次预约
                String appointment = "select listNumber from Appiontment";
                MySqlCommand AppointmentCmd = new MySqlCommand(appointment, conn);
                reader = AppointmentCmd.ExecuteReader();
                while (reader.Read())
                {
                    //获取最新的一条记录的值
                    CurrentTime = reader.GetInt32("listNumber");
                    break;//拿完就走
                }

                //获取预约记录，判断这次是否已经预约
                String register = "select ID,listNumber,phone from register";
                MySqlCommand RegisterCmd = new MySqlCommand(register, conn);
                reader = RegisterCmd.ExecuteReader();
                //遍历所有预约条目
                while (reader.Read())
                {
                    //是否是这次预约的记录
                    if (reader.GetInt32("listNumber") == CurrentTime)
                    {
                        //身份证号或电话号码匹配
                        if (reader.GetInt32("ID") == IdNumber || reader.GetInt32("phone") == PhoneNumber)
                        {
                            isPermmited = false;//这次的预约记录存在该用户的信息，这次已经预约过，不允许再预约
                            return isPermmited;
                        }
                    }
                    else break;//这次预约的记录遍历完就退出
                }
                //遍历所有中签条目,判断是否三天之内(鲨)中(了)过(你)签
                String list = "select ID,listNumber,phone from register";
                MySqlCommand ListCmd = new MySqlCommand(register, conn);
                reader = ListCmd.ExecuteReader();
                while (reader.Read())
                {
                    if ((CurrentTime - reader.GetInt32("listNumber")) < 3)
                    {
                        if (reader.GetInt32("ID") == IdNumber || reader.GetInt32("phone") == PhoneNumber)
                        {
                            isPermmited = false;
                            return isPermmited;
                        }
                    }
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
            return isPermmited;
        }
    }
}
