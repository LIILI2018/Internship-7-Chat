namespace InternshipChat.Presentation.Utility {
	static public class Inputs {
		// + +
		public static int IntInput(string txt) {
			Console.WriteLine(txt);
			int y;
			bool success = false;
			do {
				success = int.TryParse(Console.ReadLine(), out y);
			} while (!success);
			Console.Clear();
			return y;
		}
		// + +
		public static string StringInput(string txt) {
			Console.WriteLine(txt);
			var y = Console.ReadLine();
			Console.Clear();
			return y;
		}
		//+ +
		public static DateTime DateInput(string txt) {
			Console.WriteLine(txt);
			DateTime y;
			bool success = false;
			do {
				success = DateTime.TryParse(Console.ReadLine(), out y);
			} while (!success);
			Console.Clear();

			return y;
		}
		//+ +
		public static double DoubleInput(string txt) {
			Console.WriteLine(txt);
			double y;
			bool success = false;
			do {
				success = double.TryParse(Console.ReadLine(), out y);
			} while (!success);
			Console.Clear();

			return y;
		}
		//+ +
		public static long LongInput(string txt) {
			Console.WriteLine(txt);
			long y;
			bool success = false;
			do {
				success = long.TryParse(Console.ReadLine(), out y);
			} while (!success);
			Console.Clear();

			return y;
		}		
		//+ +
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
		// + +
		public static int RangeElementInput(int num1, int num2, string txt) {
			Console.WriteLine(txt);
			int y = 0;
			bool success = false;
			do {
				success = int.TryParse(Console.ReadLine(), out y);
			} while (!success || y < num1 || y > num2);
			Console.Clear();
			return y;
		}
		//
		public static int RandomInt(int low, int high) {
			return new Random().Next(low, high);
		}
	}
}
