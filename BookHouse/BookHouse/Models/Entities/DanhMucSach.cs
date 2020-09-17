using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookHouse.Models.Entities
{
    public class DanhMucSach
    {[Key]
        public int DanhMucSachId { get; set; }
        [Required]
        [MaxLength(500)]
        [Display(Name ="Tên Danh Mục")]
        public string TenDanhMuc { get; set; }
       
        [MaxLength(10000)]
        [Display(Name = "Mô tả")]
        public string MoTa { get; set; }
        

        public ICollection<Sach>  Sachs { get; set; }
    }
}
