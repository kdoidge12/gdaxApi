using GDAXSharp.Network.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gdaxApi.Model
{
    public class Client
    {
        private string apiKey = "ad5a8d1652dba099a2057b3d3c066c93";
        private string secret = "I034PbAsVNTPduY6Uwuf3r4gJs7AuC/ptGqzcq3UTDFgXuHD75xCt8Di8K8eYxlCq/CDjUosT4F40gNf9iczzQ==";
        private string passphrase = "JITA";
        public GDAXSharp.GDAXClient gdaxClient = null;
        public Authenticator authenticator = null;

        public Client()
        {
            this.authenticator = new Authenticator(this.apiKey, this.secret, this.passphrase);
            this.gdaxClient = new GDAXSharp.GDAXClient(authenticator);
        }
    }
}
