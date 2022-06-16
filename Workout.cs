using System.ComponentModel.DataAnnotations;

namespace MajorProject2022
{
    public class Workout
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Duration { get; set; }
        public string Description { get; set; }
        public int UserID { get; set; }
        public string Date { get; set; }
    }
}