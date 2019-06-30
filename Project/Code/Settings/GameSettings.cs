using Launcher.Code.Data;

namespace Launcher.Code.Settings
{
    public class GameSettings : SettingsBase<GameConfig>
    {
        public GameSettings(string filepath) : base(filepath, "client.config.json")
        {
            // for calling base constructor
        }

        public string GetBackendURL()
        {
            return base.config.BackendUrl;
        }

        public void SetBackendURL(string value)
        {
            base.config.BackendUrl = value;
            base.SaveSettings();
        }
    }
}
