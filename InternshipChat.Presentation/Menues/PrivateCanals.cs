using InternshipChat.Data.Entities.Models;
using InternshipChat.Data.Enums;
using InternshipChat.Presentation.Functions;
using InternshipChat.Presentation.Utility;

//
namespace InternshipChat.Presentation.Menues {
	public static class PrivateCanals {
		public static void Submenu(UserFunctions UF, CanalFunctions CF, UserCanalFunctions UCF, MessageFunctions MF, User user) { 
			var x = Inputs.OptionInput(["1 - Chat sa korisnikom", "2 - Ispiši sve korisnike s kojima si komunicirao", "3 - Izlaz"]);
			switch (x) {
				case 1:
					CF.ChatScreen(UF, CF, UCF, MF, user, Data.Enums.CanalType.Private);
					break;
				case 2:
					UCF.WriteAllUsersUserCanals(user, CF, CanalType.Private);
					Outputs.Wait("");
					break;

			}
		}
	}
}
