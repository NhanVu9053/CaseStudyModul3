using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookHouse.Models.Entities
{
    public class OrderDetail
    {
        [Required] [Key] public int OrderDetailId { get; set; }

        [Required] [ForeignKey(nameof(Order))] public int OrderId { get; set; }

        public Order Order { get; set; }

        [Required]
        [ForeignKey(nameof(Sach))]
        public int SachId { get; set; }

        public Sach Sach { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Nhập sai giá!")]
        public int GiaSach { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Nhập sai số lượng!")]
        public int SoLuong { get; set; }
    }
}
