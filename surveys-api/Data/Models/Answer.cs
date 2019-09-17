using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace aprototype.Data.Models
{
    public class Answer
    {
        #region properties
        [Key]
        [Required]
        public int ID { get; set; }
        [Required]
        public int QuestionID { get; set; }
        [Required]
        public string Text { get; set; }
        [Required]
        public int Value { get; set; }
        public string Notes { get; set; }
        [DefaultValue(0)]
        public int Type { get; set; }
        [DefaultValue(0)]
        public int Flags { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
        [Required]
        public DateTime LastModifiedDate { get; set; }
        #endregion
    }
}
