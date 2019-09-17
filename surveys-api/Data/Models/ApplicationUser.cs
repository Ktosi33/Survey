
using System;
using System.ComponentModel.DataAnnotations;

namespace aprototype.Data.Models
{
    public class ApplicationUser
    {

        [Key]
        [Required]
        public string Id { get; set; }

        [Required]
        public string Email { get; set; }
        public string DisplayName{ get; set; }
        public string Notes { get; set; }

        [Required]
        public int Type { get; set; }
        [Required]
        public int Flags { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
        [Required]
        public DateTime LastModifiedDate { get; set; }
    }
}
