using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;


namespace newonenetapp
{
    class Data
    {
        private string flag = null;
        private string last_login = null;
        public static double pi = 3.1415926535897932384626;//圆周率
        public static double a = 6378245.0;//克拉索夫斯基椭球参数长半轴a
        public static double ee = 0.00669342162296594323;//克拉索夫斯基椭球参数第一偏心率平方

        public class LocateInfo
        {
            /**
             * 经度
             */
            private double longitude;
            /**
             * 维度
             */
            private double Latitude;
            /**
             * 是否在中国
             */
            private bool isChina;

            public double Longitude { get => longitude; set => longitude = value; }
            public double Latitude1 { get => Latitude; set => Latitude = value; }
            public bool IsChina { get => isChina; set => isChina = value; }
        }


        //从GPS转高德
        public static LocateInfo wgs84_To_Gcj02(double lat, double lon)
        {
            LocateInfo info = new LocateInfo();
            if (isOutOfChina(lat, lon))
            {
                info.IsChina=false;
                info.Latitude1=lat;
                info.Longitude=lon;
            }
            else
            {
                double dLat = transformLat(lon - 105.0, lat - 35.0);
                double dLon = transformLon(lon - 105.0, lat - 35.0);
                double radLat = lat / 180.0 * pi;
                double magic = Math.Sin(radLat);
                magic = 1 - ee * magic * magic;
                double sqrtMagic = Math.Sqrt(magic);
                dLat = (dLat * 180.0) / ((a * (1 - ee)) / (magic * sqrtMagic) * pi);
                dLon = (dLon * 180.0) / (a / sqrtMagic * Math.Cos(radLat) * pi);
                double mgLat = lat + dLat;
                double mgLon = lon + dLon;
                info.IsChina=true;
                info.Latitude1=mgLat;
                info.Longitude = mgLon; ;
            }
            return info;
        }

       
        // 判断坐标是否在国外
        private static bool isOutOfChina(double lat, double lon)
        {
            if (lon < 72.004 || lon > 137.8347)
                return true;
            if (lat < 0.8293 || lat > 55.8271)
                return true;
            return false;
        }
        //转换
        private static LocateInfo transform(double lat, double lon)
        {
            LocateInfo info = new LocateInfo();
            if (isOutOfChina(lat, lon))
            {
                info.IsChina=false;
                info.Latitude1=lat;
                info.Longitude=lon;
                return info;
            }
            double dLat = transformLat(lon - 105.0, lat - 35.0);
            double dLon = transformLon(lon - 105.0, lat - 35.0);
            double radLat = lat / 180.0 * pi;
            double magic = Math.Sin(radLat);
            magic = 1 - ee * magic * magic;
            double sqrtMagic = Math.Sqrt(magic);
            dLat = (dLat * 180.0) / ((a * (1 - ee)) / (magic * sqrtMagic) * pi);
            dLon = (dLon * 180.0) / (a / sqrtMagic * Math.Cos(radLat) * pi);
            double mgLat = lat + dLat;
            double mgLon = lon + dLon;
            info.IsChina=true;
            info.Latitude1=mgLat;
            info.Longitude=mgLon;

            return info;
        }
        //转换纬度所需
        private static double transformLat(double x, double y)
        {
            double ret = -100.0 + 2.0 * x + 3.0 * y + 0.2 * y * y + 0.1 * x * y
                    + 0.2 * Math.Sqrt(Math.Abs(x));
            ret += (20.0 * Math.Sin(6.0 * x * pi) + 20.0 * Math.Sin(2.0 * x * pi)) * 2.0 / 3.0;
            ret += (20.0 * Math.Sin(y * pi) + 40.0 * Math.Sin(y / 3.0 * pi)) * 2.0 / 3.0;
            ret += (160.0 * Math.Sin(y / 12.0 * pi) + 320 * Math.Sin(y * pi / 30.0)) * 2.0 / 3.0;
            return ret;
        }
        //转换经度所需
        private static double transformLon(double x, double y)
        {
            double ret = 300.0 + x + 2.0 * y + 0.1 * x * x + 0.1 * x * y + 0.1
                    * Math.Sqrt(Math.Abs(x));
            ret += (20.0 * Math.Sin(6.0 * x * pi) + 20.0 * Math.Sin(2.0 * x * pi)) * 2.0 / 3.0;
            ret += (20.0 * Math.Sin(x * pi) + 40.0 * Math.Sin(x / 3.0 * pi)) * 2.0 / 3.0;
            ret += (150.0 * Math.Sin(x / 12.0 * pi) + 300.0 * Math.Sin(x / 30.0 * pi)) * 2.0 / 3.0;
            return ret;
        }


            /*
             更新设备表device中的数据
             */
            public void update_device_table()
        {

            DataBase dataBase = new DataBase();
            MySqlConnection conn = DataBase.getconn();
            int k = dataBase.query_device(conn, "device");
            //表device中只保存最新数据
            if (k > 0)
            {

                dataBase.delete_device(conn, "device");

            }
            //将设备情况预先储存到数据库
            string json = Request.discover_device();
            JArray jArray = JArray.Parse("[" + json + "]");
            //获得设备数量
            int device_count = Convert.ToInt32(jArray[0]["data"]["total_count"]);
            int i = 0;
            //遍历json数组获得各个设备的信息
            for (; i < device_count; i++)
            {
                int deviceid = Convert.ToInt32(jArray[0]["data"]["devices"][i]["id"]);
                string devicename = jArray[0]["data"]["devices"][i]["title"].ToString();
                string devicestatus = jArray[0]["data"]["devices"][i]["online"].ToString();
                string deviceprotocol = jArray[0]["data"]["devices"][i]["protocol"].ToString();
                string devicecreattime = jArray[0]["data"]["devices"][i]["create_time"].ToString();
                //尝试获取设备上次上线时间
                try
                {    //若设备从未上线则不存在上线时间则ok为空
                    flag = jArray[0]["data"][i]["last_login"].ToString();
                }
                catch
                {

                }
                //如果设备最近上线过就获取上线的时间
                if (flag != null)
                {
                    last_login = jArray[0]["data"]["devices"][i]["last_login"].ToString();
                    flag = null;
                }


                //将数据插入到设备表
                dataBase.insert_device(conn, deviceid, devicename, devicestatus, deviceprotocol, devicecreattime);
                //只保留近七天的登录记录
                if (dataBase.query_device(conn, "loginhistory") > 7)
                {
                    dataBase.delete_device(conn, "loginhistory");
                }
                else
                {
                    //如果线上时间不为空就存入数据库
                    if (last_login != null)
                    {
                        //只存入不同的登录记录
                        if (dataBase.query_loginhistory(conn, "loginhistory", last_login) == 0)
                        {
                            dataBase.insert_loginhistory(conn, deviceid, last_login);
                            last_login = null;
                        }
                    }


                }
            }
        }
        //更新数据流表
        public void update_datastream_table()
        {

            //查询设备表device中的各个设备ID
            DataBase dataBase = new DataBase();
            MySqlConnection conn = DataBase.getconn();
            //获取设备数量
            int number = dataBase.query_device(conn, "device");
            //获得保存各个设备id的字符串数组
            string[] deviceid = dataBase.get_device_id(conn, "device", number);
            //遍历查询所有设备的数据流信息并存入数据流表datastream中
            //插入前先清空datastream
            dataBase.delete_device(conn, "datastream");
            int i = 0;
            for (; i < deviceid.Length; i++)
            {
                Request request = new Request();
                string json = request.discover_device_datastream(deviceid[i]);
                //构造json数组
                JArray jArray = JArray.Parse("[" + json + "]");
                int j = 0;
                while (true)
                {
                    //尝试获取数据流信息
                    try
                    {
                        flag = jArray[0]["data"]["datastreams"][j]["unit"].ToString();
                    }
                    catch
                    {

                    }
                    if (flag == null)//获取失败退出循环
                    {
                        break;
                    }
                    else//获取成功将数据插入数据流表datastream
                    {
                        string nuit = jArray[0]["data"]["datastreams"][j]["unit"].ToString();
                        string id = jArray[0]["data"]["datastreams"][j]["id"].ToString();
                        string unit_symbol = jArray[0]["data"]["datastreams"][j]["unit_symbol"].ToString();
                        dataBase.insert_datastream(conn, Convert.ToInt32(deviceid[i]), id, nuit, unit_symbol);
                        j++;
                        flag = null;
                    }


                }

            }


        }
    }

}