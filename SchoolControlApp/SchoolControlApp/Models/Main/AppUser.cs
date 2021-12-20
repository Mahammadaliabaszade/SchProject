using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolFaceControllApp.Models.Main
{
    public class AppUser : IdentityUser
    {
        [Required(ErrorMessage ="Adı mütləq qeyd edin!"), StringLength(50)]
        [PersonalData]
        public string Name { get; set; }

        [Required(ErrorMessage ="Soyadı mütləq qeyd edin!"), StringLength(50)]
        [PersonalData]
        public string Surname { get; set; }
    
    }
}
