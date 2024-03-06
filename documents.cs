using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace MissionPlanner
{
    public class documents
    {
        [BsonId]
        public ObjectId _id { get; set; }
        public double? lattitude { get; set; }
        public double longitude { get; set; }
       
        public string message { get; set; }
    }
}
