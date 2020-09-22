using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookHouse.Models.ViewModel.UsersViewModel
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Nhập vào Email!")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Nhập vào mật khẩu!")]
        [DataType(DataType.Password)]
        public string MatKhau { get; set; }

        public bool RememberMe { get; set; }
        public string ReturnUrl { get; set; }
        public int Sach { get; set; }
    }
}
