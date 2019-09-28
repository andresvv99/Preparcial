

namespace WebEstudiante.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class Student

    {
        [Key]
        public int FriendID { get; set; }
        [Required]
        [Display(Description ="Nombre")]
        [StringLength(50, MinimumLength = 5)]
        public string Name { get; set; }
        [Display(Description ="Lista de nombres")]
        public Lista list { get; set; }
        [Required]
        [DataType(DataType.EmailAddress,ErrorMessage ="Direccion de correo no valida")]
        public string Email { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BirthDate{ get; set; }


    }
    public enum Lista {
        Valeria,
        Vasco,
        Valentin,
        Virginia,
        Virgilio
    }
}