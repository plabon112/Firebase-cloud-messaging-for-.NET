
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

namespace Config
{
   public  class ConfigForAndroid
    {
        public string ApplicationID { get; set; }
        public string Topics { get; set; }
        public string Data { get; set; }
        public string ToID { get; set; }
        public string Title { get; set; }
        public string TitleBody { get; set; }
        public string Sound { get; set; }
        public string Priority { get; set; }
        public string Icon { get; set; }
    }

    public class ConfigForIOS
    {
        public string ApplicationID { get; set; }
        public string Topics { get; set; }
        public string Data { get; set; }
        public string ToID { get; set; }
        public string Title { get; set; }
        public string TitleBody { get; set; }
        public string Sound { get; set; }
        public string Priority { get; set; }
    }

}
