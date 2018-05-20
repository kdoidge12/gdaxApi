using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gdaxApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static gdaxApi.Model.Ethereum;

namespace gdaxApi.Controllers
{
    //[Produces("application/json")]
    [Route("api/[controller]")]
    public class EthController : Controller
    {
        //public Client user = new Client();
        public Ethereum eth = new Ethereum();
        // GET api/BTC
        [Route("/ethTicker")]
        [HttpGet]
        public async Task<string> GetTickerAsync()
        {
            return await eth.GetEthTickerAsync();
        }

        [Route("/ethHistory")]
        [HttpGet]
        public async Task<List<ethHistoryDTO>> GetHistoryAsync()
        {
            return await eth.GetEthHistory();
        }
    }
}