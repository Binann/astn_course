using MongoDB.Bson.Serialization.Attributes;

namespace astn_course.Model
{
    [BsonIgnoreExtraElements]
    public class MajorModel
    {
        [BsonId]
        public string id { get; set; }
        public string name { get; set; }    
        public bool delete { get; set; }
        public string image { get;set; }

    }
}
