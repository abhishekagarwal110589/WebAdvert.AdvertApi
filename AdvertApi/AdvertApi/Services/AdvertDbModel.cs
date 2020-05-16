using AdvertApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Amazon.DynamoDBv2.DataModel;

namespace AdvertApi.Services
{
    [DynamoDBTable("Advert")]
    public class AdvertDbModel
    {
        [DynamoDBProperty]
        public string Title { get; set; }
        
        [DynamoDBProperty]
        public string Description { get; set; }
        
        [DynamoDBProperty]
        public double Price { get; set; }
        public DateTime CreationDateTime { get; set; }

        [DynamoDBHashKey]
        public string Id { get; set; }

        [DynamoDBProperty]
        public AdvertStatus Status { get; set; }
    }
}
