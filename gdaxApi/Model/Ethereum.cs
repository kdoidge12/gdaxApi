using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gdaxApi.Model
{
    public class Ethereum
    {
        public string coinName = "ETH";
        public Client user = new Client();
        public class ethHistoryDTO
        {
            public decimal close { get; set; }
            public DateTime time { get; set; }

        }

        public async Task<string> GetEthTickerAsync()
        {
            dynamic ethTicker = await user.gdaxClient.ProductsService.GetProductTickerAsync(GDAXSharp.Shared.Types.ProductType.EthUsd);
            return ethTicker.Price.ToString();
        }

        public async Task<List<ethHistoryDTO>> GetEthHistory()
        {
            List<ethHistoryDTO> dto = new List<ethHistoryDTO>();
            dynamic ethHistory = await user.gdaxClient.ProductsService.GetHistoricRatesAsync(GDAXSharp.Shared.Types.ProductType.EthUsd, DateTime.UtcNow, DateTime.UtcNow, GDAXSharp.Services.Products.Types.CandleGranularity.Hour1);
            foreach (var x in ethHistory)
            {
                ethHistoryDTO temp = new ethHistoryDTO();
                temp.close = x.Close;
                temp.time = x.Time;
                dto.Add(temp);
            }
            return dto;
        }
    }
}
