using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Runtime.Serialization;

namespace accountinfo
{
    class AccountInfoService
    {

        public Config config;

        public AccountInfoService()
        {
            this.loadConfig();
        }

        public String getSerial()
        {
           
            String serial = "";
            ManagementClass wmi = new ManagementClass("Win32_Bios");
            foreach (ManagementObject bios in wmi.GetInstances())
            {
                serial = bios.Properties["Serialnumber"].Value.ToString().Trim();
            }
            return serial;
        }

        private void loadConfig()
        {
           
            String configPath = System.IO.Path.Combine(".","config.json");
            String json = File.ReadAllText(configPath, Encoding.UTF8);
            MemoryStream r = new MemoryStream(Encoding.UTF8.GetBytes(json));
            DataContractJsonSerializer jser = new DataContractJsonSerializer(typeof(Config));
            this.config = (Config)jser.ReadObject((Stream)r);
        }
    }

    [DataContract]
    public class Config
    {
        [DataMember]
        public String url;
    }
}
