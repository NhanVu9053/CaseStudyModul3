using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookHouse.Models.Users
{
    public class Role
    {
        public string RoleId { get; set; }
        public string TenVaiTro { get; set; }
        public bool IsDeleted { get; set; }
    }
}
