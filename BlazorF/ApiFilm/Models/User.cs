﻿using System.ComponentModel.DataAnnotations;

namespace BlazorF.ApiFilm.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public string Password { get; set; }
        public string Role { get; set; }
    }
    public class LoginRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
    public class AuthResponse
    {
        public string Token { get; set; }
    }
    public class UserRegisterRequest
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string Description { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
