using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookHouse.Models.ViewModel.SachViewmodel
{
    public class SachEditViewModel
    {
        [Required(ErrorMessage = "Bạn Chưa Nhập Tên Sách")]
        [MaxLength(500)]
        [Display(Name ="Tên sách")]
        public string TenSach { get; set; }
        [Required(ErrorMessage = "Bạn Chưa Nhập Tên Tác Giả")]
        [MaxLength(500)]
        [Display(Name = "Tên tác giả")]
        public string TacGia { get; set; }
        [Required(ErrorMessage = "Bạn Chưa Nhập Tên Nhà Xuất Bản")]
        [MaxLength(500)]
        [Display(Name = "Nhà xuất bản")]
        public string NXB { get; set; }
        [Required(ErrorMessage = "Bạn Chưa Nhập Ngày Xuất Bản")]
        [Display(Name = "Ngày xuất bản")]
        public DateTime NgayXuatBan { get; set; }
        [Required(ErrorMessage = "Bạn Chưa Nhập Tóm Tắt Sách")]
        [MaxLength(100000)]
        [Display(Name = "Tóm tắt")]
        public string TomTatSach { get; set; }

        public string AnhSach { get; set; }
        [Required(ErrorMessage = "Bạn Chưa Nhập Giá")]
        [Display(Name = "Giá sách")]
        public int GiaSach { get; set; }

        [Required(ErrorMessage = "Bạn Chưa nhập loại danh mục sách")]
        [Display(Name = "Loại danh mục sách")]
        public int DanhMucId { get; set; }
    }
}
