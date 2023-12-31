using InternshipChat.Data.Entities.Models;
using InternshipChat.Data.Enums;
using InternshipChat.Domain.Enums;
using InternshipChat.Domain.Repositories;
using InternshipChat.Presentation.Utility;
using System;
using System.Collections.Generic;

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

		private List<Canal> GetAllCanalsByType(CanalType type) {
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
			return allIds.Count;
		}

		/*Treba ubaciti usera*/	
		/*Što ako je kanal null*/
		/*Treba staviti capcha*/
		public Canal CreatePublicCanal() {
			var canal = new Canal(LastCanalId()+1, Data.Enums.CanalType.Public, Inputs.StringInput("Unesi ime kanala"));
			_canalRepository.Add(canal);
			return canal;
		}
		public Canal CreatePrivateCanal() {
			var canal = new Canal(LastCanalId() + 1, Data.Enums.CanalType.Public, Inputs.StringInput(""));
			_canalRepository.Add(canal);
			return canal;
		}
		
		public Canal SelectCanal() {
			var allCanals = GetAllCanalsByType(CanalType.Public);
			var i = 1;
			foreach (var canal in allCanals) {
                Console.WriteLine($"{i} - {canal.Name}");
				i++;
            }

			int y = 0;
			bool success = false;
			do {
				success = int.TryParse(Console.ReadLine(), out y);
			} while (!success || y > i || y < 1);
			return allCanals[y - 1];
			

		}
		/*
		public string GetAllUsersCanals(User user) {
			var canals = GetAllCanals();
			var userCanals = new List<Canal>();
		}
		*/

	}
}
