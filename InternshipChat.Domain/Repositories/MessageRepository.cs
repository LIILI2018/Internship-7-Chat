using InternshipChat.Data.Entities;
using InternshipChat.Data.Entities.Models;
using InternshipChat.Domain.Enums;

namespace InternshipChat.Domain.Repositories {
	public class MessageRepository : RepositoryPreset{
		public MessageRepository(InternshipChatDbContext dbContext) : base(dbContext) { }

		public QueryResponse Add(Message message) {
			DbContext.Messages.Add(message);
			return SaveChanges();
		}
		public QueryResponse Delete(Message message) {
			//Treba provjeriti postoji li user
			DbContext.Messages.Remove(message);
			return SaveChanges();
		}
		public List<Message> GetAll() { 
			return DbContext.Messages.ToList();
		}
		public Message? FindById(int id) {
			var message = DbContext.Messages.Find(id);
			return message;/*Ako ne neđe usera vratit će null*/
		}
	}
}
