using InternshipChat.Data.Entities.Models;
using InternshipChat.Data.Enums;
using InternshipChat.Domain.Repositories;
using InternshipChat.Presentation.Utility;


namespace InternshipChat.Presentation.Functions {
	public class CanalFunctions {

		private CanalRepository _canalRepository;

		public CanalFunctions(CanalRepository userRepository) {
			_canalRepository = userRepository;
		}


		public List<Canal> GetAllCanals() {
			return _canalRepository.FindAll();
		}
		public Canal? GetCanalById(int canalId) {
			return _canalRepository.FindById(canalId);
		}

		private List<Canal> GetCanalsByType(CanalType type) {
			List<Canal> canals = [];
			foreach (var canal in GetAllCanals()) {
				if (canal.CanalType == type) {
					canals.Add(canal);
				}
			}
			return canals;
		}

		private int LastCanalId() {
			List<int> allIds = [];
			foreach (var user in GetAllCanals()) {
				allIds.Add(user.Id);
			}
			return allIds.Max();
		}

		/*Treba ubaciti usera*/	
		/*Što ako je kanal null*/
		/*Treba staviti capcha*/
		public Canal CreateCanal(CanalType canalType) {
			var canal = new Canal(LastCanalId()+1, canalType, Inputs.StringInput("Unesi ime kanala"));
			_canalRepository.Add(canal);
			return canal;
		}
		
		public Canal SelectCanal(UserCanalFunctions UCF) {
			var allCanals = GetCanalsByType(CanalType.Public);
			var i = 1;
			foreach (var canal in allCanals) {
                Console.WriteLine($"{i} - {canal.Name}; {UCF.GetCanalMemberNumber(canal.Id)}");
				i++;
            }
			int y = 0;
			bool success = false;
			do {
				success = int.TryParse(Console.ReadLine(), out y);
			} while (!success || y > i || y < 1);
			return allCanals[y - 1];
		}

		public Canal SelectUsersCanals(UserCanalFunctions UCF, User user) {

			var canals = GetCanalsByType(CanalType.Public);
			var allUsersUserCanal = UCF.GetUserCanalByUserId(user.Id);
			List<int> canalIdList = [];
			foreach (var userCanal in allUsersUserCanal) {
				canalIdList.Add(userCanal.CanalId);
			}
			canals = canals.Where(canal => canalIdList.Contains(canal.Id)).ToList();

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

		public void ChatScreen(CanalFunctions CF, UserCanalFunctions UCF, MessageFunctions MF , User user  ) {
			var canal = CF.SelectUsersCanals(UCF, user);
			int x = 0;
			do {
				Console.Clear();
				foreach (var message in MF.GetMessagesByCanalId(canal.Id)) {
					Outputs.WriteMessage(message);
				};
				x = Inputs.OptionInput(["1 - Napiši poruku", "2 - Izlaz"]);
				if (x == 1) {
					MF.CreateMessage(user.Id, canal.Id);
				}
				Outputs.Wait("");
			} while (x == 1);
		}

	}
}
