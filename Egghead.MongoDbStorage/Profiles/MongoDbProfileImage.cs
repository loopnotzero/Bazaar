﻿using System;
using MongoDB.Bson;

namespace Egghead.MongoDbStorage.Profiles
{
    public class MongoDbProfileImage
    {
        public MongoDbProfileImage()
        {
            Id = ObjectId.GenerateNewId();
            //Create indeces
        }

        public ObjectId Id { get; set; }
        public string ImagePath { get; set; }     
        public ObjectId ProfileId { get; set; }       
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
    }
}