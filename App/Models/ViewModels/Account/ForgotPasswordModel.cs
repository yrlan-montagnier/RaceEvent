﻿#nullable disable

using System.ComponentModel.DataAnnotations;

namespace App.Models.ViewModels.Account;

public class ForgotPasswordModel
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }
}
