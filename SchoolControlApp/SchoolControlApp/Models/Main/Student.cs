using System;
using System.ComponentModel.DataAnnotations;

namespace SchoolFaceControllApp.Models.Main
{
    public class Student : Person
    {
        [DataType(DataType.Date)]
        public DateTime EntryDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime GraduationDate { get; set; }

        public int? TuitionFeeId { get; set; }
        public TuitionFee? TuitionFee { get; set; }

        public int? EducationPeriodId { get; set; }
        public EducationPeriod? EducationPeriod { get; set; }

        public int? CourseId { get; set; }
        public Course? Course { get; set; }

        public int? GroupId { get; set; }
        public Group? Group { get; set; }

        public int? EducationalBaseId { get; set; }
        public EducationalBase? EducationalBase { get; set; }

    }
}
