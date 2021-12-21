# MastercardApi.Client.Api.GetAssetsApi

All URIs are relative to *https://api.mastercard.com/mdes*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAsset**](GetAssetsApi.md#getasset) | **GET** /issuer-assets/1/0/asset/tokenrequestor/{AssetId} | Retrieve static Assets from MDES&#39;s repository, such as Token Requestors&#39; logos


<a name="getasset"></a>
# **GetAsset**
> AssetResponse GetAsset (string assetId)

Retrieve static Assets from MDES's repository, such as Token Requestors' logos

This API is used to retrieve static Assets from MDES repository, such as the Token Requestor logo. Every Asset in the repository is referenced using an Asset ID. Once an Asset has been assigned to an Asset ID, the contents of the Asset will not change. If contents needs to change (for example, Token Requestor has supplied new artwork), they will be updated in the repository and be assigned a new Asset ID. Different types of Assets are supported in the repository, such as images and text files; for each type of Asset, multiple formats may be supported. For example, a single image asset may be supported in various file formats, or variant sizes. This allows the Issuer to select the most appropriate format to use for a particular target. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MastercardApi.Client.Api;
using MastercardApi.Client.Client;
using MastercardApi.Client.Model;

namespace Example
{
    public class GetAssetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mastercard.com/mdes";
            var apiInstance = new GetAssetsApi(config);
            var assetId = 554dbc44-496a-4896-b41c-dd431e25d5e4;  // string | An Asset ID corresponding to an individual Digital Asset. The Asset ID itself is supplied as a Get request in the form of https://{ENVIRONMENT URL GOES HERE}/mdes/issuer-assets/static/TODO/asset/tokenrequestor/{AssetID}. The Asset ID of a Token Requestor is returned as part of the Token Requestor Data from the getEligibleTokenRequestors Response. 

            try
            {
                // Retrieve static Assets from MDES's repository, such as Token Requestors' logos
                AssetResponse result = apiInstance.GetAsset(assetId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GetAssetsApi.GetAsset: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assetId** | **string**| An Asset ID corresponding to an individual Digital Asset. The Asset ID itself is supplied as a Get request in the form of https://{ENVIRONMENT URL GOES HERE}/mdes/issuer-assets/static/TODO/asset/tokenrequestor/{AssetID}. The Asset ID of a Token Requestor is returned as part of the Token Requestor Data from the getEligibleTokenRequestors Response.  | 

### Return type

[**AssetResponse**](AssetResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The call succeeded. See payload for details. |  -  |
| **0** | An error occurred. See payload for details. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

