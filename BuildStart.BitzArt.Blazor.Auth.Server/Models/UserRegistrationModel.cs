using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BuildStart.BitzArt.Blazor.Auth.Server.Models
{
    public class UserRegistrationModel
    {
        [Required(ErrorMessage = "Please enter email")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email Address")]
        [JsonPropertyName("email")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter password (must be at least 6 characters)")]
        [StringLength(140, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [JsonPropertyName("password")]
        public string Password { get; set; } = string.Empty;

        [Required(ErrorMessage = "Password confirmation is required")]
        [DataType(DataType.Password)]
        [Display(Name = "Password Confirmation")]
        [Compare("Password")]
        [JsonIgnore]
        public string PasswordConfirmation { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter username")]
        [StringLength(64, ErrorMessage = "The Username cannot exceed 64 characters.")]
        [DataType(DataType.Text)]
        [Display(Name = "User Name")]
        [JsonPropertyName("username")]
        public string UserName { get; set; } = string.Empty;

        //[JsonPropertyName("optin_internal")]
        //[Display(Name = "Opt in to receive email from Company Name")]
        //public bool OptinInternal { get; set; } = false;

        //[JsonPropertyName("optin_external")]
        //[Display(Name = "Opt in to receive email from partners of Company Name")]
        //public bool OptinExternal { get; set; } = false;

        [JsonPropertyName("meta")]
        public JsonElement Meta { get; set; } = new JsonElement();
        //public string MetaJson { get; set; } = String.Empty;

        [JsonPropertyName("claims")]
        public IList<ClaimModel> Claims { get; set; } = new List<ClaimModel>();
    }
}
