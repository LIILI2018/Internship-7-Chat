using InternshipChat.Data.Entities.Models;
using InternshipChat.Domain.Enums;
using InternshipChat.Presentation.Functions;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace InternshipChat.Presentation.Utility {
	public static class Functions {
		//
		public static bool CheckEmailStructure(string email) {
			Regex format = new Regex(@"[A-Za-z]+@[A-Za-z]+\.[A-Za-z]");
			return format.Match(email).Success;
		}
		//
		public static bool Captcha() {
			string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
			var txt = "";
			do {
				txt = "";
				Console.Clear();
				for (int i = 0; i < new Random().Next(5, 10); i++) {
					txt += chars[new Random().Next(26 + 26 + 10)];
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
				Console.Clear();
			} while (true);
		}
		//
		public static bool ValidateUser(User user) {
			bool validation = false;
			bool thread2Finished = false;
			var thread2 = new Thread(() =>
			{
				validation = Inputs.PasswordInput(user) && Captcha();					
			});
			thread2.Start();
			Thread.Sleep(30000);
			while (!thread2Finished) {
				return validation;
			}
			thread2.Abort();
			Console.WriteLine("pokemoni");
			return false;				
		}
		//
		public static User? Login(UserFunctions UF) {

			var email = Inputs.EmailInput(UF,false);
			var UserValidated = ValidateUser(UF.FindByEmail(email)!);
			if (!UserValidated) {
				Outputs.Wait(OperationResult.Fail.ToString());
				return null;
			}
			Outputs.Wait(OperationResult.Success.ToString());
			return UF.FindByEmail(email)!;
		}		
		//
		public static User? Signin(UserFunctions UF) {
			return UF.AddUser(UF);
		}
	}
}
