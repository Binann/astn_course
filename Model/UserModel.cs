﻿using MongoDB.Bson.Serialization.Attributes;

namespace astn_course.Model
{
    [BsonIgnoreExtraElements]
    public class UserModel
    {
        [BsonId]
        public string id {  get; set; }

        public string full_name 
        { 
            get { return first_name + " " + last_name; }
        }

        public string last_name { get; set; }
        public string first_name { get; set; }
        public bool active { get; set; }
        public bool delete { get; set; }
        public string email { get;set; }
        public string password { get; set; }
        // 1 la admin, 0 student, 2 instructor
        public int role { get; set; }
        public string department { get; set; }  
        public long date_create { get; set; }   
        public string avatar { get; set; }
        public string team_id { get; set; } 
        public List<string> listClassCourse { get; set; }

    }
}