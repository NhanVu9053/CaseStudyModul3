using BookHouse.Models.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookHouse.Models.ViewModel.UsersViewModel
{
    public class UserEditViewModel
    {
        public string UserId { get; set; }

        [Required(ErrorMessage = "Nhập vào email!")]
        [EmailAddress(ErrorMessage = "Email không hợp lệ")]
        public string Email { get; set; }
        //[Required(ErrorMessage = "Nhập vào tên!")]
        //[StringLength(30, MinimumLength = 5, ErrorMessage = "Độ dài của tên trong khoảng từ 5 đến 30 ký tự!")]
        //public string Ten { get; set; }

        public string DiaChi { get; set; }

        [RegularExpression(@"^\(?(0|[3|5|7|8|9])+([0-9]{8})$", ErrorMessage = "Số điện thoại không hợp lệ")]
        public string SoDienThoai { get; set; }

        public Gender Gender { get; set; }
        public string RoleId { get; set; }
    }
}

