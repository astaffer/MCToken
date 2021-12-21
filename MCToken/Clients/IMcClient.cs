
using Mastercard.Developer.ClientEncryption.Core.Encryption;
using MastercardApi.Client.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MCToken.Clients
{
    public interface IMcClient
    {
        Task<GetEligibleTokenRequestorsResponse> GetEligibleTokenRequestors(GetEligibleTokenRequestorsRequest getEligibleTokenRequestorsRequest);
        Task<AssetResponse> GetAssets(string assetId);
        Task<PushAccountResponse> PushAccount(PushAccountRequest pushAccountRequest);
        FieldLevelEncryptionConfig GetConfig();
    }
}
