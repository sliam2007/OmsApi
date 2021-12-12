# OmsApi

## Requirements

- Visual Studio 2019 16.8 or later with the ASP.NET and web development workload
- .Net 5.0 SDK

## URL
```sh
http://<server-name>[:server-port]/api/v2/orders
```

## Method
POST

## Content-Type
application/json

## Valid omsId values
- 0645848
- 0258963
- 0158663

## Valid omsId/clientToken pairs
- 0645848 / 1cecc8fb-fb47-4c8a-af3d-d34c1ead8c4f
- 0258963 / 1fa7d94a-9c3f-4af6-9924-2ddd0f93353e
- 0158663 / 41062f80-8fb3-406b-8f9a-4a89035d0fa7

## Sample of CURL REST query
```sh
curl -X POST -H 'Content-Type: application/json' -H 'clientToken: 1cecc8fb-fb47-4c8a-af3d-d34c1ead8c4f' http://<server-name>[:server-port]/api/v2/orders --data ' {
  "omsId": "0645848",
  "products": [
    {
      "gtin": "01334567894339",
      "quantity": 3,      
      "serialNumberType": "SELF_MADE",
      "serialNumbers": [
        "XT6c84e",
        "2kY39Om",
        "X4ebssJ"
      ],
      "templateId": "3"
    }
  ]
}'
```
## Sample of JSON response
```sh
{
    "omsId": "0645848",
    "orderId": "9c5a10f6-3b7e-4761-bb72-4bb7b7796250",
    "expectedCompletionTime": 940
}
```
