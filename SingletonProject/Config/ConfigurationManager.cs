using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonProject.Config
{
    public sealed class ConfigurationManager
    {
        private static ConfigurationManager _instance;
        private Dictionary<string, string> _settings;

        public ConfigurationManager()
        {
            _settings = new Dictionary<string, string>();
            loadSettings();
            Console.WriteLine("ConfigurationManager initialized ");
        }

        public static ConfigurationManager Instance
        {
            get {
                if (_instance == null) 
                {
                    _instance = new ConfigurationManager();
                }
                return _instance;
            }
        }

        public void loadSettings()
        {
            var settings = ReadSettings.ReadJson();

            _settings.Add("ApplicationName", settings.application_name);
            _settings.Add("ConnectionString", settings.application_settings.connectionString);
            _settings.Add("AplicationVersion" , settings.application_settings.version);
            
        }

        public string getSettings(string key)
        {
            if(_settings.ContainsKey(key))
                return _settings[key];

            return $"There is no this {key} settings";
        }
    }
}
