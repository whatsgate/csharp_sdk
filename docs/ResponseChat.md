# IO.Swagger.Model.ResponseChat
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Идентификатор контакта или группы в формате WhatsApp | [optional] 
**Name** | **string** | Имя контакта или группы | [optional] 
**IsGroup** | **bool?** | Является ли чат контактом или группой | [optional] 
**IsReadOnly** | **bool?** | Является ли чат ReadOnly | [optional] 
**UnreadCount** | **int?** | Количество непрочитанных сообщений в чате | [optional] 
**Timestamp** | **int?** | Время последней активночти в чате | [optional] 
**Pinned** | **bool?** | Является ли чат закрепленным | [optional] 
**IsMuted** | **bool?** | Выключен ли у чата звук | [optional] 
**MuteExpiration** | **bool?** | Время, оставшееся до включения звука | [optional] 
**GroupMetadata** | [**ResponseChatGroupMetadata**](ResponseChatGroupMetadata.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

