using System;
using System.ComponentModel.DataAnnotations;

namespace CoolRider_1.Models
{
    public class AdminActivationCode
    {
        [Key]
        public int Id { get; set; }  // Primary key

        [Required]
        [StringLength(100)]
        public string Code { get; set; } = string.Empty;  // Activation code content

        [Required]
        [StringLength(20)]
        public string Status { get; set; } = "Unused";  // Status: Unused / Used

        public int? UsedByUserId { get; set; }  // User ID who used the code
        public DateTime? UsedAt { get; set; }   // Time when the code was used
        public DateTime CreatedAt { get; set; } = DateTime.Now; // Time when the code was created
    }
}
