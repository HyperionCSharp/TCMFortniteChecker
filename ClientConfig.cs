using Newtonsoft.Json;
using System.IO;
using System.Linq;
using System.Reflection;

namespace FortniteCracker
{
    internal struct ClientConfig
    {
        private static ClientConfig[] _configs;
        static ClientConfig()
        {
            _configs = JsonConvert.DeserializeObject<ClientConfig[]>(File.ReadAllText("mailservers.json"));
            return;
        }
        public string[] Domains { get; set; }
        public string Type { get; set; }
        public string Hostname { get; set; }
        public int Port { get; set; }
        public string SocketType { get; set; }
        public string UserName { get; set; }
        public static ClientConfig GetConfig(string domain)
        {
            ClientConfig config;
            try
            {
                config = _configs.Where(x => x.Domains.Any(xx => xx == domain)).ToArray()[0];
            }
            catch
            {
                config = new ClientConfig
                {
                    Port = 993,
                    Hostname = "imap." + domain,
                    SocketType = "SSL",
                    Type = "imap"
                };
            }
            return config;
        }
        public bool IsNull()
        {
            return string.IsNullOrWhiteSpace(Hostname);
        }
        public override string ToString()
        {
            string text = Hostname;
            if (text.Length > 33)
            {
                text = text.Substring(0, 30) + "...";
            }
            return text;
        }
    }
}
