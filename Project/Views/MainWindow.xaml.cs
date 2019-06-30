using System.Windows;
using System.Windows.Controls;
using Launcher.Code.Settings;
using Launcher.Code.Starter;

namespace Launcher
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private LauncherSettings settings = new LauncherSettings();

        public MainWindow()
        {
            InitializeComponent();
            LoadSettings();
        }

        private void LoadSettings()
        {
            Email.Text = settings.GetEmail();
            Password.Text = settings.GetPassword();
            GameLocation.Text = settings.GetGameLocation();
            ServerLocation.Text = settings.GetServerLocation();
            BackendURL.Text = settings.GetBackendURL();
        }

        private void OnStartGame(object sender, RoutedEventArgs e)
        {
            GameStarter starter = new GameStarter(GameLocation.Text, BackendURL.Text, Email.Text, Password.Text);
        }

        private void OnStartServer(object sender, RoutedEventArgs e)
        {
            ServerStarter starter = new ServerStarter(ServerLocation.Text);
        }

        private void OnChangeEmail(object sender, TextChangedEventArgs e)
        {
            settings.SetEmail(Email.Text);
        }

        private void OnChangePassword(object sender, TextChangedEventArgs e)
        {
            settings.SetPassword(Password.Text);
        }

        private void OnChangeGameLocation(object sender, TextChangedEventArgs e)
        {
            settings.SetGameLocation(GameLocation.Text);
        }

        private void OnChangeServerLocation(object sender, TextChangedEventArgs e)
        {
            settings.SetServerLocation(ServerLocation.Text);
        }

        private void OnChangeBackendURL(object sender, TextChangedEventArgs e)
        {
            settings.SetBackendURL(BackendURL.Text);
        }
    }
}
