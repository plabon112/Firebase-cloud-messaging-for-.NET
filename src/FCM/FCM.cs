

// Name: Plabon Ghosh
// Software Engineer
// Mobile: 01681471824
// Email:plabon885@gmail.com
// Created Date: 10-05-2017


using Config;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace FCM
{  
     interface FCM
    {
        string Send(object obj);
    }
    // For Android

    internal class Andoid : FCM
    {
        public string Send(object obj)
        {
            string sResponseFromServer = "";
            try
            {
                ConfigForAndroid configObj = (ConfigForAndroid)obj;

                var applicationID = configObj.ApplicationID;
                WebRequest tRequest = WebRequest.Create("https://fcm.googleapis.com/fcm/send");
                tRequest.Method = "post";
                tRequest.ContentType = "application/json";

                var data = new
                {
                    to = configObj.ToID,
                    notification = new
                    {
                        body = configObj.TitleBody,
                        title = configObj.Title,
                        sound = string.IsNullOrEmpty(configObj.Sound)? "default": configObj.Sound,
                        icon = configObj.Icon
                    },

                    data = configObj.Data,
                    priority = string.IsNullOrEmpty(configObj.Priority) ? "default" : configObj.Priority,

                };

                var serializer = new JavaScriptSerializer();
                var json = serializer.Serialize(data);
                Byte[] byteArray = Encoding.UTF8.GetBytes(json);
                tRequest.Headers.Add(string.Format("Authorization: key={0}", applicationID));
                tRequest.ContentLength = byteArray.Length;

                using (Stream dataStream = tRequest.GetRequestStream())
                {
                    dataStream.Write(byteArray, 0, byteArray.Length);
                    using (WebResponse tResponse = tRequest.GetResponse())
                    {
                        using (Stream dataStreamResponse = tResponse.GetResponseStream())
                        using (StreamReader tReader = new StreamReader(dataStreamResponse))
                        {
                            sResponseFromServer = tReader.ReadToEnd();
                        }
                    }
                }

                return sResponseFromServer;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }

    // For IOS
    internal class IOS : FCM
    {

        public string Send(object obj)
        {
            string sResponseFromServer = "";
            try
            {
                ConfigForIOS configObj = (ConfigForIOS)obj;

                var applicationID = configObj.ApplicationID;
                WebRequest tRequest = WebRequest.Create("https://fcm.googleapis.com/fcm/send");
                tRequest.Method = "post";
                tRequest.ContentType = "application/json";

                var data = new
                {
                    to = configObj.ToID,
                    notification = new
                    {
                        body = configObj.TitleBody,
                        title = configObj.Title,
                        sound = configObj.Sound,
                    },
                    data = configObj.Data,
                    priority = configObj.Priority

                };

                var serializer = new JavaScriptSerializer();
                var json = serializer.Serialize(data);
                Byte[] byteArray = Encoding.UTF8.GetBytes(json);
                tRequest.Headers.Add(string.Format("Authorization: key={0}", applicationID));
                tRequest.ContentLength = byteArray.Length;

                using (Stream dataStream = tRequest.GetRequestStream())
                {
                    dataStream.Write(byteArray, 0, byteArray.Length);
                    using (WebResponse tResponse = tRequest.GetResponse())
                    {
                        using (Stream dataStreamResponse = tResponse.GetResponseStream())
                        using (StreamReader tReader = new StreamReader(dataStreamResponse))
                        {
                            sResponseFromServer = tReader.ReadToEnd();
                        }
                    }
                }

                return sResponseFromServer;
            }
            catch (Exception ex)
            {
                return "";
            }
        }
    }

}

