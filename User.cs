using System.ComponentModel.DataAnnotations;

namespace MajorProject2022
{
    public class User
    {
        [Key] //This makes the Id field known as a primary key, it also makes the Id increment by one each time
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}