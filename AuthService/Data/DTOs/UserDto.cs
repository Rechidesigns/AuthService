﻿namespace AuthService.Data.DTOs
{
    public class UserDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool IsSeller { get; set; }
    }
}