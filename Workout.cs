using System.ComponentModel.DataAnnotations;

namespace MajorProject2022
{
    public class Workout
    {
        [Key] //This makes the Id field known as a primary key, it also makes the Id increment by one each time
        public int Id { get; set; }
        public string Title { get; set; }
        public string Duration { get; set; }
        public string Description { get; set; }
        public int UserID { get; set; } //This is the foreign key, used to differentiate between user's workouts
        public string Date { get; set; } //Saves the date the workout was added
    }
}