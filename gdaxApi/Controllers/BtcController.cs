using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gdaxApi.Model;
using GDAXSharp.Network.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static gdaxApi.Model.Bitcoin;

namespace gdaxApi.Controllers
{
    //[Produces("application/json")]
    [Route("api/[controller]")]
    public class BtcController : Controller
    {

        public Client user = new Client();
        public Bitcoin btc = new Bitcoin();
        // GET api/BTC
        [Route("/productTicker")]
        [HttpGet]
        public async Task<string> GetTickerAsync()
        {
            return await btc.GetBtcTickerAsync();
        }

        [Route("/24hrHistory")]
        [HttpGet]
        public async Task<List<HistoryDTO>> GetHistoryAsync()
        {
            return await btc.GetBtcHistory();
        }

    }
}