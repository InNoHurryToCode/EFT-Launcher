namespace Launcher.Code.Starter
{
    class ServerStarter : StarterBase
    {
        public ServerStarter(string filepath) : base(filepath, "server.exe")
        {
            base.Start();
        }
    }
}
