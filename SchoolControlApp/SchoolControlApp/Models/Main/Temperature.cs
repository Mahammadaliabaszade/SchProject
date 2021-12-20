using System;
using System.ComponentModel.DataAnnotations;

namespace SchoolFaceControllApp.Models.Main
{
    public class Temperature
    {
        public int Id { get; set; }
        [Required,StringLength(50)]

        public decimal Degree { get; set; }
        public DateTime MeasureTime { get; set; }

        public int? StudentId { get; set; }
        public Student? Student { get; set; }

        public int? EmployeeId { get; set; }
        public Employee? Employee { get; set; }
    }
}
