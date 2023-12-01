using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Student
    {
        public Guid Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        [DataType(DataType.Date)]
        public string BirthDate { get; set; }
        public string Class { get; set; }
        public StudentGroup? Group { get; set; } 
    }
}