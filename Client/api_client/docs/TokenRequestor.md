# MastercardApi.Client.Model.TokenRequestor
The information that MDES returns for each Token Requestor, when it is enabled for at least one of the Issuer's input account range

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TokenRequestorId** | **string** | Identifies the Token Requestor where the Account must be pushed to. The string contains a 11-digit numeric value. __Length:__ 11  | 
**Name** | **string** | The legal name of the Token Requestor. __Max Length:__ 64  | 
**ConsumerFacingEntityName** | **string** | The name of the Token Requestor to be displayed to the account holder. __Max Length:__ 100  | 
**ImageAssetId** | **string** | The image of the Token Requestor (for instance a logo). Provided as an Asset ID – use the Get Asset API to retrieve the actual asset. __Max Length:__ 64  | [optional] 
**TokenRequestorType** | **string** | The type of the Token Requestor. __Max Length:__ 32. Must be either:  * MERCHANT: The Token Requestor is a Merchant  * WALLET: The Token Requestor is a Wallet or a Commerce Platform  | 
**WalletId** | **string** | The identifier of the Wallet Provider. __Length:__ 3 __Conditional,__ Only present when the token is provided to a Wallet Provider. Not present otherwise.  | [optional] 
**EnabledAccountRanges** | **List&lt;long&gt;** | Array of account range start numbers that are enabled for the Token Requestor.The start numbers will be 19 digits in length.  | 
**SupportedPushMethods** | **List&lt;string&gt;** | Array of the push methods supported by the Token Requestor. __Conditional__. The array is not returned if the Token Requestor does not participate in MDES Token Connect Program. Possible push methods are:  * ANDROID: The Token Requestor supports app-to-app and web-to-app communication on Android.  * IOS: The Token Requestor supports app-to-app and web-to-app communication on iOS.  * WEB: The Token Requestor supports web-to-web or app-to-web communication.  | [optional] 
**SupportsMultiplePushedCards** | **bool** | Flag to indicate if Token Requestor supports multiple push account receipts in a single request. When supported, a maximum of 5 receipts may be sent to the Token Requestor in a single request __Conditional__. Must be present if the Token Requestor participates in MDES Token Connect program, not present otherwise. Must be either :  * true: Multiple push receipts are supported.  * false: Multiple push receipts are not supported.  | [optional] 
**SupportedAccountHolderData** | **List&lt;string&gt;** | List (array) of account holder data elements that the Token Requestor accepts to receive from the Issuer with a pushed card or account. __Conditional__. The array is not returned if the Token Requestor does not participate in MDES Token Connect Program. If the Token Requestor participates in MDES Token Connect but doesn&#39;t accept any account holder data then an empty array is returned. __To ensure forward-compatibility, all API client implementations must be resilient to new data element values being added to responses from MDES.__ Possible values are:  * \&quot;NAME\&quot;: The first name and last name of the account holder  * \&quot;ADDRESS\&quot;: The billing address for the account holder  * \&quot;EMAIL_ADDRESS\&quot;: The email address for the account holder  * \&quot;MOBILE_PHONE_NUMBER\&quot;: The mobile phone number for the account holder  | [optional] 
**SupportsCardHolderAuthentication** | **bool** | Flag to indicate if token requestor supports cardholder authentication after the token is activated. Must be one of:   * true - Post Tokenization Carholder Authentication (Consent Service) is supported.   * false - Post Tokenization Carholder Authentication (Consent Service) is not supported.  | [optional] 
**SupportsTokenConnect** | **bool** | A boolean parameter indicate that token requestor supports Token Connect or not. Must be one of: * true - Token Connect is supported * false - Token Connect is not supported  | [optional] 
**AvailablePushMethods** | [**List&lt;PushMethod&gt;**](PushMethod.md) | Array of push methods supported by the token requestor. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

