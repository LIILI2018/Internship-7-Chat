using InternshipChat.Data.Entities.Models;
using InternshipChat.Domain.Repositories;
using InternshipChat.Presentation.Utility;

namespace InternshipChat.Presentation.Functions {
	public class UserFunctions  { 
		private UserRepository _userRepository;
        public UserFunctions(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }
		
		public List<User> GetAllUsers() { 
			return _userRepository.FindAll();
		}
		public bool EmailAndPasswordMatch(string email, string password) {
			var user = _userRepository.FindByEmail(email);
			if (user == null) {
                return false;
			}
            return user.CheckPassword(password);
		}
		public User? FindByEmail(string email) {
			return _userRepository.FindByEmail(email);
		}
		private int LastUserId() {
			List<int> allIds = [];
			foreach (var user in GetAllUsers()) {
				allIds.Add(user.Id);
			}
			return allIds.Count;
		}
		private bool DoesEmailExist(string email) {
			List<string>allEmails = [];
			foreach (var user in GetAllUsers()) {
				allEmails.Add(user.Email);
			}
			return allEmails.Contains(email);
		}
		public User AddUser() {
			var name = Inputs.StringInput("Unesi ime");
			var surename = Inputs.StringInput("Unesi prezime");
			string email;
			do {
				email = Inputs.StringInput("Unesi email");
			} while (DoesEmailExist(email));
			string password;
			string repeatedPassword;
			do {
				password = Inputs.StringInput("Unesi lozinku");
				repeatedPassword = Inputs.StringInput("Ponovno unesi lozinku");
			} while (password != repeatedPassword);

            var user = new User(LastUserId() + 1, name, surename, email, password);
			_userRepository.Add(user);
			return user;
		}
	}
}
