using InternshipChat.Data.Entities.Models;
using InternshipChat.Domain.Factories;
using InternshipChat.Domain.Repositories;
using InternshipChat.Presentation.Functions;
using InternshipChat.Presentation.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternshipChat.Presentation.Menues {
	public static class ProfileSettings {
		public static void Submenu(UserFunctions UF, User user) {

			Utility.Functions.ValidateUser(user);/*Ili ovako ili samo unesi captcha i lozinku validate user*/
			var x = Inputs.OptionInput(["1 - Promijeni email", "2 - Promijeni šifru"]);
			switch (x) {
				case 1:
					var email = Inputs.EmailInput(UF);
					UF.UpdateUser(user, Domain.Enums.UserVariableChange.Email, email);
					break;
				case 2:
					var password = Inputs.CreatePassword();
					UF.UpdateUser(user, Domain.Enums.UserVariableChange.Password, password);
					break;

			}
		}
	}
}
