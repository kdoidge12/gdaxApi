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
        public class HistoryDTO
        {
            public decimal close { get; set; }
            public DateTime time { get; set; }

        }

        public async Task<string> GetBtcTickerAsync()
        {
            dynamic btcTicker = await user.gdaxClient.ProductsService.GetProductTickerAsync(GDAXSharp.Shared.Types.ProductType.BtcUsd);
            return btcTicker.Price.ToString();
        }

        public async Task<List<HistoryDTO>> GetBtcHistory()
        {
            List<HistoryDTO> dto = new List<HistoryDTO>();
            dynamic btcHistory = await user.gdaxClient.ProductsService.GetHistoricRatesAsync(GDAXSharp.Shared.Types.ProductType.BtcUsd,DateTime.UtcNow,DateTime.UtcNow,GDAXSharp.Services.Products.Types.CandleGranularity.Hour1);
            foreach(var x in btcHistory)
            {
                HistoryDTO temp = new HistoryDTO();
                temp.close = x.Close;
                temp.time = x.Time;
                dto.Add(temp);
            }
            return dto;
        }
    }
}
