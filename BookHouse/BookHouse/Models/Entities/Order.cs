using BookHouse.Models.Status;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookHouse.Models.Entities
{
    public class Order
    {
        [Required] public int OrderId { get; set; }

        public int KhachHangId { get; set; }
        public KhachHang KhachHang { get; set; }
        public OrderStatus Status { get; set; }

        [Required] public DateTime ThoiGianDatHang { get; set; }

        public DateTime ThoiGianHoanThanh { get; set; }
        public string GhiChu { get; set; }
    }
}
