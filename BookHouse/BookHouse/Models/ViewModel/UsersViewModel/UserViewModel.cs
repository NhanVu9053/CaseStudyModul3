using BookHouse.Models.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookHouse.Models.ViewModel.UsersViewModel
{
    public class UserViewModel
    {
        public string UserId { get; set; }

        [Required(ErrorMessage = "Nhập vào email của bạn!")]
        [EmailAddress(ErrorMessage = "Email không hợp lệ")]
        public string Email { get; set; }

        //[Required(ErrorMessage = "Nhập vào tên của bạn!")]
        //[StringLength(30, MinimumLength = 10)]
        //public string Ten { get; set; }

        public string DiaChi { get; set; }

        [RegularExpression(@"^\(?(0|[3|5|7|8|9])+([0-9]{8})$", ErrorMessage = "Số điện thoại không hợp lệ")]
        public string SoDienThoai { get; set; }

        public Gender GioiTinh { get; set; }
        public string RoleName { get; set; }
    }
}

