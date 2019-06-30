using System.IO;
using Launcher.Code.Helper;

namespace Launcher.Code.Settings
{
    public class SettingsBase<T>
    {
        protected T config { private set; get; }
        private string filepath = "";

        protected SettingsBase(string filepath, string file)
        {
            this.filepath = Path.Combine(filepath, file);
            LoadSettings();
        }

        public virtual void LoadSettings()
        {
            config = JSON.Load<T>(filepath);
        }

        public virtual void SaveSettings()
        {
            JSON.Save<T>(filepath, config);
        }
    }
}
