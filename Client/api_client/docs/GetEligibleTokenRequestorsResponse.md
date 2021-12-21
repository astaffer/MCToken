# MastercardApi.Client.Model.GetEligibleTokenRequestorsResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ResponseId** | **string** | Unique identifier for the response matching the requestId supplied in the request. __Max Length:__ 64  | 
**TokenRequestors** | [**List&lt;TokenRequestor&gt;**](TokenRequestor.md) | The array of Token Requestors that are eligible for the account ranges in the request. __Conditional.__ Required if the operation was successful.  | [optional] 
**Errors** | [**List&lt;Error&gt;**](Error.md) | Element encapsulating a collection of errors that occurred during a single request. __Conditional.__ Required if one or more errors occurred while performing the operation. Not present if the operation was successful.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

