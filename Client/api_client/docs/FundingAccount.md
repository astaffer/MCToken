# MastercardApi.Client.Model.FundingAccount

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CardAccountData** | [**CardAccount**](CardAccount.md) |  | [optional] 
**FinancialAccountData** | [**FinancialAccount**](FinancialAccount.md) |  | [optional] 
**AccountHolderData** | [**AccountHolder**](AccountHolder.md) |  | [optional] 
**DataValidUntilTimestamp** | **string** | The date/time after which this encrypted payload object is considered invalid. If present, all systems must reject this encrypted object after this time and treat it as invalid data. Must be a value no more than 30 days in the future. Mastercard recommends using a value of (CurrentTime + 30 minutes). __Max length:__ 29. Must be expressed in ISO 8601 extended format as one of the following: * YYYY-MM-DDThh:mm:ss[.sss]Z * YYYY-MM-DDThh:mm:ss[.sss]±hh:mm where [.sss] is optional and can be 1 to 3 digits.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

