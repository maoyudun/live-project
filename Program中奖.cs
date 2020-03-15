using System;
using MySql.Data.MySqlClient;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int mask = 0;
            int listNumber = 1; //将你要进行抽奖的第几次预约放在这
            String connectStr0 = "server=127.0.0.1;port=3306;user=root;password=123456;database=mask";
            MySqlConnection conn0 = new MySqlConnection(connectStr0);
            try
            {
                conn0.Open();
                Console.WriteLine("数据已打开1");
                string sql = "select * from appiontment where listNumber ="+listNumber;
                MySqlCommand cmd = new MySqlCommand(sql, conn0);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                mask += reader.GetInt32("mask");   
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
            int mask2=0;
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
                string sql = "select * from Register where listNumber = "+listNumber;
                MySqlCommand cmd = new MySqlCommand(sql,conn);
                MySqlDataReader reader = cmd.ExecuteReader();
               for(int i=0; reader.Read();++i)
                {
                    name[i] = reader.GetString("name");
                    ID[i] = reader.GetString("ID");
                    phone[i] = reader.GetString("phone");
                    maskNumber[i] = reader.GetInt32("maskNumber");
                    registerID[i] = reader.GetString("registerID");
                    people++;
                }
               for(int i=0;i<people;++i)
                {
                    mask2 += maskNumber[i];
                    if (mask >= mask2) maxpeople++;
                    else break;
                }
            }
            catch(MySqlException ex)
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
                for (int i = 0; i<maxpeople; ++i)
                {
                    sql += "insert into list(listNumber,name,ID,phone,maskNumber,registerID) values(" + listNumber + ",'"+name[i]+"','"+ID[i]+"','"+phone[i]+"',"+maskNumber[i]+",'"+registerID[i]+"');";
                }
                MySqlCommand cmd = new MySqlCommand(sql,conn2);
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
    }
}
