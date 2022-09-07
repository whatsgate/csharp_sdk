# IO.Swagger.Model.ResponseMessage
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Идентификатор сообщения | [optional] 
**Ack** | **int?** | Флаг просмотра сообщения | [optional] 
**HasMedia** | **bool?** | Флаг, имеет ли сообщение медиафайл | [optional] 
**MediaKey** | **string** | Ключ медиафайла (при наличии) | [optional] 
**Body** | **string** | Текст сообщения | [optional] 
**Type** | **string** | Тип сообщения | [optional] 
**Timestamp** | **int?** | Время сообщения в формате Unix Timestamp | [optional] 
**From** | **string** | Идентификатор отправителя в формате WhatsApp | [optional] 
**To** | **string** | Идентификатор получателя в формате WhatsApp | [optional] 
**IsForwarded** | **bool?** | Флаг, было ли сообщение перенаправлено | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

