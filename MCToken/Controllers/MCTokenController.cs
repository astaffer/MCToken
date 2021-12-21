using Mastercard.Developer.ClientEncryption.Core.Encryption;
using MastercardApi.Client.Model;
using MCToken.Clients;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MCToken.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MCTokenController : ControllerBase
    {

        private readonly ILogger<MCTokenController> _logger;
        private readonly IMcClient _mcClient;

        public MCTokenController(ILogger<MCTokenController> logger, IMcClient mcClient)
        {
            _logger = logger;
            _mcClient = mcClient;
        }

        [HttpGet("GetEligibleTokenRequestors")]
        public async Task<IActionResult> GetEligibleTokenRequestors()
        {
            var rid = Guid.NewGuid().ToString("N").Substring(0, 16);
            var res = await _mcClient.GetEligibleTokenRequestors(new GetEligibleTokenRequestorsRequest(
            requestId: rid, accountRanges: new List<string> { "5123456789" }, supportsTokenConnect: true));
            return Ok(res);
        }
        [HttpGet("PushAccount")]
        public async Task<IActionResult> PushAccount()
        {
            var rid = Guid.NewGuid().ToString("N").Substring(0, 16);
            var fund = new FundingAccount
                (
                    cardAccountData:  new CardAccount("5123456789012346", "12", "22"),
                    accountHolderData: new AccountHolder(

                        accountHolderAddress: new BillingAddress("100 1st Street", "Apt. 4B", "St. Louis", "MO", "61000", "USA"),
                        accountHolderEmailAddress: "john.doe@anymail.com",
                        accountHolderMobilePhoneNumber: new PhoneNumber("1", "7181234567"),
                        accountHolderName: "Doe/John"
                    ),
                    dataValidUntilTimestamp: "2021-12-18T12:09:56Z"
                );
            var acc = new PushFundingAccount(encryptedPayload:
                new EncryptedPayload
            (encryptedData:
                 fund,
                 publicKeyFingerprint: "243e6992ea467f1cbb9973facfcc3bf17b5cd007",
                 oaepHashingAlgorithm: "SHA512"
            ));
            var req = new PushAccountRequest(rid, acc, tokenRequestorId: "50123456789");
            var res = await _mcClient.PushAccount(req);
            return Ok(res);
        }
        [HttpGet("GetAsset")]
        public async Task<IActionResult> GetAsset([FromQuery]string assetId)
        {
            //554dbc44-496a-4896-b41c-dd431e25d5e4
            //dbc55444-496a-4896-b41c-5d5e2dd431e2
            var res = await _mcClient.GetAssets(assetId);
            return Ok(res);
        }
    }
}
