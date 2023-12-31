﻿using InternshipChat.Data.Entities.Models;
using InternshipChat.Domain.Enums;
using InternshipChat.Domain.Repositories;
using InternshipChat.Presentation.Utility;

namespace InternshipChat.Presentation.Functions {
	public class UserFunctions  { 
		private UserRepository _userRepository;
        public UserFunctions(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }
		/**/
		public List<User> GetAllUsers() { 
			return _userRepository.FindAll();
		}
		//
		public User? GetUserById(int id) {
			return _userRepository.FindById(id);
		}
		//
		public User? FindByEmail(string email) {
			return _userRepository.FindByEmail(email);
		}
		//
		private int LastId() {
			List<int> allIds = [];
			foreach (var user in GetAllUsers()) {
				allIds.Add(user.Id);
			}
			return allIds.Max();
		}
		//
		public bool DoesEmailExist(string email) {
			List<string> allEmails = [];
			foreach (var user in GetAllUsers()) {
				allEmails.Add(user.Email);
			}
			var contains = allEmails.Contains(email);
			return contains;
		}
		//
		public OperationResult DeleteUser(UserCanalFunctions UCF, MessageFunctions MF, User user)
		{
			UCF.DeleteUserCanalbyUserId(user.Id);
			MF.DeleteUsersMessages(user.Id);
			return _userRepository.Delete(user);
		}

		/**/

		public User? AddUser(UserFunctions UF) {
			var name = Inputs.StringInput("Unesi ime");
			var surename = Inputs.StringInput("Unesi prezime");
			var email = Inputs.EmailInput(UF,true);
			var password = Inputs.CreatePassword();
			if (!Utility.Functions.Captcha()) {
				Outputs.Wait(OperationResult.Fail.ToString());
				return null;
            }
			var user = new User(LastId() + 1, name, surename, email, password);
			_userRepository.Add(user);
			Outputs.Wait(OperationResult.Success.ToString());
			return user;
		}

		public User SelectUser() {
			var users = GetAllUsers();
			var i = 1;
			foreach (var user in users) {
				Console.WriteLine($"{i} - {user.Name};");
				i++;
			}
			int y = 0;
			bool success = false;
			do {
				success = int.TryParse(Console.ReadLine(), out y);
			} while (!success || y > i || y < 1);
			Console.Clear();
			return users[y - 1];
		}

		public OperationResult UpdateUser(User user, UserVariableChange userVariableChange, string change) {
			return _userRepository.Update(user, userVariableChange, change);
		}
	}
}
