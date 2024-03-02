using System.ComponentModel.DataAnnotations;

namespace UseRecaptchaInDotNetCore.ViewModels;

public class ContactUseFormViewModel
{
    [Range(2,100)]
    public string Name { get; set; } = string.Empty;

    [EmailAddress]
    public string Email { get; set; } = string.Empty;

    [StringLength(1500)]
    public string Message { get; set; } = string.Empty;
}