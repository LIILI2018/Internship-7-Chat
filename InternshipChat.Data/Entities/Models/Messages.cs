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
		/*public DateTime Created { get; set; }/* treba nekakav drugi datetime*/
		public int UserId { get; set; }
		public int CanalId { get; set; }
		public Canal Canal { get; set; } = null!;
		public User User { get; set; } = null!;
        public Message(){}

        public Message(string title, string conent, int userId, int canalId, int id) {
			Title = title;
			Content = conent;
			/*Created = DateTime.UtcNow;/**************Ne radi*/
			UserId = userId;
			CanalId = canalId;
			Id = id;
		}}
}
