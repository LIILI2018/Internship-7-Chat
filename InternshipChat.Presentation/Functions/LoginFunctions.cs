using InternshipChat.Data.Entities.Models;
using InternshipChat.Domain.Factories;
using InternshipChat.Domain.Repositories;
using InternshipChat.Presentation.Functions;
using InternshipChat.Presentation.Utility;

namespace InternshipChat.Domain.Functions {
	public static class LoginFunctions {


		public static User Authentication() {
			var x = Inputs.OptionInput(["1 - Use existing account", "2 - Create acount"]);
			User? user = null;
			do {
				switch (x) {
					case 1:
						user = Login();
						break;
					case 2:						
						break;
				}
			}while (user == null);
			return user!;
		}

		private static User? Login() {
			var userFunctions = new UserFunctions(RepositoryFactory.Create<UserRepository>());

			var x = true;
			string? email;
			string? password;
			do {
				email = Inputs.StringInput("Unesi email");
				password = Inputs.StringInput("Unesi lozinku");
				//Unesi timeout za 30 sec da nije bot
				if (!EmailIsValid(email)) { 
					x = false; email = null;
					Inputs.Wait("Unio si email sa lošom strukturom");
				}
				else if (!userFunctions.EmailAndPasswordMatch(email, password)) {
					x = false;
					Inputs.Wait("Lozinka je kriva");
					email = null;
				}
				if (!x) {
					x = Inputs.OptionInput(["1 - Pokušaj ponovo", "2 - Povratak"]) == 2;
				}
			} while (!x);

			return userFunctions.FindByEmail(email)!;
		}
		 private static bool EmailIsValid(string email) {
			return true;
		}
	}
}
