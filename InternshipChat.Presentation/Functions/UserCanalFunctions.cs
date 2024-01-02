using InternshipChat.Data.Entities.Models;
using InternshipChat.Domain.Enums;
using InternshipChat.Domain.Repositories;

namespace InternshipChat.Presentation.Functions {
	public class UserCanalFunctions {
		private UserCanalRepository _userCanalRepository;
		public UserCanalFunctions(UserCanalRepository userCanalRepository) {
			_userCanalRepository = userCanalRepository;
		}
		/**/
		private List<UserCanal> GetAllUserCanals() {
			return _userCanalRepository.FindAll();
		}
		public List<UserCanal> GetUserCanalByUserId(int userId) {
			List<UserCanal> allUsersUserCanals = [];
			foreach (var UserCanal in GetAllUserCanals()) {
				if (userId == UserCanal.UserId)
					allUsersUserCanals.Add(UserCanal);
			}
			return allUsersUserCanals;
		}
		public int GetCanalMemberNumber(int canalId) {
			var i = 0;
			foreach (var userCanal in GetAllUserCanals()) {
				if (userCanal.CanalId == canalId) { i++; }
			}
			return i;
		}
		private bool UserCanalExists(UserCanal userCanal) {
			return GetAllUserCanals().Contains(userCanal);
		}
		/**/
		public QueryResponse AddUserToCanal(User user, Canal canal) {
			var userCanal = new UserCanal(user.Id, canal.Id);
			if (UserCanalExists(userCanal)) {
				return QueryResponse.NoChanges;
			}
			_userCanalRepository.Add(userCanal);
			return QueryResponse.Success;
		}

		public QueryResponse WriteAllUsersUserCanals(User user, CanalFunctions CF) {
			foreach (var UserCanal in GetUserCanalByUserId(user.Id)) {
				var canal = CF.GetCanalById(UserCanal.CanalId);
                Console.WriteLine(canal!.Name);
            }
			return QueryResponse.Success;
		}

		
	}
}
