using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GDAXSharp.Network.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace gdaxApi.Controllers
{
    //[Produces("application/json")]
    [Route("api/[controller]")]
    public class AccountsController : Controller
    {


        // GET api/values
        /* [HttpGet]
         public async Task<IEnumerable<string>> GetAsync()
         {
             var authenticator = new Authenticator("b1978893dac403ead842956ebb4bc697", "NLm1+uyZ4gsCUj0M4zANMCHnROVC+x78XqKFqkumioIQWGrge4UtB5xbq3upTul4SqVu5zmBhqNdGLHsD8a1/A==", "JITA");

             var gdaxClient = new GDAXSharp.GDAXClient(authenticator);

             var allAccounts = await gdaxClient.AccountsService.GetAllAccountsAsync();

             return new string[] { allAccounts.ToString() };
         }*/

        [HttpGet]
        public async Task<string[]> GetAsync()
        {
            var authenticator = new Authenticator(apiKey, secret, passphrase);
            var gdaxClient = new GDAXSharp.GDAXClient(authenticator);
            dynamic ethTicker = await gdaxClient.ProductsService.GetProductTickerAsync(GDAXSharp.Shared.Types.ProductType.EthUsd);
            dynamic btcTicker = await gdaxClient.ProductsService.GetProductTickerAsync(GDAXSharp.Shared.Types.ProductType.BtcUsd);
            dynamic ltcTicker = await gdaxClient.ProductsService.GetProductTickerAsync(GDAXSharp.Shared.Types.ProductType.LtcUsd);
            var i = 0;

            //string b = allAccounts[1].ToString();
            return new string[] {ethTicker.Price.ToString(), btcTicker.Price.ToString(), ltcTicker.Price.ToString() };
        }

    }
}