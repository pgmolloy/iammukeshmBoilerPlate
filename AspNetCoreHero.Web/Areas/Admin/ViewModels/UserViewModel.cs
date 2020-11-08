﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreHero.Web.Areas.Admin.ViewModels
{
    public class UserViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public bool IsActive { get; set; } = true;
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        public byte[] ProfilePicture { get; set; }
        public bool EmailConfirmed { get; set; }
        public  string Id { get; set; }
    }
}
