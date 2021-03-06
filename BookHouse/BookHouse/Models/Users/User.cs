﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookHouse.Models.Users
{
    public class User : IdentityUser
    {
      
        [StringLength(30, MinimumLength = 10)]
        public string Name { get; set; }

        public Gender Gender { get; set; }
        public string Address { get; set; }
        public string ProfilePicture { get; set; }
        public bool IsDeleted { get; set; }
    }
}
