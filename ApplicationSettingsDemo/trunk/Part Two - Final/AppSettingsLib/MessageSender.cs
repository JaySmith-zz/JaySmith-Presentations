using System;
using System.Collections.Generic;
using System.Text;

namespace AppSettingsLib
{
    public class MessageSender
    {
        private IApplicationSettings _appSettings;

        public MessageSender(IApplicationSettings appSettings)
        {
            _appSettings = appSettings;
        }

        public void Send(string message)
        {
            string server = _appSettings.Server;
            string user = _appSettings.UserName();
            string password = _appSettings.Password();

            string user_pluss_pass = user + password;
        }
    }
}
