using Mastercard.Developer.ClientEncryption.Core.Encryption;
using Mastercard.Developer.ClientEncryption.Core.Utils;
using Mastercard.Developer.OAuth1Signer.Core.Utils;
using Mastercard.Developer.OAuth1Signer.RestSharpV2.Signers;
using MastercardApi.Client.Api;
using MastercardApi.Client.Client;
using MastercardApi.Client.Model;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using static Mastercard.Developer.ClientEncryption.Core.Encryption.FieldLevelEncryptionConfig;

namespace MCToken.Clients
{
    public class McClient :IMcClient
    {
        private  ApiClient _apiClient;
        const string basePath = "https://sandbox.api.mastercard.com/mdes";
        const string consumerKey = "Xw_gPoamJ5CLIa8fxk5hDb1J_J1bUEjD0iKG_B29ab6eb0aa!3925c742c57d4391a0e909e60476a4440000000000000000";
        public McClient()
        {
             var signingKey = AuthenticationUtils.LoadSigningKey(
                 @"C:\Users\Pablo\source\repos\MCToken\keys\mkb-mastercard-sandbox.p12",
                    "keyalias",
                    "keystorepassword",
                    X509KeyStorageFlags.MachineKeySet | X509KeyStorageFlags.Exportable
                );
            var decryptionKey = EncryptionUtils.LoadDecryptionKey(
                                    @"C:\Users\Pablo\source\repos\MCToken\keys\mkb-mastercard-sandbox.p12",
                    "keyalias",
                    "keystorepassword");
             
            var encCertificate = EncryptionUtils.LoadEncryptionCertificate(@"C:\Users\Pablo\source\repos\MCToken\keys\token-connect-request-encryption-sandbox.crt");
            //       var config = FieldLevelEncryptionConfigBuilder.AFieldLevelEncryptionConfig()
            //.WithEncryptionPath("$.fundingAccountInfo.encryptedPayload.encryptedData", "$.fundingAccountInfo.encryptedPayload")
            //.WithEncryptionPath("$.encryptedPayload.encryptedData", "$.encryptedPayload")
            //.WithDecryptionPath("$.tokenDetail", "$.tokenDetail.encryptedData")
            //.WithDecryptionPath("$.encryptedPayload", "$.encryptedPayload.encryptedData")
            //.WithEncryptionCertificate(encCertificate)
            //.WithDecryptionKey(decryptionKey)
            //.WithOaepPaddingDigestAlgorithm("SHA-512")
            //.WithEncryptedValueFieldName("encryptedData")
            //.WithEncryptedKeyFieldName("encryptedKey")
            //.WithIvFieldName("iv")
            //.WithOaepPaddingDigestAlgorithmFieldName("oaepHashingAlgorithm")
            //.WithEncryptionCertificateFingerprintFieldName("publicKeyFingerprint")
            //.WithValueEncoding(FieldValueEncoding.Hex)
            //.Build();
            var config= FieldLevelEncryptionConfigBuilder.AFieldLevelEncryptionConfig()
                .WithEncryptionPath("$.pushFundingAccount.encryptedPayload.encryptedData", "$.pushFundingAccount.encryptedPayload")
    .WithEncryptionCertificate(encCertificate)
    .WithOaepPaddingDigestAlgorithm("SHA-512")
    .WithEncryptedValueFieldName("encryptedData")
    .WithEncryptedKeyFieldName("encryptedKey")
    .WithIvFieldName("iv")
    .WithOaepPaddingDigestAlgorithmFieldName("oaepHashingAlgorithm")
    .WithEncryptionCertificateFingerprintFieldName("publicKeyFingerprint")
    .WithValueEncoding(FieldValueEncoding.Hex)
    .Build();
            _config = config;
            _apiClient = new ApiClient(signingKey, basePath, consumerKey, config);
        }
        private readonly FieldLevelEncryptionConfig _config;
        public Task<AssetResponse> GetAssets(string assetId)
        {
            var client = new GetAssetsApi() { AsynchronousClient = _apiClient, Client = _apiClient };
            return client.GetAssetAsync(assetId);
        }

        public Task<GetEligibleTokenRequestorsResponse> GetEligibleTokenRequestors(GetEligibleTokenRequestorsRequest getEligibleTokenRequestorsRequest)
        {
            var client = new GetEligibleTokenRequestorsApi(basePath) { Client = _apiClient, AsynchronousClient = _apiClient};
            
            return client.GetEligibleTokenRequestorsAsync(getEligibleTokenRequestorsRequest);
        }

        public Task<PushAccountResponse> PushAccount(PushAccountRequest pushAccountRequest)
        {
            var client = new PushAccountApi() { AsynchronousClient = _apiClient, Client = _apiClient };
            return client.PushAccountAsync(pushAccountRequest);
        }

        public FieldLevelEncryptionConfig GetConfig()
        {
            return _config;
        }
    }
    
}
