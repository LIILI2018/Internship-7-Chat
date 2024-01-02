﻿using InternshipChat.Data.Entities.Models;
using InternshipChat.Domain.Factories;
using InternshipChat.Domain.Repositories;
using InternshipChat.Presentation.Functions;
using InternshipChat.Presentation.Utility;


namespace InternshipChat.Presentation.Menues {
	public static class PrivateCanals {
		public static void Submenu(User user) {
			var CF = new CanalFunctions(RepositoryFactory.Create<CanalRepository>());
			var UCF = new UserCanalFunctions(RepositoryFactory.Create<UserCanalRepository>());
			var MF = new MessageFunctions(RepositoryFactory.Create<MessageRepository>());

			var x = Inputs.OptionInput(["1 - Chat sa korisnikom", "2 - Ispiši sve korisnike s kojima si komunicirao", "3 - Izlaz"]);
			switch (x) {
				case 1:
					CF.ChatScreen(CF, UCF, MF, user, Data.Enums.CanalType.Private);
					break;
				/*case 2:
					UCF.WriteUsersPrivateChats();
					break;*/

			}
		}
	}
}
