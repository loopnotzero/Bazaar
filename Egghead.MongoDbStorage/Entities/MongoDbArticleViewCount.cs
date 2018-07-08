﻿using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.IdGenerators;

namespace Egghead.MongoDbStorage.Entities
{
    public class MongoDbArticleViewCount
    {
        public MongoDbArticleViewCount()
        {
            Id = ObjectId.GenerateNewId().ToString();
            //Create indeces
        }

        public string Id { get; set; }
        public string ByWho { get; set; }
        public string ByWhoNormalized { get; set; }
        public string ArticleId { get; set; }
        public DateTime AddedAt { get; set; }
    }
}