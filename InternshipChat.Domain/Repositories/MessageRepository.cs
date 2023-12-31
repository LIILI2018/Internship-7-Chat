﻿using InternshipChat.Data.Entities;
using InternshipChat.Data.Entities.Models;
using InternshipChat.Domain.Enums;

namespace InternshipChat.Domain.Repositories {
	public class MessageRepository : RepositoryPreset{
		public MessageRepository(InternshipChatDbContext dbContext) : base(dbContext) { }

		public OperationResult Add(Message message) {
			DbContext.Messages.Add(message);
			return SaveChanges();
		}
		public OperationResult Delete(Message message) {
			DbContext.Messages.Remove(message);
			return SaveChanges();
		}
		public List<Message> GetAll() { 
			return DbContext.Messages.ToList();
		}
	}
}
