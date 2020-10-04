## DynamoDB

### Create:
```
aws dynamodb create-table --cli-input-json file://person-table.json --endpoint-url http://localhost:4566
```

### Read:
```
aws dynamodb scan --table-name PersonTable --endpoint-url http://localhost:4566
```