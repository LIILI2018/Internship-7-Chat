using InternshipChat.Data.Entities.Models;
using InternshipChat.Domain.Enums;
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

		public QueryResponse AddUserToCanal(User user, Canal canal) {
		var userCanal = new UserCanal (user.Id,canal.Id);
            Console.WriteLine($"{userCanal.UserId},\n{userCanal.CanalId},\n");

            if (UserCanalExists(userCanal)) {
                return QueryResponse.NoChanges;
			}
            _userCanalRepository.Add(userCanal);
			return QueryResponse.Success;
        }
	}
}
