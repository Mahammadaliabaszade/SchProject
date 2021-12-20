using System.ComponentModel.DataAnnotations;

namespace SchoolFaceControllApp.Models.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage ="Adı daxil edin!")]
        [Display(Name ="Ad:")]
        [StringLength(maximumLength:50,MinimumLength = 3,
            ErrorMessage = "Ad düzgün deyil!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soyadı daxil edin!")]
        [Display(Name = "Soyad:")]
        [StringLength(maximumLength: 50, MinimumLength = 3,
            ErrorMessage = "Soyad düzgün deyil!")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Nömrəni daxil edin!")]
        [Display(Name = "Nömrə:")]
        [DataType(DataType.PhoneNumber)]
        //[RegularExpression(@"^(?([0-9]{3}))?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
           //ErrorMessage = "Nömrə düzgün formatda deyil!")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "E-poçtu daxil edin!")]
        [Display(Name = "E-poçt:")]
        [DataType(DataType.EmailAddress)]
        //[RegularExpression(@"\b[A-Z0-9._%-]+@[A-Z0-9.-]+\.[A-Z]{2,4}\b",
        //    ErrorMessage = "E-poçt düzgün formatda deyil!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Parolu daxil edin!")]
        [DataType(DataType.Password)]
        [Display(Name = "Parol:")]
        [StringLength(maximumLength:50,MinimumLength =8,
            ErrorMessage ="Parol ən azı 8 simvol olmalıdır!")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Parolu daxil edin!")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        [Display(Name = "Parol Yenidən:")]
        [StringLength(maximumLength: 50, MinimumLength = 8,
            ErrorMessage = "Parol ən azı 8 simvol olmalıdır!")]
        public string ConfirmedPassword { get; set; }
    }
}
