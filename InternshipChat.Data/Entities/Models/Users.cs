using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternshipChat.Data.Entities.Models {
	public class User {
		public int Id { get; set; }
		public string Name { get; set; } = null!;
		public string Surename { get; set; } = null!;
		public string Email { get; set; } = null!;
		private string _password { get; set; } = null!;
		public bool IsAdmin { get; set; } = false;
		public User(string name, string surename, string email, string password) {
			//Dodaj increasing id
			Name = name;
			Surename = surename;
			Email = email;
			_password = password;
		}
	}
}
