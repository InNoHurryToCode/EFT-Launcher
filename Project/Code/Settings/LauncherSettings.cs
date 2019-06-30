using Launcher.Code.Data;

namespace Launcher.Code.Settings
{
    public class LauncherSettings : SettingsBase<LauncherConfig>
    {
        public LauncherSettings() : base("./data/", "config.json")
        {
            // for calling base constructor
        }

        public string GetEmail()
        {
            return base.config.email;
        }

        public void SetEmail(string value)
        {
            base.config.email = value;
            base.SaveSettings();
        }

        public string GetPassword()
        {
            return base.config.password;
        }

        public void SetPassword(string value)
        {
            base.config.password = value;
            base.SaveSettings();
        }

        public string GetGameLocation()
        {
            return base.config.gameLocation;
        }

        public void SetGameLocation(string value)
        {
            base.config.gameLocation = value;
            base.SaveSettings();
        }

        public string GetServerLocation()
        {
            return base.config.serverLocation;
        }

        public void SetServerLocation(string value)
        {
            base.config.serverLocation = value;
            base.SaveSettings();
        }

        public string GetBackendURL()
        {
            return base.config.backendURL;
        }

        public void SetBackendURL(string value)
        {
            base.config.backendURL = value;
            base.SaveSettings();
        }
    }
}
