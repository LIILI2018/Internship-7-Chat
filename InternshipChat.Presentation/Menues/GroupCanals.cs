using InternshipChat.Data.Entities.Models;
using InternshipChat.Data.Enums;
using InternshipChat.Domain.Factories;
using InternshipChat.Domain.Repositories;
using InternshipChat.Presentation.Functions;
using InternshipChat.Presentation.Utility;

namespace InternshipChat.Presentation.Menues
{
    public static class GroupCanals
    {
        public static void Submenu(User user)
        {
            var CF = new CanalFunctions(RepositoryFactory.Create<CanalRepository>());
            var UCF = new UserCanalFunctions(RepositoryFactory.Create<UserCanalRepository>());
            var MF = new MessageFunctions(RepositoryFactory.Create<MessageRepository>());

			int x = Inputs.OptionInput(["1 - Kreiranje novog kanala", "2 - Ulazak u kanal", "3 - Ispiši sve svoje kanale"]);
            switch (x)
            {
                case 1:
                    var canal = CF.CreateCanal(CanalType.Public);
                    Console.WriteLine(UCF.AddUserToCanal(user, canal));
                    break;

                case 2:
                    CF.ChatScreen(CF,UCF,MF,user);                    
					break;

                case 3:
                    UCF.WriteAllUsersUserCanals(user, CF);
                    break;
            }
        }
    }
}
