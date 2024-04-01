using MongoDB.Bson.Serialization.Attributes;

namespace astn_course.Model
{
    [BsonIgnoreExtraElements]
    public class LessonModel
    {
        [BsonId]
        public string id { get; set; }  
        public string name { get; set; }
        public int type { get; set; }
        public string video {  get; set; }
        public string course_id { get; set; }
        public string describe { get; set; }
        public List<string> listFile { get; set; }

    }
}
