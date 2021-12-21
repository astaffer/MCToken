# MastercardApi.Client.Model.PushMethod

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The push method type corresponding to the URI supported by the Token Requestor. The array is absent if the Token Requestor does not support MDES Token Connect. __Max Length:__ 32 Possible values are:  * \&quot;ANDROID\&quot;: The URI is an Android app intent.  * \&quot;IOS\&quot;: The URI is an iOS app intent.  * \&quot;WEB\&quot;: The URI is a browser URL.  | 
**Uri** | **string** | The URI to open the Token Requestor&#39;s application or website. Please refer to the Issuer Interface Implementation Guide for the detail of how to send the data to the Token Requestor. __Max Length:__ 128  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

