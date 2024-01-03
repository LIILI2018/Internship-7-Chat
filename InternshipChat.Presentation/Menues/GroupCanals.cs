using InternshipChat.Data.Entities.Models;
using InternshipChat.Data.Enums;
using InternshipChat.Presentation.Functions;
using InternshipChat.Presentation.Utility;
//
namespace InternshipChat.Presentation.Menues
{
    public static class GroupCanals
    {
        public static void Submenu(UserFunctions UF, CanalFunctions CF, UserCanalFunctions UCF, MessageFunctions MF, User user)
        {
			int x = Inputs.OptionInput(["1 - Kreiranje novog kanala", "2 - Chat screen", "3 - Ispiši sve kanale u kojima sudjeluješ", "4 - Izlaz"]);
            switch (x)
            {
                case 1:
                    var canal = CF.CreateCanal(CanalType.Public,null,null);
                    Outputs.Wait(UCF.CreateUserCanal(user, canal).ToString());
                    break;

                case 2:
                    CF.ChatScreen(UF, CF, UCF, MF, user, CanalType.Public);                    
					break;

                case 3:
                    UCF.WriteAllUsersUserCanals(user, CF, CanalType.Public);
                    Outputs.Wait("");
                    break;
                default: break;
            }
        }
    }
}
