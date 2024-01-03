using InternshipChat.Data.Entities.Models;
using InternshipChat.Domain.Enums;
using InternshipChat.Domain.Repositories;
using InternshipChat.Presentation.Utility;

namespace InternshipChat.Presentation.Functions {
	public class MessageFunctions {
		private MessageRepository _messageRepository;
		public MessageFunctions(MessageRepository messageRepository) {
			_messageRepository = messageRepository;
		}
		/**/
		public List<Message> GetAllMessages() {
			return _messageRepository.GetAll();
		}
		public void Delete(Message message) {
			_messageRepository.Delete(message);
		}
		public QueryResponse CreateMessage(int userId, int canalId) {
			var title = Inputs.StringInput("Unesi naslov poruke");
			var txt = Inputs.StringInput("Unesi tekst poruke");
			var message = new Message(title, txt, userId, canalId, LastId() + 1);
			return _messageRepository.Add(message);
		}

		private int LastId() {
			List<int> allIds = [];
			foreach (var message in GetAllMessages()) {
				allIds.Add(message.Id);
			}
			return allIds.Max();
		}
		/**/
		public List<Message> GetMessagesByCanalId(int canalId) {
			List<Message> canalsMessages = [];
			foreach (var message in GetAllMessages()) {
				if (message.CanalId == canalId)
					canalsMessages.Add(message);
			}
			canalsMessages.OrderBy(Message => Message.Id).ToList();/*Ne mogu updateat bazu da koristi DateTime*/

			return canalsMessages;
		}
		public void DeleteUsersMessages(int userId) {
			var messages = GetAllMessages();
			foreach (var message in messages) {
				if (message.UserId == userId) {
					Delete(message);
				}
			}			
		}
		
	}
}
