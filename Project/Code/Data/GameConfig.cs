namespace Launcher.Code.Data
{
    public class GameConfig
    {
        public string BackendUrl = "https://prod.escapefromtarkov.com";
        public string Version = "Live";
        public string BuildVersion = "000";
        public bool LocalGame = false;
        public int AmmoPoolSize = -1;
        public int WeaponsPoolSize = -1;
        public int MagsPoolSize = -1;
        public int ItemsPoolSize = -1;
        public int PlayersPoolSoze = 30;
        public int ObservedFix = 1;
        public int TargetFrameRate = -1;
        public int BotsCount = -1;
        public bool ResetSettings = false;
        public bool SaveResults = false;
        public int FixedFrameRate = 60;
    }
}
