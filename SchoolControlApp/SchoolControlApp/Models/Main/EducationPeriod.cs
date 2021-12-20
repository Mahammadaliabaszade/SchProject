using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolFaceControllApp.Models.Main
{
    public class EducationPeriod
    {
        public int Id { get; set; }
        public short? Date { get; set; }
        [StringLength(5)]
        public string Type { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
