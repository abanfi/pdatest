using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDATestProject
{
    public static class ConfigUtil
    {

        private static string CONFIG_NAME = "webserviceEndpoint";

        public static string getEndpointAddress()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            string value = config.AppSettings.Settings[CONFIG_NAME].Value;
            return value;
        }

        public static void setEndpointAddress(string endpoint)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings[CONFIG_NAME].Value = endpoint;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }


    }
}
