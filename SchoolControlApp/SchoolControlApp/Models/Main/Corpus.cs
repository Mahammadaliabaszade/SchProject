using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolFaceControllApp.Models.Main
{
    public class Corpus
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Adı mütləq qeyd edin!"), StringLength(50)]

        public string Name { get; set; }

        [StringLength(50)]

        public string? Address { get; set; }
        public bool IsActive { get; set; }

        public System.Collections.Generic.ICollection<Student>? Students { get; set; }
        public ICollection<Employee>? Employees { get; set; }
    }
}
