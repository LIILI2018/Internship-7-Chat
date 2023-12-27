using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternshipChat.Data.Entities.Models {
	public class Message {
		public int Id { get; set; }
		public string Title { get; set; } = null!;
		public string Content { get; set; } = null!;

		public int UserId { get; set; }
		public int CanalId { get; set; }
		public Canal Canal { get; set; } = null!;
		public User User { get; set; } = null!;
        public Message(){}
        public Message(string title, string conent) {
			Title = title;
			Content = conent;
		}}
}
