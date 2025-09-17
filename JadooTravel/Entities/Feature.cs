using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace JadooTravel.Entities
{
    public class Feature
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string FeatureId { get; set; }
        public string Tittle { get; set; }
        public string MainTittle { get; set; }
        public string Description { get; set; }
        public string VideoUrl { get; set; }
    }
}
