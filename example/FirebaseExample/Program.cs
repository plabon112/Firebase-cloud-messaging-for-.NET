using Config;
using FCM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirebaseExample
{
    class Program
    {
        static void Main(string[] args)
        {

            //For Android
           
            RequestBuilder obj = new RequestBuilder();
            ConfigForAndroid config = new ConfigForAndroid();
            config.ApplicationID = "";
            config.Icon = "";
            config.Sound = "";
            config.Priority = "";
            config.Title = "";
            config.TitleBody = "";
            config.ToID = ""; // User Token or topics;
            Console.WriteLine(obj.Send(config));

            //For IOS

            obj = new RequestBuilder();
            ConfigForIOS configIOS = new ConfigForIOS();
            configIOS.ApplicationID = ""; 
            configIOS.Sound = "";
            configIOS.Priority = "";
            configIOS.Title = "";
            configIOS.TitleBody = "";
            configIOS.ToID = ""; // User Token or topics;
            Console.WriteLine(obj.Send(configIOS));
        }
    }
}
