using InternshipChat.Data.Entities.Models;
using InternshipChat.Presentation.Functions;
using InternshipChat.Presentation.Utility;


namespace InternshipChat.Presentation.Menues {
	public static class ProfileSettings {
		public static void Submenu(UserFunctions UF, User user) {

			if(!Utility.Functions.ValidateUser(user))
				return;
			var x = Inputs.OptionInput(["1 - Promijeni email", "2 - Promijeni šifru", "3 - Izlaz"]);
			switch (x) {
				case 1:
					var email = Inputs.EmailInput(UF,true);
					Outputs.Wait(UF.UpdateUser(user, Domain.Enums.UserVariableChange.Email, email).ToString());
					break;
				case 2:
					var password = Inputs.CreatePassword();
					Outputs.Wait(UF.UpdateUser(user, Domain.Enums.UserVariableChange.Password, password).ToString());
					break;
				default: break;
			}
		}
	}
}
