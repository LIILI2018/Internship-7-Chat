using InternshipChat.Data.Entities.Models;
using InternshipChat.Domain.Factories;
using InternshipChat.Domain.Repositories;
using InternshipChat.Presentation.Functions;
using InternshipChat.Presentation.Utility;

namespace InternshipChat.Presentation.Menues
{
    public static class LoginFunctions
    {
        public static User Authentication()
        {
            int x;
            User? user = null;
            do
            {
                x = Inputs.OptionInput(["1 - Use existing account", "2 - Create acount"]);
                switch (x)
                {
                    case 1:
                        user = Login();
                        break;
                    case 2:
                        user = Signin();
                        break;
                }
            } while (user == null);
            return user!;
        }

        private static User Signin()
        {
            var userFunctions = new UserFunctions(RepositoryFactory.Create<UserRepository>());
            return userFunctions.AddUser();
        }

        private static User? Login()
        {
            var userFunctions = new UserFunctions(RepositoryFactory.Create<UserRepository>());

            var y = true;
            string? email;
            string? password;
            do
            {
                email = Inputs.StringInput("Unesi email");
                password = Inputs.StringInput("Unesi lozinku");
                //Unesi timeout za 30 sec da nije bot
                if (!EmailIsValid(email))
                {
                    y = false; email = null;
                    Inputs.Wait("Unio si email sa lošom strukturom");
                }
                else if (!userFunctions.EmailAndPasswordMatch(email, password))
                {
                    y = false; email = null;
                    Inputs.Wait("Email ili lozinka su krivi");
                }
                if (!y)
                {
                    y = Inputs.OptionInput(["1 - Pokušaj ponovo", "2 - Povratak"]) == 2;
                }
            } while (!y);
            if (email == null)
            {
                return null;
            }
            return userFunctions.FindByEmail(email!)!;
        }

        private static bool EmailIsValid(string email)
        {
            return true;
        }
    }
}
