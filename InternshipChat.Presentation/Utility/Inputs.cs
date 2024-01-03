using InternshipChat.Data.Entities.Models;
using InternshipChat.Presentation.Functions;

namespace InternshipChat.Presentation.Utility {
	static public class Inputs {
		//
		public static string StringInput(string txt) {
			Console.WriteLine(txt);
			var y = Console.ReadLine();
			Console.Clear();
			return y;
		}
		//
		public static int OptionInput(List<string> txt) {
			foreach (var item in txt) {
				Console.WriteLine(item);
			}
			int y = 0;
			bool success = false;
			do {
				success = int.TryParse(Console.ReadLine(), out y);
			} while (!success || y > txt.Count() || y < 1);
			Console.Clear();
			return y;
		}
		//!
		public static string EmailInput(UserFunctions UF, bool isEmailCreation) {
			string email;
			do {
				do {
					email = StringInput("Unesi email");
					if (Functions.CheckEmailStructure(email))
						break;
                    Outputs.Wait("Kriva struktura emaila");
                } while (true);
				if (isEmailCreation) {
					if (!UF.DoesEmailExist(email))
						break;
					Outputs.Wait("Email se već koristi");
				}
				else {
					if (UF.DoesEmailExist(email))
						break;
					Outputs.Wait("Email se ne koristi");
				}
			} while (true);
			return email;
		}
		//
		public static string CreatePassword() {
			string password;
			string repeatedPassword;
			do {
				password = StringInput("Unesi lozinku");
				repeatedPassword = StringInput("Ponovno unesi lozinku");
				if (password == repeatedPassword) {
					return password;
				}
				Outputs.Wait("Neispravan unos");
            } while (true);
		}
		//
		public static bool PasswordInput(User user) {
			do {
				var password = StringInput("Unesi lozinku");
				if (user.CheckPassword(password))
					return true;
                Console.WriteLine("Lozinka je pogrešna");
                int x = OptionInput(["1 - Pokušaj ponovo", "2 - Izađi"]);
				if (x == 2) {
					return false;
				}
			} while (true);
		}
	}
}
