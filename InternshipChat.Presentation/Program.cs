﻿using InternshipChat.Domain.Factories;
using InternshipChat.Domain.Repositories;
using InternshipChat.Presentation.Functions;
using InternshipChat.Presentation.Menues;


var UF = new UserFunctions(RepositoryFactory.Create<UserRepository>());
var CF = new CanalFunctions(RepositoryFactory.Create<CanalRepository>());
var UCF = new UserCanalFunctions(RepositoryFactory.Create<UserCanalRepository>());
var MF = new MessageFunctions(RepositoryFactory.Create<MessageRepository>());

do {
	var user = LoginSubmenu.Authentication(UF);
	do { 
		if (MainMenu.Create(UF,CF,UCF,MF,user))
			break;
	} while (true);
} while (true);

