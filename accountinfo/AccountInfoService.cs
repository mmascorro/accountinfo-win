using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace accountinfo
{
    class AccountInfoService
    {
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
    }
}
