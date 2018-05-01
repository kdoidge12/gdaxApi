using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GDAXSharp.Network.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace gdaxApi.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        //PassPhrase  JITA
        // API Key b1978893dac403ead842956ebb4bc697
        // Secret NLm1+uyZ4gsCUj0M4zANMCHnROVC+x78XqKFqkumioIQWGrge4UtB5xbq3upTul4SqVu5zmBhqNdGLHsD8a1/A==

        // GET api/values
       /* [HttpGet]
        public async Task<IEnumerable<string>> GetAsync()
        {
            var authenticator = new Authenticator("b1978893dac403ead842956ebb4bc697", "NLm1+uyZ4gsCUj0M4zANMCHnROVC+x78XqKFqkumioIQWGrge4UtB5xbq3upTul4SqVu5zmBhqNdGLHsD8a1/A==", "JITA");

            var gdaxClient = new GDAXSharp.GDAXClient(authenticator);

            var allAccounts = await gdaxClient.AccountsService.GetAllAccountsAsync();

            return new string[] { allAccounts.ToString() };
        }*/
        // GET api/values
        [HttpGet]
        public string [] Get()
        {
            return new string []{ "value1","value2"};
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
