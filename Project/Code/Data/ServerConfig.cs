namespace Launcher.Code.Data
{
    public class ServerConfig
    {
        public ServerSettings Server;
        public BotsSettings Bots;

        public class ServerSettings
        {
            public string backendUrl = "http://localhost:1337";
            public string IP = "127.0.0.1";
            public int port = 1337;
        }

        public class BotsSettings
        {
            public PMCWarSettings PMCWar;
            public LimitSettings Limit;
            public SpawnSettings Spawn;

            public class PMCWarSettings
            {
                public bool enabled = false;
                public int chanceUsec = 55;
            }

            public class LimitSettings
            {
                // code here
            }

            public class SpawnSettings
            {
                //code here
            }
        }
    }
}
