﻿using AuthService.Data.UserDatas.Model;
using AuthService.Data.UserDatas.DTOs;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using AuthService.Helpers;
using AuthService.Data.Auth;


namespace AuthService.Services.UserManagement.Interface
{
    public interface IUserService
    {
        Task<RegisterResponse> RegisterAsync(RegisterDto model);
        Task<UserDto> GetUserByEmailAsync(string email);
        Task<Result<LoginResponseDto>> Login(LoginDto model);
        Task<Result<LoginResponseDto>> RefreshToken(RefreshTokenNewRequestModel tokenModel);
        Task<string> ChangePassword(string email, ChangePassword model);
        
        Task<Result<LogoutRequestDto>>Logout(string AccessToken);

    }
}


