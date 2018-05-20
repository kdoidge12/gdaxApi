
using System.Threading.Tasks;
using gdaxApi.Model;
using Microsoft.AspNetCore.Mvc;

namespace gdaxApi.Controllers
{
    [Route("api/[controller]")]
    public class AccController : Controller
    {
        public Account acc = new Account();
        [Route("/AccHistory")]
        [HttpGet]
        public async Task<string> getAccountHistory()
        {
            return await acc.history();
        }
    }
}