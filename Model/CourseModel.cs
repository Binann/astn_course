using MongoDB.Bson.Serialization.Attributes;

namespace astn_course.Model
{
    [BsonIgnoreExtraElements]
    public class CourseModel
    {
        [BsonId]
        public string id { get; set; }
        public string name { get; set; }
        public string image {  get; set; }
        public string category_id {  get; set; }   
        public string major_id {  get; set; }
        public string describe { get; set; }
        public string time {  get; set; }   
        public int lesson { get; set; }
        public int learner { get; set; }
        public long date_create { get; set; }
        public bool delete { get; set; }
        public string teacher { get; set; }
        public string creator { get; set; } 
    }
}
