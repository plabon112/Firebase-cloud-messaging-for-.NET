
// Name: Plabon Ghosh
// Software Engineer
// Mobile: 01681471824
// Email:plabon885@gmail.com
// Created Date: 10-05-2017


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCM
{
    public class RequestBuilder
    {
        FCM fcmObj;
        public string Send(object configObj)
        {
            string className = configObj.GetType().Name;

            switch (className)
            {
                case "ConfigForAndroid":
                    fcmObj = new Andoid();
                    break;

                case "ConfigForIOS":
                    fcmObj = new IOS();
                    break;

            }
            return fcmObj.Send(configObj);
        }

    }
}
