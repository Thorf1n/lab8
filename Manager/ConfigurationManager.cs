

namespace Manager
{
    public sealed class ConfigurationManager
    {
        private static ConfigurationManager _instance;
        private Dictionary<string, string> configurations;

        private ConfigurationManager()
        {
            configurations = new Dictionary<string, string>();
        }

        public static ConfigurationManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ConfigurationManager();
                }
                return _instance;
            }
        }

        public void SetConfiguration(string key, string value)
        {
            configurations[key] = value;
        }

        public string GetConfiguration(string key)
        {
            return configurations.ContainsKey(key) ? configurations[key] : null;
        }

        public void DisplayConfigurations()
        {
            Console.WriteLine("Current Configurations:");
            foreach (var entry in configurations)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
        }
    }
}
