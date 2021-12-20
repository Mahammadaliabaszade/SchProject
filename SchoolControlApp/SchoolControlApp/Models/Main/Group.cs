using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolFaceControllApp.Models.Main
{
    public class Group
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Adı mütləq qeyd edin!"), StringLength(50)]
        public string Name { get; set; }

        public ICollection<Student> Students { get; set; }

        public int? SpecialtyId { get; set; }
        public Specialty? Specialty { get; set; }
    }
}
