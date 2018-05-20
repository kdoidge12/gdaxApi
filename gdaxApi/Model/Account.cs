using System.Threading.Tasks;
using GDAXSharp;

namespace gdaxApi.Model
{
    public class Account
    {
        public Client user = Client.Instance;
        public string id = "14269e90-b085-43d6-b83a-13dfca7d91d1";

        public async Task<string> history()
        {
            dynamic accounts = await user.gdaxClient.AccountsService.GetAllAccountsAsync();
            dynamic info = await user.gdaxClient.AccountsService.GetAccountHistoryAsync(id, 100, 10);
            dynamic btc = await user.gdaxClient.AccountsService.GetAccountByIdAsync(id);
            return info;
        }
    }
}