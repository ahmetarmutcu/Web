using System.ComponentModel.DataAnnotations;

namespace CoreBlog.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage="lütfen kullanıcı adını girin")]
        public string Username { get; set; }
        [Required(ErrorMessage = "lütfen şifre girin")]
        public string Password { get; set; }
    }
}
