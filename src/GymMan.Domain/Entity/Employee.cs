using System;
using Volo.Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;


namespace GymMan.Entity
{
    public class Employee : AuditedAggregateRoot<Guid>
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
