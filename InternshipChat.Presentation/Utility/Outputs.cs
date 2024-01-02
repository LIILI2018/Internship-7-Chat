using InternshipChat.Data.Entities.Models;


namespace InternshipChat.Presentation.Utility {
	public static class Outputs {
		public static void Wait(string txt) {
			Console.WriteLine(txt);
			Console.WriteLine("Klikni enter za nastavak: ");
			Console.ReadLine();
		}
		public static void WriteMessage(Message message) {
            Console.WriteLine($"\n{message.User}: {message.Title}\n{message.Content}");
		}
	}
}
