﻿using System;
using MongoDB.Bson;

namespace Egghead.MongoDbStorage.Advertisements
{
    public class MongoDbAdvertisementViewsCount
    {
        public MongoDbAdvertisementViewsCount()
        {
            Id = ObjectId.GenerateNewId();
            //Create indeces
        }
        
        public string Email { get; set; }
        public string NormalizedEmail { get; set; }
        public ObjectId Id { get; set; }    
        public ObjectId AdsId { get; set; }  
        public DateTime CreatedAt { get; set; }      
        public DateTime UdpatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
    }
}