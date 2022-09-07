# IO.Swagger.Api._Api

All URIs are relative to *https://whatsgate.ru/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetMediaPost**](_Api.md#getmediapost) | **POST** /get-media | Возвращает объект медиафайла, прикрепленного к сообщению

<a name="getmediapost"></a>
# **GetMediaPost**
> InlineResponse2003 GetMediaPost (GetmediaBody body)

Возвращает объект медиафайла, прикрепленного к сообщению

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetMediaPostExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new _Api();
            var body = new GetmediaBody(); // GetmediaBody | Запрашивает и возвращает медиа-файл, прикрепленный к сообщению по идентификатору mediaKey.

            try
            {
                // Возвращает объект медиафайла, прикрепленного к сообщению
                InlineResponse2003 result = apiInstance.GetMediaPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling _Api.GetMediaPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GetmediaBody**](GetmediaBody.md)| Запрашивает и возвращает медиа-файл, прикрепленный к сообщению по идентификатору mediaKey. | 

### Return type

[**InlineResponse2003**](InlineResponse2003.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
