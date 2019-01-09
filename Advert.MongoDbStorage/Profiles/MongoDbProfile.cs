﻿using System;
using System.Collections.Generic;
using Advert.Common.Posts;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Advert.MongoDbStorage.Profiles
{
    public class MongoDbProfile : IProfile
    {
        public MongoDbProfile()
        {
            _id = ObjectId.GenerateNewId();
            //Create indeces
        }

        [BsonId]
        public ObjectId _id { get; set; }
             
        public bool IsDeleted { get; set; }
        public string Name { get; set; }    
        public string Email { get; set; }      
        
        public string Culture { get; set; }
        
        public string Location { get; set; }
        public string ImagePath { get; set; }   
        
        public string PhoneNumber { get; set; }        
        public string NormalizedName { get; set; }
        public string NormalizedEmail { get; set; }
        public DateTime CreatedAt { get; set; }
        
        public DateTime ChangedAt { get; set; }  
        
        public DateTime DeletedAt { get; set; }
    }
}