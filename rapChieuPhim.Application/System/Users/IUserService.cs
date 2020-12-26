﻿using rapChieuPhim.ViewModels.Common;
using rapChieuPhim.ViewModels.System.Users;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace rapChieuPhim.Application.System.Users
{
    public interface IUserService
    {
        Task<string> Authencate(LoginRequest request);

        Task<bool> Register(RegisterRequest request);

        Task<PagedResult<UserVm>> GetUsersPaging(GetUserPagingRequest request);
    }
}