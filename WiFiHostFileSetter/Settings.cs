using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiFiHostFileSetter
{
    public class Settings
    {
        public String networkInterface { get; set; }

        public int interval { get; set; }

        public Dictionary<string, string> hosts { get; set; }

        public bool autoStart { get; set; }
        public bool askBeforeSwitch { get; set; }
        public bool startHidden { get; set; }

        public Settings()
        {
            hosts = new Dictionary<string, string>();

            interval = 5;
            autoStart = false;
            startHidden = false;
        }

        public void Save()
        {
            File.WriteAllText(Environment.CurrentDirectory + "/settings.json", JsonConvert.SerializeObject(this, Formatting.Indented));
        }

        public Settings Load()
        {
            if (File.Exists(Environment.CurrentDirectory + "/settings.json"))
                return JsonConvert.DeserializeObject<Settings>(File.ReadAllText(Environment.CurrentDirectory + "/settings.json"));
            else
                return null;
        }
    }
}
