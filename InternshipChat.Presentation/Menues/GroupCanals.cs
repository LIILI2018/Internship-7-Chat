using InternshipChat.Data.Entities.Models;
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
            var canalFunctions = new CanalFunctions(RepositoryFactory.Create<CanalRepository>());
            var UserCanalFunctions = new UserCanalFunctions(RepositoryFactory.Create<UserCanalRepository>());

			int x = Inputs.OptionInput(["1 - Kreiranje novog kanala", "2 - Ulazak u kanal", "3 - Ispiši sve svoje kanale"]);
            switch (x)
            {
                case 1:
                    var canal = canalFunctions.CreatePublicCanal();
                    Console.WriteLine(UserCanalFunctions.AddUserToCanal(user, canal));
                    break;
                case 2:
                    canal = canalFunctions.SelectCanal();
                    UserCanalFunctions.AddUserToCanal(user, canal);
					break;
                /*case 3:
                    WriteAllCanals();
                    break;*/
            }
        }
    }
}
