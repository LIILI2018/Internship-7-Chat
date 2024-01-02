using InternshipChat.Data.Entities;
using InternshipChat.Presentation.Menues;


var user = LoginFunctions.Authentication();
do {
	MainMenu.Create(user);
} while (true);

