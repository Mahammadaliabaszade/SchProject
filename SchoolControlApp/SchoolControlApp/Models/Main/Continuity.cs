using SchoolFaceControllApp.Models.Main;
using System;
using System.ComponentModel.DataAnnotations;

namespace SchoolFaceControllApp.Models.Main
{
    public class Continuity
    {
        public int Id { get; set; } 
        public bool IsActive { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MissingReason MissingReason { get; set; }

        [DataType(DataType.Date)]
        public DateTime Day { get; set; }

        public int? StudentId { get; set; }
        public Student? Student { get; set; }

        public int? EmployeeId { get; set; }
        public Employee? Employee { get; set; }
    }

    public enum MissingReason : byte {
        allowed = 0,
        unallowed = 1
    }
}
