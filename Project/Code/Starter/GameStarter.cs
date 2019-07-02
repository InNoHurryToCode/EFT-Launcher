using System;
using Microsoft.Win32;
using Launcher.Code.Data;
using Launcher.Code.Helper;
using Launcher.Code.Settings;

namespace Launcher.Code.Starter
{
    public class GameStarter : StarterBase
    {
        public GameStarter(string filepath, string backendURL, string email, string password) : base(filepath, "EscapeFromTarkov.exe")
        {
            SetBackendURL(filepath, backendURL);
            GenerateToken(email, password);
            Start();
        }

        private void SetBackendURL(string filepath, string backendURL)
        {
            GameSettings gameSettings = new GameSettings(filepath);
            gameSettings.SetBackendURL(backendURL);
        }

        private void GenerateToken(string email, string password)
        {
            // create a base token
            LoginToken loginToken = new LoginToken();
            loginToken.email = email;
            loginToken.password = password;

            // calculate timestamp
            double secondsSince1970 = DateTime.Now.ToUniversalTime().Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
            loginToken.timestamp = (long)(Math.Floor(secondsSince1970 + 45)) ^ 698464131;

            // convert login data to encoded base64 json
            char[] json = JSON.EncodeTo64(JSON.Normalize<LoginToken>(loginToken)).ToCharArray();

            // convert encoded base64 json to bytes
            byte[] bytes = new byte[json.Length];

            for (int i = 0; i < json.Length; ++i)
            {
                bytes[i] += (byte)json[i];
            }

            // write token to registery
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Battlestate Games\EscapeFromTarkov", "bC5vLmcuaS5u_h1472614626", bytes, RegistryValueKind.Binary);
        }
    }
}
