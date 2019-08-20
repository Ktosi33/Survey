using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace aprototype.Data.Models
{
    public class ApplicationUser
    {
        public ApplicationUser()
        {

        }

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
