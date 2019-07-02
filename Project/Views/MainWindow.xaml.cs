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
        private LauncherSettings laucherSettings = new LauncherSettings();

        public MainWindow()
        {
            InitializeComponent();
            LoadAllSettings();
            OnAccount(null, null);
        }

        private void HideAllMenuBarGrids()
        {
            // account
            LoginGrid.Visibility = Visibility.Hidden;
            // RegisterGrid.Visibility = Visibility.Hidden;
            // AccountGrid.Visibility = Visibility.Hidden;
            // ChangeEmailGrid.Visibility = Visibility.Hidden;
            // ChangePasswordGrid.Visibility = Visibility.Hidden;

            // server
            // ServerGeneral.Visibility = Visibility.Hidden;
            // ServerBots.Visibility = Visibility.Hidden;
            // ServerWeather.Visibility = Visibility.Hidden;

            // launcher
            SettingsGrid.Visibility = Visibility.Hidden;
        }

        #region LOAD_SETTINGS
        private void LoadAccountSettings()
        {
            Email.Text = laucherSettings.GetEmail();
            Password.Text = laucherSettings.GetPassword();
            ClientBackendURL.Text = laucherSettings.GetBackendURL();
        }

        private void LoadLauncherSettings()
        {
            GameLocation.Text = laucherSettings.GetGameLocation();
            ServerLocation.Text = laucherSettings.GetServerLocation();
        }

        private void LoadAllSettings()
        {
            LoadAccountSettings();
            LoadLauncherSettings();
        }
        #endregion

        #region MENU_BAR
        // TODO: Check if user is logged in
        private void OnAccount(object sender, RoutedEventArgs e)
        {
            HideAllMenuBarGrids();
            LoginGrid.Visibility = Visibility.Visible;
            LoadAccountSettings();
        }

        private void OnServerGeneral(object sender, RoutedEventArgs e)
        {
            // code here
        }

        private void OnServerBots(object sender, RoutedEventArgs e)
        {
            // code here
        }

        private void OnServerWeather(object sender, RoutedEventArgs e)
        {
            // code here
        }

        private void OnSettings(object sender, RoutedEventArgs e)
        {
            HideAllMenuBarGrids();
            SettingsGrid.Visibility = Visibility.Visible;
            LoadLauncherSettings();
        }
        #endregion

        #region APPLICATION_LAUNCHER
        private void OnStartGame(object sender, RoutedEventArgs e)
        {
            GameStarter starter = new GameStarter(GameLocation.Text, ClientBackendURL.Text, Email.Text, Password.Text);
        }

        private void OnStartServer(object sender, RoutedEventArgs e)
        {
            ServerStarter starter = new ServerStarter(ServerLocation.Text);
        }
        #endregion

        #region ACCOUNT_LOGIN
        private void OnChangeEmail(object sender, TextChangedEventArgs e)
        {
            laucherSettings.SetEmail(Email.Text);
        }

        private void OnChangePassword(object sender, TextChangedEventArgs e)
        {
            laucherSettings.SetPassword(Password.Text);
        }

        private void OnChangeClientBackendURL(object sender, TextChangedEventArgs e)
        {
            laucherSettings.SetBackendURL(ClientBackendURL.Text);
        }

        private void OnLogin(object sender, RoutedEventArgs e)
        {
            // code here
        }

        private void OnRegisterMenu(object sender, RoutedEventArgs e)
        {
            // code here
        }
        #endregion

        #region LAUNCHER_SETTINGS
        private void OnChangeGameLocation(object sender, TextChangedEventArgs e)
        {
            laucherSettings.SetGameLocation(GameLocation.Text);
        }

        private void OnChangeServerLocation(object sender, TextChangedEventArgs e)
        {
            laucherSettings.SetServerLocation(ServerLocation.Text);
        }
        #endregion
    }
}
