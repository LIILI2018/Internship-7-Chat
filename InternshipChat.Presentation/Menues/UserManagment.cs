﻿using InternshipChat.Data.Entities.Models;
using InternshipChat.Domain.Enums;
using InternshipChat.Presentation.Functions;
using InternshipChat.Presentation.Utility;

namespace InternshipChat.Presentation.Menues {
	public static class UserManagment {
		public static void Submenu(UserFunctions UF, CanalFunctions CF, UserCanalFunctions UCF, User user) {
			var x = Inputs.OptionInput(["1 - Izbriši profil", "2 - Postavi kao Admina", "3 - Uređivanje profila", "4 - Unesi korisnika u kanal","5 - Izlaz"]);
			var userToChange = UF.SelectUser();
			switch (x) {
				case 1:
					Console.WriteLine(UF.DeleteUser(userToChange));
					break;
				case 2:
                    Console.WriteLine(UF.UpdateUser(userToChange, UserVariableChange.AdminStatus,""));
					break;
				case 3:
                    Console.WriteLine("Uređivanje profila");
                    x = Inputs.OptionInput(["1 - Promijeni Ime", "2 - Promijeni prezime", "3 - Promijeni email", "4 - Promijeni šifru", "5 - Promijeni status admina", "6 - Izlaz"]);
					switch (x) {
						case 1:
							Console.WriteLine(UF.UpdateUser(userToChange, UserVariableChange.Name, Inputs.StringInput("Unesi novo ime korisnika")));
							break;
						case 2:
							Console.WriteLine(UF.UpdateUser(userToChange, UserVariableChange.Surename, Inputs.StringInput("Unesi novo prezime korisnika")));
							break;
						case 3:
							Console.WriteLine(UF.UpdateUser(userToChange, UserVariableChange.Name, Inputs.CreateEmail(UF)));
							break;
						case 4:
							Console.WriteLine(UF.UpdateUser(userToChange, UserVariableChange.Password, Inputs.CreatePassword()));
							break;
						case 5:
							Console.WriteLine(UF.UpdateUser(userToChange, UserVariableChange.AdminStatus, ""));
							break;
						default:
							break;
					}
					break;
				case 4:
					var canal = CF.SelectCanal(UCF);
					Console.WriteLine( UCF.CreateUserCanal(userToChange, canal));
					break;
				default:
					break;
			}
		}
	}
}
