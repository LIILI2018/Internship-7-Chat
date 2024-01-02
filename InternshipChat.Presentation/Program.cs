using InternshipChat.Domain.Factories;
using InternshipChat.Domain.Repositories;
using InternshipChat.Presentation.Functions;
using InternshipChat.Presentation.Menues;

var UF = new UserFunctions(RepositoryFactory.Create<UserRepository>());
var CF = new CanalFunctions(RepositoryFactory.Create<CanalRepository>());
var UCF = new UserCanalFunctions(RepositoryFactory.Create<UserCanalRepository>());
var MF = new MessageFunctions(RepositoryFactory.Create<MessageRepository>()); 


var user = LoginFunctions.Authentication(UF);
do {
	MainMenu.Create(UF,CF,UCF,MF,user);
} while (true);

