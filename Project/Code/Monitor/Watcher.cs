using System;
using System.Diagnostics;
using System.Timers;

namespace Launcher.Code.Monitor
{
    public class Watcher
    {
        private string executable = "";
        private Timer monitor = null;

        public Watcher(string executable)
        {
            this.executable = executable;

            monitor = new Timer(1000);
            monitor.Elapsed += Monitor;
            monitor.AutoReset = true;
            monitor.Enabled = true;
        }

        private void Monitor(Object source, ElapsedEventArgs e)
        {
            Process[] activeProcesses = Process.GetProcessesByName(executable);

            if (activeProcesses.Length == 0)
            {
                monitor.Enabled = false;
                OnProcessClose();
            }
        }

        protected void OnProcessClose()
        {
            // code here
        }
    }
}
