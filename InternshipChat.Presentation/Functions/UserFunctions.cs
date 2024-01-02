using InternshipChat.Data.Entities.Models;
using InternshipChat.Domain.Enums;
using InternshipChat.Domain.Repositories;
using InternshipChat.Presentation.Utility;

namespace InternshipChat.Presentation.Functions {
	public class UserFunctions  { 
		private UserRepository _userRepository;
        public UserFunctions(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }
		/**/
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
		private int LastId() {
			List<int> allIds = [];
			foreach (var user in GetAllUsers()) {
				allIds.Add(user.Id);
			}
			return allIds.Max();
		}
		//
		public bool DoesEmailExist(string email) {
			List<string> allEmails = [];
			foreach (var user in GetAllUsers()) {
				allEmails.Add(user.Email);
			}
			var contains = allEmails.Contains(email);
			if (!contains)
				Outputs.Wait("Email ne postoji");
			return contains;
		}
		/**/

		public User AddUser(UserFunctions UF) {
			var name = Inputs.StringInput("Unesi ime");
			var surename = Inputs.StringInput("Unesi prezime");
			var email = Inputs.CreateEmail();
			var password = Inputs.CreatePassword();			

            var user = new User(LastId() + 1, name, surename, email, password);
			_userRepository.Add(user);
			return user;
		}

		public User SelectUser() {
			var users = GetAllUsers();
			var i = 1;
			foreach (var user in users) {
				Console.WriteLine($"{i} - {user.Name};");
				i++;
			}
			int y = 0;
			bool success = false;
			do {
				success = int.TryParse(Console.ReadLine(), out y);
			} while (!success || y > i || y < 1);
			return users[y - 1];
		}

		public QueryResponse UpdateUser(User user, UserVariableChange userVariableChange, string change) {
			return _userRepository.Update(user, userVariableChange, change);
		}
	}
}
