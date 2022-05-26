using System;
using System.ComponentModel.DataAnnotations;

namespace GymMan.DTO
{
    public class CreateUpdateEmployeeDto
    {
        [Key]
        public Guid EmployeeID { get; set; }
        [Required]
        [MaxLength(50)]
        public string Firstname { get; set; }
        [Required]
        public string Lastname { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }
        [Required]
        [MaxLength(100)]
        public string JobTitle { get; set; }
        [Required]
        public string Email { get; set; }
        public string Cellphone { get; set; }
    }
}
