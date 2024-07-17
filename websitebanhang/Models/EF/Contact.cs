using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace websitebanhang.Models.EF
{
    [Table("tb_Contact")]
    public class Contact : CommonAbstract
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(150)]
        public string Name { get; set; }
        [StringLength(150)]
        public string Email { get; set; }
        [StringLength(150)]
        public string Website { get; set; }
        public string Message { get; set; }
        public bool IsRead { get; set; }
    }
}