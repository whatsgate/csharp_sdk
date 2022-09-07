# IO.Swagger.Api.DefaultApi

All URIs are relative to *https://whatsgate.ru/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CheckPost**](DefaultApi.md#checkpost) | **POST** /check | Проверка зарегистрирован ли номер в WhatsApp
[**GetChatsPost**](DefaultApi.md#getchatspost) | **POST** /get-chats | Возвращает список активных чатов
[**SeenPost**](DefaultApi.md#seenpost) | **POST** /seen | Отправляет команду в чат, что последние сообщения просмотрены
[**SendMessage**](DefaultApi.md#sendmessage) | **POST** /send | Отправка сообщения

<a name="checkpost"></a>
# **CheckPost**
> InlineResponse2001 CheckPost (CheckBody body)

Проверка зарегистрирован ли номер в WhatsApp

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CheckPostExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new DefaultApi();
            var body = new CheckBody(); // CheckBody | Проверяет, зарегистрирован ли указанный номер в WhatsApp. Номер указывается в формате только цифр, например 79999999999

            try
            {
                // Проверка зарегистрирован ли номер в WhatsApp
                InlineResponse2001 result = apiInstance.CheckPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.CheckPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CheckBody**](CheckBody.md)| Проверяет, зарегистрирован ли указанный номер в WhatsApp. Номер указывается в формате только цифр, например 79999999999 | 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getchatspost"></a>
# **GetChatsPost**
> InlineResponse2002 GetChatsPost (GetchatsBody body)

Возвращает список активных чатов

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetChatsPostExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new DefaultApi();
            var body = new GetchatsBody(); // GetchatsBody | Запрашивает и возвращает список активных чатов, включая контакты и группы. В объекте группы находится идентификатор группы, список всех участников группы, права участников (является ли участник администратором группы).

            try
            {
                // Возвращает список активных чатов
                InlineResponse2002 result = apiInstance.GetChatsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetChatsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GetchatsBody**](GetchatsBody.md)| Запрашивает и возвращает список активных чатов, включая контакты и группы. В объекте группы находится идентификатор группы, список всех участников группы, права участников (является ли участник администратором группы). | 

### Return type

[**InlineResponse2002**](InlineResponse2002.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="seenpost"></a>
# **SeenPost**
> InlineResponse2004 SeenPost (SeenBody body)

Отправляет команду в чат, что последние сообщения просмотрены

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SeenPostExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new DefaultApi();
            var body = new SeenBody(); // SeenBody | Команда устанавливает у всех сообщений в указанном чате статус просмотрены.

            try
            {
                // Отправляет команду в чат, что последние сообщения просмотрены
                InlineResponse2004 result = apiInstance.SeenPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.SeenPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SeenBody**](SeenBody.md)| Команда устанавливает у всех сообщений в указанном чате статус просмотрены. | 

### Return type

[**InlineResponse2004**](InlineResponse2004.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="sendmessage"></a>
# **SendMessage**
> InlineResponse200 SendMessage (SendBody body)

Отправка сообщения

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SendMessageExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new DefaultApi();
            var body = new SendBody(); // SendBody | Отправляет текстовое или мультимедийное сообщение контакту либо группе. Может использоваться синхронно (возвращает ответ после отправки сообщения, ответ содержит объект отправленного сообщения с идентификатором), либо асинхронно (ответ содержит результат постановки в очередь, а отправленное сообщение приходит на указанный webhook). По умолчанию используется асинхронная отправка.

            try
            {
                // Отправка сообщения
                InlineResponse200 result = apiInstance.SendMessage(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.SendMessage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SendBody**](SendBody.md)| Отправляет текстовое или мультимедийное сообщение контакту либо группе. Может использоваться синхронно (возвращает ответ после отправки сообщения, ответ содержит объект отправленного сообщения с идентификатором), либо асинхронно (ответ содержит результат постановки в очередь, а отправленное сообщение приходит на указанный webhook). По умолчанию используется асинхронная отправка. | 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
