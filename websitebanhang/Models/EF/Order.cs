using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace websitebanhang.Models.EF
{
    [Table("tb_Order")]
    public class Order : CommonAbstract
    {
        public Order()
        {
            this.OrderDetails = new HashSet<OrderDetail>();
        }
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(150)]
        public string Code { get; set; }
        [Required(ErrorMessage = "Tên khách hàng không để trống!")]
        [StringLength(150)]
        public string CustomerName { get; set; }
        [Required(ErrorMessage = "Số điện thoại không để trống!")]
        [StringLength(15)]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Địa chỉ không để trống!")]
        [StringLength(150)]
        public string Address { get; set; }
        public string Email { get; set; }
        [Required]
        public decimal TotalAmount { get; set; }
        [Required]
        public int Quantity { get; set; }
        public int TypePayment { get; set; }
        public string CustomerId { get; set; }
        public int Status { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

    }
}