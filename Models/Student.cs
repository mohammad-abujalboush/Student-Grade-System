using System.ComponentModel.DataAnnotations;


namespace StudentGradeBookSystem.Models
{
    public class Student
    {
        [Key]
        [Required]
        [MaxLength(9)]
        [RegularExpression("[0-9]+")]
        public string Id { get; set; }
        [RegularExpression("[a-z A-Z]+")]
        public string Name { get; set; }
        [RegularExpression("[a-z A-Z0-9]+")]
        public string CourseTitle { get; set; }
        [Range(0, 30)]
        public int? AssignmentGrade { get; set; }
        [Range(0, 30)]       
        public int? MidTermGrade { get; set; }
        [Range(0, 40)]        
        public int? FinalGrade { get; set; }
        public double? Total { get { return AssignmentGrade + MidTermGrade + FinalGrade; } }


    }
}
