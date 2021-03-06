﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookHouse.Models.ViewModel.RoleViewModel
{
    public class RoleCreateViewModel
    {
        [Required(ErrorMessage = "Nhập vào tên vai trò")]
        [MaxLength(100)]
        public string TenVaiTro { get; set; }
    }
}
