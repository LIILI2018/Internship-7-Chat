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
		public string Password { get; set; } = null!;
		public bool IsAdmin { get; set; } = false;

		public ICollection<UserCanal> UserCanals { get; set; } = new List<UserCanal>();
		public ICollection<Message> Messages { get; set; } = new List<Message>();
		public User(int id, string name, string surename, string email, string password, bool isAdmin) {
			Id = id;
			Name = name;
			Surename = surename;
			Email = email;
			Password = password;
			IsAdmin = isAdmin;
		}
		public User(int id, string name, string surename, string email, string password) {
			Id = id;
			Name = name;
			Surename = surename;
			Email = email;
			Password = password;
		}

		public bool CheckPassword(string password) {
            return Password == password;
		}
	}
}
