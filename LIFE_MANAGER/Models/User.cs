using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIFE_MANAGER.Models
{
    public class User
    {
        [BsonId]

        public ObjectId _id { get; set; }
        //[Required(ErrorMessage = "Email Required")]
        [BsonElement("Username")]
        public string Username { get; set; }
        [BsonElement("Password")]
        public string Password { get; set; }
        [BsonElement("Name")]
        public string Name { get; set; }
        [BsonElement("Date")]
        public string Date { get; set; }
        [BsonElement("Biography")]
        public string Biography { get; set; }
        public DateTime createdAt = DateTime.Now;
        public DateTime updatedAt = DateTime.Now;
        public override string ToString()
        {
            if (this != null && this.Username != null && this.Password != null)
                return "Person: " + Username + " " + Password;
            return "No user found";
        }
    }
}
