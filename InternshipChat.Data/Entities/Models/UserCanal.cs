using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternshipChat.Data.Entities.Models {
	public class UserCanal {
		public int UserId { get; set; }
		public int CanalId { get; set; }
		public Canal Canal { get; set; } = null!;
		public User User { get; set; } = null!;
	}
}
