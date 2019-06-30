using System.Diagnostics;
using System.IO;
using Launcher.Code.Monitor;

namespace Launcher.Code.Starter
{
    public class StarterBase
    {
        private string filepath = "";
        private string executable = "";
        private Watcher watcher = null;

        protected StarterBase(string filepath, string executable)
        {
            this.filepath = filepath;
            this.executable = executable;
        }

        protected virtual void Start()
        {
            ProcessStartInfo process = new ProcessStartInfo();
            process.FileName = Path.Combine(filepath, executable);

            if (File.Exists(process.FileName))
            {
                Process gameProcess = Process.Start(process);
            }

            watcher = new Watcher(executable);
        }
    }
}
