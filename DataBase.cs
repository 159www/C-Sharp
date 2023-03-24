using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace newonenetapp
{
    class DataBase
    {
        private static string connectionparemeter = "server=127.0.0.1;port=3306;user=root;password=123456;database=onenet;SslMode = none;Charset=utf8;allowPublicKeyRetrieval=true";//连接数据库配置
        private MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
        private int flag = 0;
        private int DeviceId=0;
        private string cmd = null;
        /*
        * 连接数据库并返回mysqlconnection连接对象
        * 
        * 
        */
        public static MySqlConnection getconn()
        {
            MySqlConnection conn = new MySqlConnection(connectionparemeter);


            return conn;

        }
        /*
         * 
         * 打开数据库连接
         * 
         * 
         */

        public static void connection_open(MySqlConnection conn)
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();

            }
            else
            {
                //  conn.Close();
                //  conn.Open();

            }


        }
        /*
         * 
         * 关闭数据库连接
         * 
         */

        public static void conection_close(MySqlConnection conn)
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
            else
            {
                // conn.Open();
                // conn.Close();
            }


        }
        /*
         将设备数据插入设备表device
         */
        public int insert_device(MySqlConnection conn,int deviceid, string devicename, string devicestatus, string deviceprotocol,string devicecreattime)
        {
            string insert_sql = "insert into device values(" + deviceid + ",'" + devicename + "','" + devicestatus + "','" + deviceprotocol + "','" + devicecreattime + "')";
            try
            {
                connection_open(conn);
                MySqlCommand cmd = new MySqlCommand(insert_sql, conn);
                flag = cmd.ExecuteNonQuery();


            }
            catch
            {
            }
            finally
            {
                conection_close(conn);
            }

            return flag;
        }
        /*
         查询设备表中的设备id并返回存放各个设备id的数组
         */
        public string[] get_device_id(MySqlConnection conn,string table,int length)
        {
            string []id = new string[length];
            int index = 0;
            string query_sql = string.Format("select * from {0}", table);
            try
            {
                connection_open(conn);
                MySqlCommand cmd = new MySqlCommand(query_sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read()==true)
                {
                   
                    id[index] = reader.GetInt32(0).ToString();
                    index++;

                }
            }
            catch
            {

            }
            finally
            {
                conection_close(conn);
            }

            return id;
        }
        /*获取设备数据流个数*/
        public int GetDataStremNumbersByDeviceID(MySqlConnection conn,string table,int deviceid)
        {
            string query_sql = string.Format("select * from {0} where deviceid={1}", table, deviceid);
            try
            {
                connection_open(conn);
                MySqlCommand cmd = new MySqlCommand(query_sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    flag++;

                }

            }
            catch
            {

            }
            finally
            {
                conection_close(conn);
            }


            return flag;

        }
        /*
         查询设备的数据流以字符串数组的形式返回
         */
        public string[] GetDataStreamByDeviceId(MySqlConnection conn,string table,int deviceid,int length)
        {
            string query_sql = string.Format("select * from {0} where deviceid={1}", table, deviceid);
            string[] DataStream = new string[length];
            try
            {
                connection_open(conn);
                MySqlCommand cmd = new MySqlCommand(query_sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                int index = 0;
                while(reader.Read())
                {
                    DataStream[index] = reader.GetString(1);
                    index++;

                }
                

            }
            catch
            {

            }
            finally
            {
                conection_close(conn);
            }

            return DataStream;


        }
        /*通过设备命查询设备id并返回设备id*/
        public int GetDeviceIdByDeviceName(MySqlConnection conn,string table,string devicename)
        {
            string query_sql = string.Format("select * from {0} where devicename='{1}'", table, devicename);
            try
            {
                connection_open(conn);
                MySqlCommand cmd = new MySqlCommand(query_sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    DeviceId = reader.GetInt32(0);

                }
            }
            catch
            {

            }
            finally
            {
                conection_close(conn);
            }

            return DeviceId;
        }

        /*查询设备表中的*/
        public string[] GetDeviceName(MySqlConnection conn,string table,int length)
        {

            string[] name = new string[length];
            int index = 0;
            string query_sql = string.Format("select * from {0}", table);
            try
            {
                connection_open(conn);
                MySqlCommand cmd = new MySqlCommand(query_sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read() == true)
                {

                    name[index] = reader.GetString(1);
                    index++;

                }
            }
            catch
            {

            }
            finally
            {
                conection_close(conn);
            }

            return name;

        }
        /*
         查询命令表中设备对应的指令并返回指令数组 
         */

        public string[] GetDeviceCMD(MySqlConnection conn,string table,string devicename,int len)
        {
            string[] CMD = new string[len];
            string querry_sql = string.Format("select * from {0} where devicename='{1}'", table, devicename);
            int index = 0;
            try
            {
                connection_open(conn);
                MySqlCommand cmd = new MySqlCommand(querry_sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    CMD[index] = reader.GetString(1);
                    index++;

                }

            }
            catch
            {

            }
            finally
            {
                conection_close(conn);
            }

            return CMD;


        }
        /*
         查询设备各个指令对应的命令字符串
         */
        public string DiscoveryDeviceCmd(MySqlConnection conn,string table,string devicename,string cmdname)
        {
            string query_sql = string.Format(" select * from {0} where devicename='{1}' and cmdname='{2}'", table, devicename, cmdname);
            try
            {
                connection_open(conn);
                MySqlCommand cmd = new MySqlCommand(query_sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if(reader.Read())
                {

                    this.cmd = reader.GetString(2);
                }


            }
            catch
            {

            }
            finally
            {
                conection_close(conn);
            }

            return this.cmd;
        }


        /*
         查询表device中有无记录
         */
        public int query_device(MySqlConnection conn,string table)
        {
            string query_sql = "select * from "+table+" ";
            try
            {
                connection_open(conn);
                MySqlCommand cmd = new MySqlCommand(query_sql, conn);
                MySqlDataReader mySqlDataReader = cmd.ExecuteReader();
                flag = 0;
                while(mySqlDataReader.Read()==true)
                {
                    flag++;
                }
               

            }
            catch
            {

            }
            finally
            {
                conection_close(conn);
            }

            return flag;
        }
        /*
         删除表device中的所有记录
         */
        public int delete_device(MySqlConnection conn,string table)
        {
            string delete_sql = "delete from "+table+"";
            try
            {
                connection_open(conn);
                MySqlCommand cmd = new MySqlCommand(delete_sql, conn);
                flag = cmd.ExecuteNonQuery();

            }
            catch
            {

            }
            finally
            {
                conection_close(conn);
            }

            return flag;

        }
        /*
         将设备表中的记录加载到MysqlDataAdaptor对象中并返回
         */
        public MySqlDataAdapter get_adapter_from_devie(MySqlConnection conn,string table)
        {
            string query_sql = string.Format("select * from {0}", table);
            try
            {
                connection_open(conn);
                MySqlCommand cmd = new MySqlCommand(query_sql, conn);
                mySqlDataAdapter.SelectCommand = cmd;

            }
            catch
            {

            }
            finally
            {
                conection_close(conn);
            }

            return mySqlDataAdapter;

        }
    
        /*
         * 
         将登录记录插入到登录记录表loginhistory

         */
        public int insert_loginhistory(MySqlConnection conn,int deviceid,string last_login)
        {
            string insert_sql = "insert into loginhistory values(" + deviceid + ",'" + last_login + "')";
            try
            {
                connection_open(conn);
                MySqlCommand cmd = new  MySqlCommand(insert_sql, conn);
                flag = cmd.ExecuteNonQuery();

            }
            catch
            {

            }
            finally
            {
                conection_close(conn);
            }

            return flag;

        }
        /*
         将数据流信息插入数据流表datastream
         */
        public int insert_datastream(MySqlConnection conn,int deviceid,string datastremid,string unit,string unitsymbol)
        {
            string insert_sql = "insert into datastream values("+deviceid+",'"+datastremid+"','"+unit+"','"+unitsymbol+"')";
            try
            {
                connection_open(conn);
                MySqlCommand cmd = new MySqlCommand(insert_sql, conn);
                flag = cmd.ExecuteNonQuery();

            }
            catch
            {

            }
            finally
            {
                conection_close(conn);
            }

            return flag;

        }
        /*
         查询登录记录中有无已存在的相同的记录
         */
        public int query_loginhistory(MySqlConnection conn,string table,string last_login_time)
        {
            string query_sql = string.Format("selet * from {0} where logintime={1}", table, last_login_time);
            try
            {
                connection_open(conn);
                   MySqlCommand cmd = new MySqlCommand(query_sql, conn);
                   flag = cmd.ExecuteNonQuery();


            }
            catch
            {

            }
            finally
            {
                conection_close(conn);
            }

            return flag;
        }
        /*
         将数据插入历史数据表datahistory
         */
        public int Insert_DataHistory(MySqlConnection conn,string table,string datastream,string value,string time)
        {
            string insert_sql = string.Format("insert into {0} values('" + datastream + "','" + value + "','" + time + "')",table);
            try
            {
                connection_open(conn);
                MySqlCommand cmd = new MySqlCommand(insert_sql, conn);
                flag = cmd.ExecuteNonQuery();

            }
            catch
            {

            }
            finally
            {
                conection_close(conn);
            }
            return flag;
        }
        /*
         查询登录记录表各条记录的登录时间并以字符串数组的形式返回
         */
        public string[] GetLoginTimeFromLoginHistory(MySqlConnection conn,string table,int length)
        {
            string query_sql = string.Format(" select * from {0}", table);
            string[] LoginTime = new string[length];
            int index = 0;
            try
            {
                connection_open(conn);
                MySqlCommand cmd = new MySqlCommand(query_sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    LoginTime[index] = reader.GetString(1);
                    index++;

                }

            }
            catch
            {

            }
            finally
            {
                conection_close(conn);

            }
            return LoginTime;
        }

        /*
         添加命令
         */
        public int AddCmd(MySqlConnection conn,string devicename,string cmdname,string cmd1)
        {
            string insert_sql = "insert into cmd values('" + devicename + "','" + cmdname + "','" + cmd1 + "')";
            try
            {
                connection_open(conn);
                MySqlCommand cmd = new MySqlCommand(insert_sql, conn);
                flag = cmd.ExecuteNonQuery();
            }
            catch
            {

            }
            finally
            {
                conection_close(conn);

            }

            return flag;
        }

    }
}
