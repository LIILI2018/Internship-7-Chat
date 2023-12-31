using InternshipChat.Data.Entities.Models;
using InternshipChat.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternshipChat.Presentation.Functions {
	public class UserCanalFunctions {
		private UserCanalRepository _userCanalRepository;

        public UserCanalFunctions(UserCanalRepository userCanalRepository)
        {
            _userCanalRepository = userCanalRepository;
        }
        public List<UserCanal> GetAllUserCanals(){
			return _userCanalRepository.FindAll();
		}

		private bool UserCanalExists(UserCanal userCanal) {
			return GetAllUserCanals().Contains(userCanal);
		}

		public void Create(int userId, int canalId) {
			var userCanal = new UserCanal {
				UserId = userId,
				CanalId = canalId
			};
			if (UserCanalExists(userCanal)) {
                Console.WriteLine("VEć si član tog kanala");
                return;
			}
			_userCanalRepository.Add(userCanal);
            Console.WriteLine("Uspješno dodano?");
        }
	}
}
