using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolFaceControllApp.Models.Main
{
    public class Specialty
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Adı mütləq qeyd edin!"), StringLength(100)]


        public string Name { get; set; }

        [Required(ErrorMessage ="Kodu mütləq qeyd edin!"), StringLength(20)]

        public string Code { get; set; }

        public ICollection<Group> Groups { get; set; }
    }
}
