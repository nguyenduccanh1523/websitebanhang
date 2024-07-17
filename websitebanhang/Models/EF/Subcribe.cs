using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace websitebanhang.Models.EF
{
    [Table("tb_Subscribe")]
    public class Subcribe
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [EmailAddress]
        [Required]
        [StringLength(150)]
        public string Email { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}