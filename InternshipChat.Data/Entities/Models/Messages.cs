using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternshipChat.Data.Entities.Models {
	public class Messages {
		public int Id { get; set; }
		public string Title { get; set; }
		public string Content { get; set; }
		public int UserId { get; set; }
		public int CanalId { get; set; }
		public Messages(string title, string conent, int userId, int canalId) {
			//Autoincremental Id
			Title = title;
			Content = conent;
			UserId = userId;
			CanalId = canalId;
		}
	}
}
