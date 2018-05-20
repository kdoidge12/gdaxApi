using GDAXSharp.Network.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gdaxApi.Model
{
    public class Client
    {
        private string apiKey = "4634071487a02c513b59a82b7122ffda";
		private string secret = "wAq4uoWu+KiuuuXwGm19ILhNojBfCNiKbNQVsyyo22XqEZYqfjm5GHzkS1trjVbVjJo22P6hX5GVvwthAJwcmg==";
        private string passphrase = "JITA";
        private static Client _instance = null;
        public GDAXSharp.GDAXClient gdaxClient = null;
        public Authenticator authenticator = null;
        private static readonly object padlock = new object();

        public Client()
        {
            this.authenticator = new Authenticator(this.apiKey, this.secret, this.passphrase);
            this.gdaxClient = new GDAXSharp.GDAXClient(authenticator);
        }

        public static Client Instance
        {
            get
            {
                lock (padlock)
                {
                    if (_instance == null)
                    {
                        _instance = new Client();
                    }
                    return _instance;
                }            
            }
        }
    }
}
