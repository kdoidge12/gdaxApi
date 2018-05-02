using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gdaxApi.Model;
using GDAXSharp.Network.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace gdaxApi.Controllers
{
    //[Produces("application/json")]
    [Route("api/[controller]")]
    public class AccountsController : Controller
    {

        public Client user = new Client();
        public Bitcoin btc = new Bitcoin();
        // GET api/Accounts
        [HttpGet]
        public async Task<string> GetAsync()
        {
            return await btc.GetBtcTickerAsync();
        }

    }
}