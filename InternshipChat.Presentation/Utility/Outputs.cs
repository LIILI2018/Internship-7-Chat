using InternshipChat.Data.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
