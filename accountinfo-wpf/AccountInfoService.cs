using System;
using System.Text;
using System.Management;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Runtime.Serialization;
using System.Net;

namespace accountinfo
{
    class AccountInfoService
    {
        public Config config;
        public String serial;
        public String remoteName;
        public String account;

        public AccountInfoService()
        {
            loadConfig();
            getSerial();
            getRemoteInfo();
        }

        public void getRemoteInfo()
        {
            WebRequest request = WebRequest.Create(config.url + "/computers/info/" + serial);
            request.Method = "GET";

            WebResponse response = request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);

            var result = reader.ReadToEnd();
            stream.Dispose();
            reader.Dispose();

            if (result == "0")
            {
                remoteName = "NOT REGISTERED";
                account = "";
            }
            else
            {
                string[] remoteInfo = result.Split(',');
                if (remoteInfo.Length == 1)
                {
                    remoteName = remoteInfo[0];
                    account = "No Account";
                }
                else
                {
                    remoteName = remoteInfo[0];
                    account = remoteInfo[1];
                }
            }
        }

        public void getSerial()
        {
           
            ManagementClass wmi = new ManagementClass("Win32_Bios");
            foreach (ManagementObject bios in wmi.GetInstances())
            {
                serial = bios.Properties["Serialnumber"].Value.ToString().Trim();
            }
            
        }

        public String registerWithServer()
        {
            WebRequest request = WebRequest.Create(config.url + "/computers/register");
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            String data = String.Format("computer[serial]={0}&computer[name]={1}", serial, Environment.MachineName);
            byte[] bytes = Encoding.UTF8.GetBytes(data);
            request.ContentLength = bytes.Length;

            Stream requestStream = request.GetRequestStream();
            requestStream.Write(bytes, 0, bytes.Length);

            WebResponse response = request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);

            var result = reader.ReadToEnd();
            stream.Dispose();
            reader.Dispose();

            return result;
        }

        private void loadConfig()
        {
            String configPath = System.IO.Path.Combine(".","config.json");
            String json = File.ReadAllText(configPath, Encoding.UTF8);
            MemoryStream r = new MemoryStream(Encoding.UTF8.GetBytes(json));
            DataContractJsonSerializer jser = new DataContractJsonSerializer(typeof(Config));
            config = (Config)jser.ReadObject((Stream)r);
        }

    }

    [DataContract]
    public class Config
    {
        [DataMember]
        public String url;
    }
}
