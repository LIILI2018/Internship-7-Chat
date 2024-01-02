using InternshipChat.Data.Entities.Models;
using InternshipChat.Presentation.Functions;
using InternshipChat.Presentation.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternshipChat.Presentation.Menues {
	public static class UserManagment {
		public static void Submenu(UserFunctions UF, User user) {
			var userToChange = UF.SelectUser();
			var x = Inputs.OptionInput(["1 - Izbriši profil", "2 - Postavi kao Admina", "3 - Uređivanje profila"]);
		}
	}
}
