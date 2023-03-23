using Microsoft.AspNetCore.Identity;

namespace TraversalCoreProje.Models
{
	public class CustomIdentityValidator:IdentityErrorDescriber
	{ 
		public override IdentityError PasswordTooShort(int length)
		{
			return new IdentityError()
			{
				Code = "PasswordTooShort",
				Description = $"Şifre min {length} karakter olamalıdır."
			};
		}
		public override IdentityError PasswordRequiresUpper()
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresUpper",
				Description = $"Şifre en az 1 büyük harf içermelidir."
			};
		}
		public override IdentityError PasswordRequiresLower()
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresLower",
				Description = $"Şifre en az 1 küçük harf içermelidir."
			};
		}
		public override IdentityError PasswordRequiresNonAlphanumeric()
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresNonAlphanumeric",
				Description = $"Şifre en az 1 özel karakter içermelidir."
			};
		}
		public override IdentityError PasswordRequiresDigit()
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresDigit",
				Description = $"Şifre en az 1 rakam içermelidir ('0'.'9')."
			};
		}
	}
}
