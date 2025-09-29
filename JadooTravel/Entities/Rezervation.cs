using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace JadooTravel.Entities
{
    public class Rezervation
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string RezervationId { get; set; }
        public string AdSoyad { get; set; }
        public string TelNo { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
    }
}
