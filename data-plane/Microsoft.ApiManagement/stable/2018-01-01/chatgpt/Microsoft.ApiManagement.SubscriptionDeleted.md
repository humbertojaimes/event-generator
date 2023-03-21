Desired fields with the cloud events schema:
{
  "source": "/subscriptions/{subscription-id}/resourceGroups/{resource-group}/providers/Microsoft.ApiManagement/service/{resource-instance}",
  "subject": "/subscriptions/{subscription-id}",
  "type": "Microsoft.ApiManagement.SubscriptionDeleted",
  "time": "2021-07-02T00:47:47.8536532Z",
  "id": "831e1650-001e-001b-66ab-eeb76e069631",
  "data": {
    "resourceUri": "/subscriptions/{subscription-id}/resourceGroups/{resource-group}/providers/Microsoft.ApiManagement/service/{resource-instance}/subscriptions/{subscription-id}"
  },
  "specversion": "1.0"
}

Desired fields with the event grid schema:
{
  "id": "831e1650-001e-001b-66ab-eeb76e069631",
  "topic": "/subscriptions/{subscription-id}/resourceGroups/{resource-group}/providers/Microsoft.ApiManagement/service/{resource-instance}",
  "subject": "/subscriptions/{subscription-id}",
  "data": {
    "resourceUri": "/subscriptions/{subscription-id}/resourceGroups/{resource-group}/providers/Microsoft.ApiManagement/service/{resource-instance}/subscriptions/{subscription-id}"
  },
  "eventType": "Microsoft.ApiManagement.SubscriptionDeleted",
  "dataVersion": "1",
  "metadataVersion": "1",
  "eventTime": "2021-07-02T00:47:47.8536532Z"
}

Desired variables:
- {subscription-id} random guid
- {resource-group} random words in lowercase
- {resource-instance} random words in lowercase
- {subscription-id} random words in lowercase