Desired fields with the cloud events schema:
{
  "source": "/subscriptions/{subscription-id}/resourceGroups/{resource-group}/providers/Microsoft.ApiManagement/service/{resource-instance}",
  "subject": "/users/{user-name}",
  "type": "Microsoft.ApiManagement.UserCreated",
  "time": "2021-07-02T00:47:47.8237532Z",
  "id": "92c502f2-a966-42a7-a428-d3b319844544",
  "data": {
    "resourceUri": "/subscriptions/{subscription-id}/resourceGroups/{resource-group}/providers/Microsoft.ApiManagement/service/{resource-instance}/users/{user-name}"
  },
  "specversion": "1.0"
}

Desired fields with the event grid schema:
{
  "id": "92c502f2-a966-42a7-a428-d3b319844544",
  "topic": "/subscriptions/{subscription-id}/resourceGroups/{resource-group}/providers/Microsoft.ApiManagement/service/{resource-instance}",
  "subject": "/users/{user-name}",
  "data": {
    "resourceUri": "/subscriptions/{subscription-id}/resourceGroups/{resource-group}/providers/Microsoft.ApiManagement/service/{resource-instance}/users/{user-name}"
  },
  "eventType": "Microsoft.ApiManagement.UserCreated",
  "dataVersion": "1",
  "metadataVersion": "1",
  "eventTime": "2021-07-02T00:47:47.8237532Z"
}

Desired variables:
- {subscription-id} random guid
- {resource-group} random words in lowercase
- {resource-instance} random words in lowercase
- {user-name} random words in lowercase