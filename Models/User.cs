﻿using System;
using System.Collections.Generic;

#nullable disable

namespace PRNProject.Models
{
    public partial class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
    }
}
