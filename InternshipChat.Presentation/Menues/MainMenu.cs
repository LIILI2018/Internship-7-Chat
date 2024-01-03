using InternshipChat.Data.Entities.Models;
using InternshipChat.Presentation.Functions;
using InternshipChat.Presentation.Utility;

namespace InternshipChat.Presentation.Menues
{
    public static class MainMenu
    {
        public static bool Create(UserFunctions UF,CanalFunctions CF, UserCanalFunctions UCF, MessageFunctions MF, User user)
        {
            Console.Clear();
            int x;
            if (user.IsAdmin)            
                x = Inputs.OptionInput(["1 - Grupni kanali", "2 - Privatne poruke", "3 - Postavke profila", "4 - Odjava iz profila", "5 - User managment"]);            
            else            
                x = Inputs.OptionInput(["1 - Grupni kanali", "2 - Privatne poruke", "3 - Postavke profila", "4 - Odjava iz profila"]);
            
            switch (x)
            {
                case 1:
                    GroupCanals.Submenu(UF, CF, UCF, MF, user);
					return false;
				case 2:
                    PrivateCanals.Submenu(UF, CF, UCF, MF, user);
					return false;
				case 3:
                    ProfileSettings.Submenu(UF, user);
					return false;
				case 4:
					return true;
				case 5:
                    UserManagment.Submenu(UF, CF, UCF, MF, user);
					return false;
                default:
                    return false;
			}
		}
    }
}
