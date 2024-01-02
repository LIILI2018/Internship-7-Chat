using InternshipChat.Data.Entities.Models;
using InternshipChat.Domain.Factories;
using InternshipChat.Domain.Repositories;
using InternshipChat.Presentation.Functions;
using System.Text.RegularExpressions;

namespace InternshipChat.Presentation.Utility {
	public static class Functions {
		public static User Signin() {
			var UF = new UserFunctions(RepositoryFactory.Create<UserRepository>());
			return UF.AddUser();
		}

		public static User? Login(UserFunctions UF) {/*ovo treba promijeniti da ne može biti null*/

			var email = Inputs.EmailInput();
			var UserValidated = ValidateUser(UF.FindByEmail(email));
			return UF.FindByEmail(email);
			/*var y = true;
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
				else if (!UF.EmailAndPasswordMatch(email, password)) {
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
			return UF.FindByEmail(email!)!;*/
		}

		public static bool CheckEmailStructure(string email) {
			Regex format = new Regex(@"[A-Za-z]+@[A-Za-z]+\.[A-Za-z]");
			return format.Match(email).Success;
		}

		public static bool? ValidateUser(User user) {
			var validation = Inputs.PasswordInput(user);
			validation = Captcha() && validation;
			return validation;
		}

		public static bool Captcha() {
			string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
			var txt = "";
			do {
				Console.Clear();
				for (int i = 0; i < new Random().Next(5,10); i++) { 
					txt += chars[new Random().Next(1 + 26 + 26 + 10)];
				}
                Console.WriteLine("Prepiši ovaj tekst");
                Console.WriteLine(txt);
                Console.WriteLine();
                var input = Console.ReadLine();
				if (input == txt) {
					return true;
				}
                Console.WriteLine("Pogrešno si unjeo");
				int x = Inputs.OptionInput(["1 - Pokušaj ponovo", "2 - Izađi"]);
				if (x == 2) {
					return false;
				}
			} while (true);
		}
	}
}
