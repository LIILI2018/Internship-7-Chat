using InternshipChat.Data.Entities.Models;
using InternshipChat.Domain.Enums;
using InternshipChat.Domain.Repositories;

namespace InternshipChat.Presentation.Functions {
	public class UserCanalFunctions {
		private UserCanalRepository _userCanalRepository;

		public UserCanalFunctions(UserCanalRepository userCanalRepository) {
			_userCanalRepository = userCanalRepository;
		}
		private List<UserCanal> GetAllUserCanals() {
			return _userCanalRepository.FindAll();
		}
		private List<UserCanal> GetAllUserCanalsByUserId(int userId) {
			List<UserCanal> allUsersUserCanals = [];
			foreach (var UserCanal in GetAllUserCanals()) {
				if (userId == UserCanal.UserId)
					allUsersUserCanals.Add(UserCanal);
			}
			return allUsersUserCanals;
		}
		private bool UserCanalExists(UserCanal userCanal) {
			return GetAllUserCanals().Contains(userCanal);
		}

		public QueryResponse AddUserToCanal(User user, Canal canal) {
			var userCanal = new UserCanal(user.Id, canal.Id);
			Console.WriteLine($"{userCanal.UserId},\n{userCanal.CanalId},\n");

			if (UserCanalExists(userCanal)) {
				return QueryResponse.NoChanges;
			}
			_userCanalRepository.Add(userCanal);
			return QueryResponse.Success;
		}

		public QueryResponse WriteAllUsersUserCanals(User user, CanalFunctions CF) {
			foreach (var UserCanal in GetAllUserCanalsByUserId(user.Id)) {
				var canal = CF.GetCanalById(UserCanal.CanalId);
                Console.WriteLine(canal!.Name);
            }
			return QueryResponse.Success;
		}
	}
}
