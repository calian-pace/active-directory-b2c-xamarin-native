﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UserDetailsClient.Core.Features.LogOn
{
    public interface IAuthenticationService
    {
        void SetParent(object parent);
        Task<UserContext> SignInAsync();
        Task<UserContext> SignOutAsync();
        Task<UserContext> EditProfileAsync();
        Task<UserContext> ResetPasswordAsync();
    }
}