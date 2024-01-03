using InternshipChat.Data.Entities.Models;
using InternshipChat.Data.Enums;
using InternshipChat.Domain.Enums;
using InternshipChat.Domain.Repositories;
using InternshipChat.Presentation.Utility;

namespace InternshipChat.Presentation.Functions {
	public class UserCanalFunctions {
		private UserCanalRepository _userCanalRepository;
		public UserCanalFunctions(UserCanalRepository userCanalRepository) {
			_userCanalRepository = userCanalRepository;
		}
		/**/
		//
		public List<UserCanal> GetAllUserCanals() {
			return _userCanalRepository.FindAll();
		}
		//
		public OperationResult DeleteUserCanal(UserCanal userCanal) {
			return _userCanalRepository.Delete(userCanal);
		}
		//
		public OperationResult CreateUserCanal(User user, Canal canal) {
			var userCanal = new UserCanal(user.Id, canal.Id);
			if (UserCanalExists(userCanal)) {
				return OperationResult.NoChanges;
			}
			return _userCanalRepository.Add(userCanal) ;
		}
		//
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
			bool containsItem = GetAllUserCanals().Any(userCanal2 => userCanal2.UserId == userCanal.UserId && userCanal2.CanalId == userCanal.CanalId);
			return containsItem;
		}
		/**/
		
		//
		public OperationResult WriteAllUsersUserCanals(User user, CanalFunctions CF, CanalType canalType) {
			List<Canal> canals = [];
			foreach (var UserCanal in GetUserCanalByUserId(user.Id)) {
				canals.Add(CF.GetCanalById(UserCanal.CanalId)!);
			}
			canals = canals.Where(canal => canal.CanalType == canalType).ToList();
			foreach (var canal in canals) {
				Console.WriteLine(canal!.Name);
			}
			return OperationResult.Success;
		}

		public void DeleteUserCanalbyUserId(int userId) {
			var userCanals = GetAllUserCanals();
			foreach (var userCanal in userCanals) {
				if (userCanal.UserId == userId) {
					DeleteUserCanal(userCanal);
				}
			}
		}
		
	}
}
