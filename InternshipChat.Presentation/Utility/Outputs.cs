using InternshipChat.Data.Entities.Models;
using InternshipChat.Presentation.Functions;


namespace InternshipChat.Presentation.Utility {
	public static class Outputs {
		public static void Wait(string txt) {
			Console.WriteLine(txt);
			Console.WriteLine("Klikni enter za nastavak: ");
			Console.ReadLine();
		}
		public static void WriteMessage( UserFunctions UF, Message message) {
            Console.WriteLine($"\n{ UF.GetUserById( message.UserId)!.Name}: {message.Title}\n{message.Content}");
		}
	}
}
