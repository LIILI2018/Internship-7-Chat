using InternshipChat.Data.Entities.Models;
using InternshipChat.Domain.Factories;
using InternshipChat.Domain.Repositories;
using InternshipChat.Presentation.Functions;

namespace InternshipChat.Presentation.Utility {
	public static class Functions {
		public static User Signin() {
			var UF = new UserFunctions(RepositoryFactory.Create<UserRepository>());
			return UF.AddUser();
		}

		public static User? Login() {/*ovo treba promijeniti da ne može biti null*/
			var userFunctions = new UserFunctions(RepositoryFactory.Create<UserRepository>());

			var y = true;
			string? email;
			string? password;
			do {
				email = Inputs.StringInput("Unesi email");
				password = Inputs.StringInput("Unesi lozinku");
				//Unesi timeout za 30 sec da nije bot
				if (!CheckEmailStructure(email)) {
					y = false; email = null;
					Outputs.Wait("Unio si email sa lošom strukturom");
				}
				else if (!userFunctions.EmailAndPasswordMatch(email, password)) {
					y = false; email = null;
					Outputs.Wait("Email ili lozinka su krivi");
				}
				if (!y) {
					y = Inputs.OptionInput(["1 - Pokušaj ponovo", "2 - Povratak"]) == 2;
				}
			} while (!y);
			if (email == null) {
				return null;
			}
			return userFunctions.FindByEmail(email!)!;
		}

		public static bool CheckEmailStructure(string email) {
			return true;/*Captcha i email format*/
		}
	}
}
