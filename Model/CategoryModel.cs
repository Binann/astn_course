using MongoDB.Bson.Serialization.Attributes;

namespace astn_course.Model
{
    [BsonIgnoreExtraElements]
    public class CategoryModel
    {
        [BsonId]
        public string id { get;set; }
        public bool delete { get; set; }
        public string name {  get; set; }   
        public string image { get; set; }
        public string department { get; set; }
        public string description { get;set; }

    }
}
