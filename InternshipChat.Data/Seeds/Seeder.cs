using InternshipChat.Data.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace InternshipChat.Data.Seeds {
	public static class Seeder {
		public static void Seed(ModelBuilder builder) {
			builder.Entity<User>()
			.HasData(new List<User>
			{
				new User(1,"Ivan", "Racetin","IvanRaca@gmail.com","RacaJeNajbolji"),
				new User(2,"Toni", "Cetinski","Muzika@gmail.com","321123"),
				new User(3,"Luko", "Paljetak","Pjesništvo1000@gmail.com","12345"),
				new User(4,"Mihaela", "Orah","RibeSuNajbolje@gmail.com","VoxPopuli123"),
				new User(5,"Marin", "Zika","Korona123@gmail.com","0987654321234567890"),
				new User(6,"Vojko", "V","BiliPivac@gmail.com","EpskiHahač"),
				new User(7,"Zoran", "Tadija","Zoran321@gmail.com","TomCruse"),
				new User(8,"Željko", "Veliki","ZV@gmail.com","Raketa123"),
				new User(9,"Željko", "Veliki","ZM@gmail.com","Vlak123"),
				new User(10,"Veran", "Brkan","VEDROORDEV@gmail.com","Šifra"),
				new User(11,"Marin", "Getaldić","MarioDživo2@gmail.com","NeMaM ŠiFrU"),
				new User(12,"Dino", "Dujmović","DinoD.@gmail.com","DDDDd"),
			});
			builder.Entity<Canal>()
			.HasData(new List<Canal>
			{
				new Canal(1),
				new Canal(2),
				new Canal(3),
				new Canal(4),
			});
		}
	}
}
