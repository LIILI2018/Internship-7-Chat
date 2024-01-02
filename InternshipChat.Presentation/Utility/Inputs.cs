using InternshipChat.Domain.Factories;
using InternshipChat.Domain.Repositories;
using InternshipChat.Presentation.Functions;

namespace InternshipChat.Presentation.Utility {
	static public class Inputs {
		public static string StringInput(string txt) {
			Console.WriteLine(txt);
			var y = Console.ReadLine();
			Console.Clear();
			return y;
		}
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
		public static string EmailInput() {
			var UF = new UserFunctions(RepositoryFactory.Create<UserRepository>());

			string email;
			/*do {
				do {*/
			email = StringInput("Unesi email");
			/*} while (!Functions.CheckEmailStructure(email));
		} while (UF.DoesEmailExist(email));*/
			return email;
		}
		public static string CreatePassword() {
			string password;
			string repeatedPassword;
			do {
				password = StringInput("Unesi lozinku");
				repeatedPassword = StringInput("Ponovno unesi lozinku");
			} while (password != repeatedPassword);
			return password;
		}
	}
}
