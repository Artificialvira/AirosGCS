using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissionPlanner
{
    public class documents
    {
        public ObjectId _id { get; set; }
        public double? lattitude { get; set; }
        public double longitude { get; set; }
        public string message { get; set; }
    }
}
