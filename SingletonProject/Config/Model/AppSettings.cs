using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonProject.Config.Model
{
    public class AppSettings
    {
        public string version { get; set; }
        public string developmentLevel { get; set; }
        public string connectionString { get; set; }

    }
}
