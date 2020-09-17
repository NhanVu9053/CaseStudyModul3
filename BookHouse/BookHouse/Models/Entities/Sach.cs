using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookHouse.Models.Entities
{
    public class Sach
    {[Key]
        public int SachID { get; set; }
        [Required(ErrorMessage ="Bạn Chưa Nhập Tên Sách")]
        [MaxLength(500)]
        
        public string TenSach { get; set; }
        [Required(ErrorMessage = "Bạn Chưa Nhập Tên Tác Giả")]
        [MaxLength(500)]
       
        public string TacGia { get; set; }
        [Required(ErrorMessage = "Bạn Chưa Nhập Tên Nhà Xuất Bản")]
        [MaxLength(500)]
      
        public string NXB { get; set; }
        [Required(ErrorMessage = "Bạn Chưa Nhập Ngày Xuất Bản")]
       
        public DateTime NgayXuatBan { get; set; }
        [Required(ErrorMessage = "Bạn Chưa Nhập Tóm Tắt Sách")]
        [MaxLength(100000)]
     
        public string TomTatSach { get; set; }

        public string AnhSach { get; set; }
        [Required(ErrorMessage = "Bạn Chưa Nhập Giá")]
      
        public int GiaSach { get; set; }

        [ForeignKey("DanhMuc")]
        public int DanhMucId { get; set; }
        public DanhMucSach DanhMucSach { get; set; }

        
        
    }
}
