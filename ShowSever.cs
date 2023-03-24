using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace newonenetapp
{
    class ShowSever
    {
        private string id = null;
        private int tempreture = 0;
        private int humidity = 0;
        private int light = 0;
        public void StartShowTemperture(Action<int> TempertureShow)
        {

            Mutex mutex = new Mutex();
            Data data = new Data();
            Request request = new Request();
            ThreadPool.QueueUserWorkItem(
                (a) =>
                {
                    while (true)
                    {
                        string json = request.DiscoveryDeviceData();
                        lock (mutex)
                        {
                            JArray jArray = JArray.Parse("[" + json + "]");
                            int i = 0;
                            while(true)
                            {
                                try
                                {
                                    id = jArray[0]["data"]["devices"][0]["datastreams"][i]["id"].ToString();
                                    
                                }
                                catch
                                {

                                }
                                if(id== "tempterture")
                                {
                                    tempreture = Convert.ToInt32(jArray[0]["data"]["devices"][0]["datastreams"][i]["value"]);
                                    break;

                                }
                                else
                                {
                                    i++;
                                }
                            }
                            TempertureShow(tempreture);
                        }
                    }
                }
                );
        }

        public void StartShowTemperture1(Action<int> XShow)
        {

            Mutex mutex = new Mutex();
            Data data = new Data();
            Request request = new Request();
            ThreadPool.QueueUserWorkItem(
                (a) =>
                {
                    while (true)
                    {
                        string json = request.DiscoveryDeviceData();
                        lock (mutex)
                        {
                            JArray jArray = JArray.Parse("[" + json + "]");
                            int i = 0;
                            while (true)
                            {
                                try
                                {
                                    id = jArray[0]["data"]["devices"][0]["datastreams"][i]["id"].ToString();

                                }
                                catch
                                {

                                }
                                if (id == "tempterture")
                                {
                                    tempreture = Convert.ToInt32(jArray[0]["data"]["devices"][0]["datastreams"][i]["value"]);
                                    break;

                                }
                                else
                                {
                                    i++;
                                }
                            }
                            XShow(tempreture);
                        }
                    }
                }
                );
        }

        public void StartShowHumidity(Action<int> HumidityShow)
        {

            Mutex mutex = new Mutex();
            Data data = new Data();
            Request request = new Request();
            ThreadPool.QueueUserWorkItem(
                (a) =>
                {
                    while (true)
                    {
                        string json = request.DiscoveryDeviceData();
                        lock (mutex)
                        {
                            JArray jArray = JArray.Parse("[" + json + "]");
                            int i = 0;
                            while (true)
                            {
                                try
                                {
                                    id = jArray[0]["data"]["devices"][0]["datastreams"][i]["id"].ToString();

                                }
                                catch
                                {

                                }
                                if (id == "humidity")
                                {
                                    light= Convert.ToInt32(jArray[0]["data"]["devices"][0]["datastreams"][i]["value"]);
                                    break;

                                }
                                else
                                {
                                    i++;
                                }
                            }
                            HumidityShow(light);
                        }
                    }
                }
                );
        }


        public void StartShowHumidity1(Action<int> XShow)
        {

            Mutex mutex = new Mutex();
            Data data = new Data();
            Request request = new Request();
            ThreadPool.QueueUserWorkItem(
                (a) =>
                {
                    while (true)
                    {
                        string json = request.DiscoveryDeviceData();
                        lock (mutex)
                        {
                            JArray jArray = JArray.Parse("[" + json + "]");
                            int i = 0;
                            while (true)
                            {
                                try
                                {
                                    id = jArray[0]["data"]["devices"][0]["datastreams"][i]["id"].ToString();

                                }
                                catch
                                {

                                }
                                if (id == "humidity")
                                {
                                    light = Convert.ToInt32(jArray[0]["data"]["devices"][0]["datastreams"][i]["value"]);
                                    break;

                                }
                                else
                                {
                                    i++;
                                }
                            }
                            XShow(light);
                        }
                    }
                }
                );
        }


        public void StartShowLight(Action<int> HumidityShow)
        {

            Mutex mutex = new Mutex();
            Data data = new Data();
            Request request = new Request();
            ThreadPool.QueueUserWorkItem(
                (a) =>
                {
                    while (true)
                    {
                        string json = request.Discovery_MobileDevice_Data();
                        lock (mutex)
                        {
                            JArray jArray = JArray.Parse("[" + json + "]");
                            int i = 0;
                            while (true)
                            {
                                try
                                {
                                    id = jArray[0]["data"]["devices"][0]["datastreams"][i]["id"].ToString();

                                }
                                catch
                                {

                                }
                                if (id == "light")
                                {
                                    light = Convert.ToInt32(jArray[0]["data"]["devices"][0]["datastreams"][i]["value"]);
                                    break;

                                }
                                else
                                {
                                    i++;
                                }
                            }
                            HumidityShow(light);
                        }
                    }
                }
                );
        }


        public void StartShowLight1(Action<int> XShow)
        {

            Mutex mutex = new Mutex();
            Data data = new Data();
            Request request = new Request();
            ThreadPool.QueueUserWorkItem(
                (a) =>
                {
                    while (true)
                    {
                        string json = request.Discovery_MobileDevice_Data();
                        lock (mutex)
                        {
                            JArray jArray = JArray.Parse("[" + json + "]");
                            int i = 0;
                            while (true)
                            {
                                try
                                {
                                    id = jArray[0]["data"]["devices"][0]["datastreams"][i]["id"].ToString();

                                }
                                catch
                                {

                                }
                                if (id == "light")
                                {
                                    light = Convert.ToInt32(jArray[0]["data"]["devices"][0]["datastreams"][i]["value"]);
                                    break;

                                }
                                else
                                {
                                    i++;
                                }
                            }
                            XShow(light);
                        }
                    }
                }
                );
        }

    }
}
