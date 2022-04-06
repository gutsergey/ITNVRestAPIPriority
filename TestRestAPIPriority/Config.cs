using System;
using Newtonsoft.Json;
namespace TestRestAPIPriority
{
    public class Config
    {
        private static Config instance = null;
        private string url = "";
        private string user = "";
        private string pwd = "";
        public static Config Instance { get => instance; }
        public string URL { get => url; }
        public string User { get => user; }
        public string Pwd { get => pwd; }
        private Config()
        {
            ReadConfig();
        }
        public static void Initialize()
        {
            if (instance == null)
            {
                instance = new Config();
            }
        }
        public void ReadConfig()
        {
            url = Cfg.GetValue("url");
            user = Cfg.GetValue("user");
            pwd = Cfg.GetValue("pwd");
        }
    }
}
