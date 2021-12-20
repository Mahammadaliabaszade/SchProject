using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolFaceControllApp.Models.Main
{
    public class Duty
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Adı mütləq qeyd edin!"), StringLength(100)]
        public string Name { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
