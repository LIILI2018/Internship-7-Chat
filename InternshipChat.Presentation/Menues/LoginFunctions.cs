using InternshipChat.Data.Entities.Models;
using InternshipChat.Presentation.Functions;
using InternshipChat.Presentation.Utility;
namespace InternshipChat.Presentation.Menues
{
    public static class LoginFunctions
    {
        public static User Authentication(UserFunctions UF)
        {
            int x;
            User? user = null;
            do
            {
                x = Inputs.OptionInput(["1 - Use existing account", "2 - Create acount"]);
                switch (x)
                {
                    case 1:
                        user = Utility.Functions.Login(UF);
                        break;
                    case 2:
                        user = Utility.Functions.Signin();
                        break;
                }
            } while (user == null);
            return user!;
        }       
    }
}
