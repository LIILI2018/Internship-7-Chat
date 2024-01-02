using InternshipChat.Data.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace InternshipChat.Data.Seeds {
	public static class Seeder {
		public static void Seed(ModelBuilder builder) {
			builder.Entity<User>()
			.HasData(new List<User>
			{
				new User(1,"Ivan", "Racetin","IvanRaca@gmail.com","RacaJeNajbolji",true),
				new User(2,"Toni", "Cetinski","Muzika@gmail.com","321123",true),
				new User(3,"Luko", "Paljetak","Pjesništvo1000@gmail.com","12345",true),
				new User(4,"Mihaela", "Orah","RibeSuNajbolje@gmail.com","VoxPopuli123",true),
				new User(5,"Marin", "Zika","Korona123@gmail.com","0987654321234567890",false),
				new User(6,"Vojko", "V","BiliPivac@gmail.com","EpskiHahač",false),
				new User(7,"Zoran", "Tadija","Zoran321@gmail.com","TomCruse",false),
				new User(8,"Željko", "Veliki","ZV@gmail.com","Raketa123",false),
				new User(9,"Željko", "Veliki","ZM@gmail.com","Vlak123",false),
				new User(10,"Veran", "Brkan","VEDROORDEV@gmail.com","Šifra",false),
				new User(11,"Marin", "Getaldić","MarioDživo2@gmail.com","NeMaM ŠiFrU",false),
				new User(12,"Dino", "Dujmović","DinoD.@gmail.com","DDDDd",true),
				new User(13,"Dino", "Dujmović","aa","aa",true),
				new User(14,"Dino", "Dujmović","aaa","aa",true)

			});
			builder.Entity<Canal>()
			.HasData(new List<Canal>
			{
				new Canal(1, Enums.CanalType.Private,"Ivan-Toni"),
				new Canal(2, Enums.CanalType.Public,"Kanal za admine"),
				new Canal(3, Enums.CanalType.Public,"Kanal za sve"),
				new Canal(4, Enums.CanalType.Private,"Dino-Zoran")
			});
			builder.Entity<UserCanal>()
			.HasData(new List<UserCanal>
			{
				new UserCanal(1,1),
				new UserCanal(2,1),
				new UserCanal(2,2),
				new UserCanal(3,2),
				new UserCanal(4,2),
				new UserCanal(12,2),
				new UserCanal(1,3),
				new UserCanal(2,3),
				new UserCanal(3,3),
				new UserCanal(4,3),
				new UserCanal(5,3),
				new UserCanal(6,3),
				new UserCanal(7,3),
				new UserCanal(8,3),
				new UserCanal(9,3),
				new UserCanal(10,3),
				new UserCanal(11,3),
				new UserCanal(12,3),
				new UserCanal(7,4),
				new UserCanal(12,4),

			});

			builder.Entity<Message>()
			.HasData(new List<Message> { 			
			new Message("Dadada","Pokemoni",1,3,1),
			new Message("1","Jabuka je crvena",1,1,2),
			new Message("2","Lorem ipsum dolor sit amet",1,2,3),
			new Message("3","kako si",1,2,4),
			new Message("4","Si akako",4,2,5),
			new Message("5","A tout le monde",3,2,6),
			new Message("6","A tout mes amies",2,3,7),
			new Message("7","Je vus aime ",5,3,8),
			new Message("8","Megadeath",3,3,9),
			new Message("9","Sunce siješe bijelom bojom",6,3,10),
			new Message("Kako si","si kako",4,3,11),
			});
		}
	}
}
