using InternshipChat.Data.Entities.Models;
using InternshipChat.Domain.Repositories;
using InternshipChat.Presentation.Utility;
using System;

namespace InternshipChat.Presentation.Functions {
	public class CanalFunctions {

		private CanalRepository _canalRepository;

		public CanalFunctions(CanalRepository userRepository) {
			_canalRepository = userRepository;
		}


		public List<Canal> GetAllCanals() {
			return _canalRepository.FindAll();
		}
		private int LastCanalId() {
			List<int> allIds = [];
			foreach (var user in GetAllCanals()) {
				allIds.Add(user.Id);
			}
			return allIds.Count;
		}

		/*Treba ubaciti usera*/
		public void CreatePublicCanal(User user) {
			var canal = new Canal(LastCanalId()+1, Data.Enums.CanalType.Public, Inputs.StringInput(""));
			_canalRepository.Add(canal);
			JoinCanal(user);
		}
		public void CreatePrivateCanal(User user) {
			var canal = new Canal(LastCanalId() + 1, Data.Enums.CanalType.Public, Inputs.StringInput(""));
			_canalRepository.Add(canal);
			JoinCanal(user);
		}
		
		public void JoinCanal(User user) {
			/*todo*/
		}
		/*
		public string GetAllUsersCanals(User user) {
			var canals = GetAllCanals();
			var userCanals = new List<Canal>();
		}
		*/

	}
}
