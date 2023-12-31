using InternshipChat.Data.Entities.Models;
using InternshipChat.Presentation.Utility;
using System.Runtime.CompilerServices;

namespace InternshipChat.Presentation.Menues
{
    public static class MainMenu
    {
        public static void Create(User user)
        {
            int x;
            if (user.IsAdmin)
            {
                x = Inputs.OptionInput(["1 - Grupni kanali", "2 - Privatne poruke", "3 - Postavke profila", "4 - Odjava iz profila", "5 - User managment"]);
            }
            else
            {
                x = Inputs.OptionInput(["1 - Grupni kanali", "2 - Privatne poruke", "3 - Postavke profila", "4 - Odjava iz profila"]);
            }
            switch (x)
            {
                case 1:
                    GroupCanals.Submenu(user);
                    break;
                    /*case 2:
                        PrivateCanals();
                        break;
                    case 3:
                        ProfileSettings();
                        break;
                    case 4:
                        LogOut();
                        break;
                    case 5:
                        UserManagment();
                        break;*/
            }
        }
    }
}
