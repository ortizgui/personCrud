using System.Collections.Generic;
using System.Threading.Tasks;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;
using Person.Domain.Dtos.Repositories;
using Person.Domain.Repositories;

namespace Person.Infrastructure.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly IAmazonDynamoDB _amazonDynamoDb;
        private readonly AmazonDynamoDBClient _client;
        private readonly string _tableName;

        public PersonRepository(IAmazonDynamoDB amazonDynamoDb)
        {
            _amazonDynamoDb = amazonDynamoDb;
            _client = new AmazonDynamoDBClient();
            _tableName = "PersonTable";
        }      
        
        public async Task SavePerson(SavePersonRepositoryDto personProfile)
        {
            var request = new PutItemRequest
            {
                TableName = _tableName,
                Item = new Dictionary<string, AttributeValue>
                {
                    {"FirstName", new AttributeValue {S = personProfile.FirstName}},
                    {"LastName", new AttributeValue {S = personProfile.LastName}},
                    {"DocumentId", new AttributeValue {S = personProfile.DocumentId}},
                    {"Birthdate", new AttributeValue {S = personProfile.Birthdate.ToString()}}
                }
            };

            await _amazonDynamoDb.PutItemAsync(request);
        }
    }
}