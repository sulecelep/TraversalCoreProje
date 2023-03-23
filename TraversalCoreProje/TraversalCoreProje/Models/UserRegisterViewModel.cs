using System.ComponentModel.DataAnnotations;

namespace TraversalCoreProje.Models
{
	public class UserRegisterViewModel
	{
		[Required(ErrorMessage ="Lütfen adınızı giriniz.")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Lütfen soyadınızı giriniz.")]
		public string Surname { get; set; }

		[Required(ErrorMessage = "Lütfen kullanıcı adınızı giriniz.")]
		public string Username { get; set; }

		[Required(ErrorMessage = "Lütfen mail adresinizi giriniz.")]
		public string Mail { get; set; }

		[Required(ErrorMessage = "Lütfen şifrenizi giriniz.")]
		public string Password { get; set; }

		
		[Compare("Password",ErrorMessage ="Şifreler uyumlu değil")]
		[Required(ErrorMessage = "Lütfen şifrenizi tekrar giriniz.")]
		public string ConfirmPassword { get; set; }

	}
}
