using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gdaxApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static gdaxApi.Model.Litecoin;

namespace gdaxApi.Controllers
{
    //[Produces("application/json")]
    [Route("api/[controller]")]
    public class LtcController : Controller
    {
        public Client user = new Client();
        public Litecoin ltc = new Litecoin();
        // GET api/BTC
        [Route("/ltcTicker")]
        [HttpGet]
        public async Task<string> GetTickerAsync()
        {
            return await ltc.GetEthTickerAsync();
        }

        [Route("/ltcHistory")]
        [HttpGet]
        public async Task<List<ltcHistoryDTO>> GetHistoryAsync()
        {
            return await ltc.GetEthHistory();
        }
    }
}