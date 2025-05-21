using SingletonProject.Config.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SingletonProject.Config
{
    public class ReadSettings
    {
        private static string jsonPath = @"C:\Users\super\OneDrive\Documents\KULIAHHH\SEMESTER 4\SOFTWARE CONSTRUCTION\Personal Assignment (Code Implementaion)\SingletonProject\SingletonProject\appsettings.json";
        public static AppConfig ReadJson()
        {
            string json = File.ReadAllText(jsonPath) ;

            if(json == null) return null ;

            AppConfig? appConfig = JsonSerializer.Deserialize<AppConfig>(json);

            return appConfig;
        }
    }
}
