using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonProject.Config.Model
{
    public class AppConfig
    {
        public string? application_name { get; set; }
        public AppSettings? application_settings { get; set; }
        public UiConfig? UiConfig { get; set; }
    }
}
