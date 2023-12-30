using InternshipChat.Data.Entities.Models;
using InternshipChat.Domain.Repositories;

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
	}
}
