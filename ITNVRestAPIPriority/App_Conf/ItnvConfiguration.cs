using System;
using Newtonsoft.Json;
namespace ITNVRestAPIPriority.App_Conf
{
    public class ItnvConfiguration
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private static ItnvConfiguration instance = null;

        private string priorityURL = "";
        private string priorityUser = "";
        private string priorityPwd = "";
        private string campaigncodenew = "";
        private string campaigncodeexist = "";
        private string popupurl = "";
        private string emailsuffix = "";
        public static ItnvConfiguration Instance { get => instance; }

        public string PriorityURL { get => priorityURL; }
        public string PriorityUser { get => priorityUser; }
        public string PriorityPwd { get => priorityPwd; }
        public string Campaigncodenew { get => campaigncodenew; }
        public string Campaigncodeexist { get => campaigncodeexist; }
        public string Popupurl { get => popupurl; }
        public string Emailsuffix { get => emailsuffix; }

        private ItnvConfiguration()
        {
            ReadConfig();
            PrintConfig();
        }

        public static void Initialize()
        {
            if (instance == null)
            {
                instance = new ItnvConfiguration();
            }
        }

        public void ReadConfig()
        {
            priorityURL = Cfg.GetValue("PriorityURL");
            priorityUser = Cfg.GetValue("PriorityUser");
            priorityPwd = Cfg.GetValue("PriorityPwd");
            campaigncodenew = Cfg.GetValue("Campaigncodenew");
            campaigncodeexist = Cfg.GetValue("Campaigncodeexist");
            popupurl = Cfg.GetValue("Popupurl");
            popupurl = popupurl.Replace("AMPERSAND", "&");
            emailsuffix = Cfg.GetValue("Emailsuffix");
        }

        private void PrintConfig()
        {
            Version version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;

            log.Info($"-----------------------> version: {version.ToString()} <-----------------------");

            string strjson = JsonConvert.SerializeObject(this, Formatting.Indented);

            log.Info(strjson);

            log.Info("<-----------------------");

        }

    }

}
