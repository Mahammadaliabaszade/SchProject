using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolFaceControllApp.Models.Main
{
    public abstract class Person
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Adı mütləq qeyd edin!"), StringLength(50)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Soyadı mütləq qeyd edin!"), StringLength(50)]


        public string Surname { get; set; }
        [Required(ErrorMessage ="Ata adını mütləq qeyd edin!"), StringLength(50)]

        public string FatherName { get; set; }
        [StringLength(15)]

        public string? PhoneNuber { get; set; }
        [StringLength(100)]

        public string? Address { get; set; }
        public bool IsActive { get; set; }
        public byte? MissingCount { get; set; }

        public int? CorpusId { get; set; }
        public Corpus? Corpus { get; set; }

        public ICollection<Continuity> Continuities { get; set; }

        public ICollection<Temperature> Temperatures { get; set; }
    }
}
