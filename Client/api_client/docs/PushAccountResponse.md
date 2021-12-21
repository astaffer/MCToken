# MastercardApi.Client.Model.PushAccountResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ResponseId** | **string** | Unique identifier for the response matching the requestId supplied in the request.  __Max Length:__ 64  | 
**PushAccountReceipt** | **string** | Receipt value to be passed to the Token Requestor. The pushAccountReceipt represents the pushed account details and expires after 15 minutes. __Conditional.__ Required if the push operation was successful. Not present otherwise. __Max Length:__ 64 characters. When valid, the receipt will consist of a 3-character prefix identifying the product associated to the funding account concatenated with a universally unique identifier, in the form prefix-UUID. The prefix is needed by some Token Requestors in preparation of performing a tokenization. Prefix values are:  * MCC: Mastercard Credit  * DMC: Mastercard Debit  * MSI: Maestro  * PVL: Private Label  | [optional] 
**AvailablePushMethods** | [**List&lt;PushMethod&gt;**](PushMethod.md) | Array of push methods supported by the Token Requestor. __Conditional.__ Required if the push operation was successful. Not present otherwise.  | [optional] 
**Errors** | [**List&lt;Error&gt;**](Error.md) | Element encapsulating a collection of errors that occurred during a single request. __Conditional.__ Required if one or more errors occurred while performing the operation. Not present if the operation was successful.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

