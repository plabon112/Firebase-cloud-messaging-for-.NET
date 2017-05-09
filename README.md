# Firebase cloud messaging for .NET
It is a ibrary for .NET  to send notification from c# to any android  or IOS device using google firebase api.

## Installation
To install Firebase Cloud Messaging, run the following command in the Package Manager Console

<pre>Install-Package Firebase_Cloud_Messaging </pre>

## Example


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
