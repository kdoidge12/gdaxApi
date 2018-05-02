using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gdaxApi.Model
{
    public class Bitcoin
    {
        public decimal currentPrice = 0;
        public string coinName = "BTC";
        public Client user = new Client();

        public async Task<string> GetBtcTickerAsync()
        {
            dynamic btcTicker = await user.gdaxClient.ProductsService.GetProductTickerAsync(GDAXSharp.Shared.Types.ProductType.BtcUsd);
            return btcTicker.Price.ToString();
        }
    }
}
