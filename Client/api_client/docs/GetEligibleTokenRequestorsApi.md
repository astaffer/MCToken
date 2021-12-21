# MastercardApi.Client.Api.GetEligibleTokenRequestorsApi

All URIs are relative to *https://api.mastercard.com/mdes*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetEligibleTokenRequestors**](GetEligibleTokenRequestorsApi.md#geteligibletokenrequestors) | **POST** /connect/1/0/getEligibleTokenRequestors | Retrieve information about Token Requestors that have been enabled for one or more of the issuer&#39;s account ranges


<a name="geteligibletokenrequestors"></a>
# **GetEligibleTokenRequestors**
> GetEligibleTokenRequestorsResponse GetEligibleTokenRequestors (GetEligibleTokenRequestorsRequest getEligibleTokenRequestorsRequest = null)

Retrieve information about Token Requestors that have been enabled for one or more of the issuer's account ranges

This API is used to retrieve information about Token Requestors that have been enabled for one or more of the Issuer's account ranges. The information returned is cached by Issuer back-end servers. The Issuer typically uses this information to present to their cardholders the list of available Token Requestors they can push their card (or account) to, both for web-based and app-based user interfaces. Note: all Token Requestors enabled for the account range(s) are returned, regardless whether they support MDES Token Connect or not. The Issuer can easily determine from the response the Token Requestors that support the MDES Token Connect framework. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MastercardApi.Client.Api;
using MastercardApi.Client.Client;
using MastercardApi.Client.Model;

namespace Example
{
    public class GetEligibleTokenRequestorsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mastercard.com/mdes";
            var apiInstance = new GetEligibleTokenRequestorsApi(config);
            var getEligibleTokenRequestorsRequest = new GetEligibleTokenRequestorsRequest(); // GetEligibleTokenRequestorsRequest | Contains the details of the request message. (optional) 

            try
            {
                // Retrieve information about Token Requestors that have been enabled for one or more of the issuer's account ranges
                GetEligibleTokenRequestorsResponse result = apiInstance.GetEligibleTokenRequestors(getEligibleTokenRequestorsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GetEligibleTokenRequestorsApi.GetEligibleTokenRequestors: " + e.Message );
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
 **getEligibleTokenRequestorsRequest** | [**GetEligibleTokenRequestorsRequest**](GetEligibleTokenRequestorsRequest.md)| Contains the details of the request message. | [optional] 

### Return type

[**GetEligibleTokenRequestorsResponse**](GetEligibleTokenRequestorsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The call succeeded. See payload for details. |  -  |
| **0** | An error occurred. See payload for details. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

