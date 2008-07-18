using AppSettingsLib;

namespace MessageClient
{
    public class AppSettings : IApplicationSettings
    {
        public string Server
        {
            get { return Properties.Settings.Default.Server; }
        }

        public string UserName()
        {
            return Properties.Settings.Default.User;
        }

        public string Password()
        {
            return Properties.Settings.Default.Password;
        }
    }
}