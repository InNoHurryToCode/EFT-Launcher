using System;
using System.Diagnostics;
using System.Timers;

namespace Launcher.Code.Monitor
{
    public class Watcher
    {
        public bool processAlive { get; private set; }
        private Timer monitor = null;
        private string executable = "";

        public Watcher(string executable)
        {
            this.executable = executable.Replace(".exe", "");

            monitor = new Timer(1000);
            monitor.Elapsed += OnUpdate;
            monitor.AutoReset = true;
            monitor.Enabled = true;
        }

        private void OnUpdate(Object source, ElapsedEventArgs e)
        {
            processAlive = IsProcessAlive();
        }

        public bool IsProcessAlive()
        {
            Process[] activeProcesses = Process.GetProcessesByName(executable);

            if (activeProcesses.Length > 0)
            {
                return true;
            }
            else
            {
                monitor.Enabled = false;
                return false;
            }
        }
    }
}
