# MastercardApi.Client.Model.GetEligibleTokenRequestorsRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RequestId** | **string** | Unique identifier for the request.  __Max Length:__ 64  | 
**AccountRanges** | **List&lt;string&gt;** | Array of the starting numbers of the account ranges to retrieve the enabled Token Requestors for. The starting numbers are numeric strings between 9 and 19 in length.If the starting numbers are less than 19, MDES will zero pad the end of the starting numbers to 19 in length. The padded value must exactly match the account range start number enabled for the Token Requestor.  __Max Number of Items:__ 25  | 
**SupportsTokenConnect** | **bool** | A boolean parameter to receive only token requestors that support Token Connect or not. Must be one of: * true - Token Connect is supported * false - Token Connect is not supported  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

