﻿using PasswordManagerMobile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PasswordManagerMobile.ApiResponses
{
    public class AuthResponse :ApiResponse
    {
        public AccessToken AccessToken { get; set; }
        public bool TwoFactorLogIn { get; set; } = false;
        public int UserId { get; set; }
    }
}
