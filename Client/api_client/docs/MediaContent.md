# MastercardApi.Client.Model.MediaContent
The content of the media. When the Asset corresponds to a Token Requestor's logo, the content is a square image.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | What type of media this is. __Max Length:__ 32. Specified as a MIME type, which will be one of the following supported types:  * \&quot;application/pdf\&quot;: for images (must be a vector PDF image)  * \&quot;image/png\&quot;: includes alpha channel  * \&quot;image/svg+xml\&quot;: image in SVG format  * \&quot;text/plain\&quot;  * \&quot;text/html\&quot;  | 
**Data** | **string** | The data for this item of media. Base64-encoded data, where the decoded data is in the format as specified in ‘type&#39;.  | 
**Height** | **string** | For non-SVG image assets, the height of the image. Specified in pixels. __Max Length:__ 6.  | [optional] 
**Width** | **string** | For non-SVG image assets, the width of the image. Specified in pixels. __Max Length:__ 6.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

