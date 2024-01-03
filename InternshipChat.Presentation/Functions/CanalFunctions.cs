using InternshipChat.Data.Entities.Models;
using InternshipChat.Data.Enums;
using InternshipChat.Domain.Factories;
using InternshipChat.Domain.Repositories;
using InternshipChat.Presentation.Utility;


namespace InternshipChat.Presentation.Functions {
	public class CanalFunctions {
		private CanalRepository _canalRepository;
		public CanalFunctions(CanalRepository userRepository) {
			_canalRepository = userRepository;
		}
		/**/
		//
		public List<Canal> GetAllCanals() {
			return _canalRepository.GetAll();
		}
		//
		public Canal? GetCanalById(int canalId) {
			return _canalRepository.GetById(canalId);
		}
		//
		private List<Canal> GetCanalsByType(CanalType type) {
			List<Canal> canals = [];
			foreach (var canal in GetAllCanals()) {
				if (canal.CanalType == type) {
					canals.Add(canal);
				}
			}
			return canals;
		}
		//
		private int LastCanalId() {
			List<int> allIds = [];
			foreach (var user in GetAllCanals()) {
				allIds.Add(user.Id);
			}
			return allIds.Max();
		}
		//
		public Canal CreateCanal(CanalType canalType, User? user1, User? user2) {
			Canal canal;
			if (canalType == CanalType.Public ) {
				 canal = new Canal(LastCanalId() + 1, canalType, Inputs.StringInput("Unesi ime kanala"));
			}
			else {
				 canal = new Canal(LastCanalId() + 1, canalType, $"{user1!.Name} - {user2!.Name}");
			}
			_canalRepository.Add(canal);
			return canal;
		}
		/**/
		public Canal SelectCanal(UserCanalFunctions UCF) {
			var canals = GetCanalsByType(CanalType.Public);
			var i = 1;
			foreach (var canal in canals) {
                Console.WriteLine($"{i} - {canal.Name}; {UCF.GetCanalMemberNumber(canal.Id)}");
				i++;
            }
			int y = 0;
			bool success = false;
			do {
				success = int.TryParse(Console.ReadLine(), out y);
			} while (!success || y > i || y < 1);
			return canals[y - 1];
		}
		//
		public Canal? SelectUsersCanals(UserCanalFunctions UCF, User user, CanalType canalType) {

			var canals = GetCanalsByType(canalType);
			var userCanals = UCF.GetUserCanalByUserId(user.Id);
			List<int> canalIdList = [];
			foreach (var userCanal in userCanals) {
				canalIdList.Add(userCanal.CanalId);
			}
			canals = canals.Where(canal => canalIdList.Contains(canal.Id)).ToList();
            if (canals.Count() == 0)
				return null;
            var i = 1;
			foreach (var canal in canals) {
				Console.WriteLine($"{i} - {canal.Name}; {UCF.GetCanalMemberNumber(canal.Id)}");
				i++;
			}
			int y = 0;
			bool success = false;
			do {
				success = int.TryParse(Console.ReadLine(), out y);
			} while (!success || y > i || y < 1);
			return canals[y - 1];
		}

		//
		public void ChatScreen(UserFunctions UF, CanalFunctions CF, UserCanalFunctions UCF, MessageFunctions MF, User user, CanalType canalType) {
			Canal? canal = null!;
			int x = 0;
			//
			if (canalType == CanalType.Public) {
				canal = CF.SelectUsersCanals(UCF, user, canalType);
			}

			else {
				x = Inputs.OptionInput(["1 - Nastavi chat", "2 - Novi chat"]);

				if (x == 1) {
					canal = CF.SelectUsersCanals(UCF, user, canalType);
				}
				else{
					var user2 = UF.SelectUser();
					canal = CreateCanal(CanalType.Private, user, user2);
                    UCF.CreateUserCanal(user, canal);
					UCF.CreateUserCanal(user2, canal);
				}
			}
			if (canal is null) {
				Outputs.Wait($"Ne sudjeluješ u {canalType} kanalu");
				return;
			}
            do {
				Console.Clear();
				foreach (var message in MF.GetMessagesByCanalId(canal.Id)) {
					Outputs.WriteMessage(UF, message);
				};
                Console.WriteLine();
                x = Inputs.OptionInput(["1 - Napiši poruku", "2 - Izlaz"]);
				if (x == 1) {
					MF.CreateMessage(user.Id, canal.Id);
				}
			} while (x == 1);			
		}
	}
}
