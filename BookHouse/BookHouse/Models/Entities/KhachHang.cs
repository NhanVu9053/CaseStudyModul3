using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookHouse.Models.Entities
{
    public class KhachHang
    {
        [Required] public int KhachHangId { get; set; }

        //public string UserId { get; set; }
        ////public User User { get; set; }
        public string TenKhachHang { get; set; }

        [Required] public string SoDienThoai { get; set; }

        [Required]
        [MaxLength(200)]
        public string DiaChi { get; set; }
    }
}
