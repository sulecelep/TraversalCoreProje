using Microsoft.AspNetCore.Http;

namespace TraversalCoreProje.Areas.Member.Models
{
	public class UserEditViewModel
	{
		public string name {get; set;}
		public string surname {get; set;}
		public string username {get; set;}
		public string password {get; set;}
		public string confirmpassword {get; set;}
		public string phonenumber {get; set;}
		public string mail {get; set;}
		public string Imageurl {get; set;}
		public IFormFile Image {get; set;}
	}
}
