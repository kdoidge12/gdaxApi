using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gdaxApi.Model
{
    public class Litecoin
    {
        public string coinName = "ETH";
        public Client user = new Client();
        public class ltcHistoryDTO
        {
            public decimal close { get; set; }
            public DateTime time { get; set; }

        }

        public async Task<string> GetEthTickerAsync()
        {
            dynamic ltcTicker = await user.gdaxClient.ProductsService.GetProductTickerAsync(GDAXSharp.Shared.Types.ProductType.LtcUsd);
            return ltcTicker.Price.ToString();
        }

        public async Task<List<ltcHistoryDTO>> GetEthHistory()
        {
            List<ltcHistoryDTO> dto = new List<ltcHistoryDTO>();
            dynamic ethHistory = await user.gdaxClient.ProductsService.GetHistoricRatesAsync(GDAXSharp.Shared.Types.ProductType.LtcUsd, DateTime.UtcNow, DateTime.UtcNow, GDAXSharp.Services.Products.Types.CandleGranularity.Hour1);
            foreach (var x in ethHistory)
            {
                ltcHistoryDTO temp = new ltcHistoryDTO();
                temp.close = x.Close;
                temp.time = x.Time;
                dto.Add(temp);
            }
            return dto;
        }
    }
}
