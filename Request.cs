using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Collections.Specialized;
using System.Reflection;

namespace newonenetapp
{
    class Request
    {
        private static string URL = " http://api.heclouds.com";
        private const string appkey = "Y7Q3ax=nt0T81UgAy9JsN3H0jUM=";
        private const string appkey_android = "3LRsZCILAX3HqjxYevttifgwKJc=";//手机设备秘钥
        private const string MobileDeviceID = "954545038";
        private const string DeviceID = "951993945";
        /* 添加请求首部参数*/
        public static void SetHeaderValue(WebHeaderCollection header, string name, string value)
        {
            var property = typeof(WebHeaderCollection).GetProperty("InnerCollection", BindingFlags.Instance | BindingFlags.NonPublic);
            if (property != null)
            {
                var collection = property.GetValue(header, null) as NameValueCollection;
                collection[name] = value;
            }
        }
        /*查询设备信息*/
        public static string discover_device()
        {
            string tempURL = URL;//拷贝URL防止改变原值
            tempURL += "/devices";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(tempURL);
            request.Method = "GET";
            SetHeaderValue(request.Headers, "api-key", appkey);//设备API地址和 首部参数
            request.Host = "api.heclouds.com";
            request.ProtocolVersion = new Version(1, 1);
            request.ContentType = "text/html;charset=UTF-8";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream myResponseStream = response.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
            string retString = myStreamReader.ReadToEnd();
            myStreamReader.Close();
            myResponseStream.Close();
            return retString;
        }
        /*
         查询设备数据流
         */
        public  string discover_device_datastream(string deviceid)
        {
            string tempURL = URL;//拷贝URL防止改变原值
            tempURL += "/devices/";
            tempURL += deviceid;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(tempURL);
            request.Method = "GET";
            SetHeaderValue(request.Headers, "api-key", appkey);//设备API地址和 首部参数
            request.Host = "api.heclouds.com";
            request.ProtocolVersion = new Version(1, 1);
            request.ContentType = "text/html;charset=UTF-8";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream myResponseStream = response.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
            string retString = myStreamReader.ReadToEnd();
            myStreamReader.Close();
            myResponseStream.Close();
            return retString;
        }
        /*
         添加数据流
         */
        public string add_datastream(string deviceid ,string datastreamid,string unit,string units_symbol)
        {
            //上传的json数据
            string json = "{" + "\"id\": "+"\""+datastreamid+"\""+ ",\"tags\": [\"mobile\"],"+ "\"unit\": "+"\""+unit+"\""+ ",\"unit_symbol\": "+"\""+units_symbol+"\"" + "}";
            string tempURL = URL;//拷贝URL防止改变原值
            tempURL += "/devices/";
            tempURL += deviceid;
            tempURL += "/datastreams";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(tempURL);
            request.Method = "POST";
            SetHeaderValue(request.Headers, "api-key", appkey);//设备API地址和 首部参数
            request.Host = "api.heclouds.com";
            request.ProtocolVersion = new Version(1, 1);
            request.ContentType = "text/html;charset=UTF-8";
            string strContent = json;
            using (StreamWriter dataStream = new StreamWriter(request.GetRequestStream()))
            {
                dataStream.Write(strContent);
                dataStream.Close();
            }

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream myResponseStream = response.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
            string retString = myStreamReader.ReadToEnd();
            Console.WriteLine(retString);
            myStreamReader.Close();
            myResponseStream.Close();
            return retString;

        }
        /*
         删除数据流
         */
        public string delete_datastream(string deviceid,string datastreamid)
        {
            string tempURL = URL;//拷贝URL防止改变原值
            tempURL += "/devices/";
            tempURL += deviceid;
            tempURL += "/datastreams/";
            tempURL += datastreamid;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(tempURL);
            request.Method = "DELETE";
            SetHeaderValue(request.Headers, "api-key", appkey);//设备API地址和 首部参数
            request.Host = "api.heclouds.com";
            request.ProtocolVersion = new Version(1, 1);
            request.ContentType = "text/html;charset=UTF-8";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream myResponseStream = response.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
            string retString = myStreamReader.ReadToEnd();
            myStreamReader.Close();
            myResponseStream.Close();
            return retString;
        }

        /*
         添加设备
         */
        public string add_device(string devicename,string describe,string author)
        {
            //上传的json数据
            string json = "{ \"title\": "+"\""+devicename+"\""+ ",\"desc\": "+"\""+describe+"\""+ ",\"tags\": [\"china\", \"mobile\"],\"location\": {\"lon\": 109, \"lat\": 23.54},\"auth_info\": "+"\""+author+"\""+ ",\"other\": {\"version\": \"1.0.0\",\"manufacturer\": \"china mobile\"}}";
            string tempURL = URL;//拷贝URL防止改变原值
            tempURL += "/devices";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(tempURL);
            request.Method = "POST";
            SetHeaderValue(request.Headers, "api-key", appkey);//设备API地址和 首部参数
            request.Host = "api.heclouds.com";
            request.ProtocolVersion = new Version(1, 1);
            request.ContentType = "text/html;charset=UTF-8";
            string strContent = json; 
            using (StreamWriter dataStream = new StreamWriter(request.GetRequestStream()))
            {
                dataStream.Write(strContent);
                dataStream.Close();
            }

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream myResponseStream = response.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
            string retString = myStreamReader.ReadToEnd();
            Console.WriteLine(retString);
            myStreamReader.Close();
            myResponseStream.Close();
            return retString;

        }
        /*
         删除设备
         */
        public string delete_device(string device_id)
        {
            string tempURL = URL;//拷贝URL防止改变原值
            tempURL += "/devices/";
            tempURL += device_id;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(tempURL);
            request.Method = "DELETE";
            SetHeaderValue(request.Headers, "api-key", appkey);//设备API地址和 首部参数
            request.Host = "api.heclouds.com";
            request.ProtocolVersion = new Version(1, 1);
            request.ContentType = "text/html;charset=UTF-8";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream myResponseStream = response.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
            string retString = myStreamReader.ReadToEnd();
            myStreamReader.Close();
            myResponseStream.Close();
            return retString;
        }
        /*
         查询设备历史数据
        */
        public string Discovery_device_DataHistory(string deviceid,string datastreamid,string start,string end,string limit)
        {

            string tempURL = URL;//拷贝URL防止改变原值
            tempURL += "/devices/";
            tempURL += deviceid;
            tempURL += "/datapoints?datastream_id=";
            tempURL += datastreamid;
            tempURL += "&start=";
            tempURL += start;
            tempURL += "&end=";
            tempURL += end;
            tempURL += "&limit=";
            tempURL += limit;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(tempURL);
            request.Method = "GET";
            SetHeaderValue(request.Headers, "api-key", appkey);//设备API地址和 首部参数
            request.Host = "api.heclouds.com";
            request.ProtocolVersion = new Version(1, 1);
            request.ContentType = "text/html;charset=UTF-8";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream myResponseStream = response.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
            string retString = myStreamReader.ReadToEnd();
            myStreamReader.Close();
            myResponseStream.Close();
            return retString;
        }
        /*
         查询移动设备的数据
         */
        public string Discovery_MobileDevice_Data()
        {
            string tempURL = URL;//拷贝URL防止改变原值
            tempURL += "/devices/";
            tempURL += "datapoints?devIds=";
            tempURL += MobileDeviceID;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(tempURL);
            request.Method = "GET";
            SetHeaderValue(request.Headers, "api-key", appkey_android);//设备API地址和 首部参数
            request.Host = "api.heclouds.com";
            request.ProtocolVersion = new Version(1, 1);
            request.ContentType = "text/html;charset=UTF-8";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream myResponseStream = response.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
            string retString = myStreamReader.ReadToEnd();
            myStreamReader.Close();
            myResponseStream.Close();
            return retString;
        }
        /*
         查询设备上传数据
         */
        public string DiscoveryDeviceData()
        {
            string tempURL = URL;//拷贝URL防止改变原值
            tempURL += "/devices/";
            tempURL += "datapoints?devIds=";
            tempURL += DeviceID;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(tempURL);
            request.Method = "GET";
            SetHeaderValue(request.Headers, "api-key", appkey);//设备API地址和 首部参数
            request.Host = "api.heclouds.com";
            request.ProtocolVersion = new Version(1, 1);
            request.ContentType = "text/html;charset=UTF-8";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream myResponseStream = response.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
            string retString = myStreamReader.ReadToEnd();
            myStreamReader.Close();
            myResponseStream.Close();
            return retString;
        }
        /*
         命令下发
         */

        public static string upload_command(string command, string device_id, string timeout)
        {

            string tempURL = URL;//拷贝URL防止改变原值
                                 // tempURL += "/devices/";
            tempURL += "/cmds?device_id=";
            tempURL += device_id;
            tempURL += "&timeout=";
            tempURL += timeout;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(tempURL);
            request.Method = "POST";
            SetHeaderValue(request.Headers, "api-key", appkey);//设备API地址和 首部参数
            request.Host = "api.heclouds.com";
            request.ProtocolVersion = new Version(1, 1);
            request.ContentType = "text/html;charset=UTF-8";
            // request.ContentType = "string";
            string strContent = command; //序列化为字符串，可以使用自己项目中封装的json方法
            using (StreamWriter dataStream = new StreamWriter(request.GetRequestStream()))
            {
                dataStream.Write(strContent);
                dataStream.Close();
            }

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream myResponseStream = response.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
            string retString = myStreamReader.ReadToEnd();
            Console.WriteLine(retString);
            myStreamReader.Close();
            myResponseStream.Close();
            return retString;
        }



    }
}
