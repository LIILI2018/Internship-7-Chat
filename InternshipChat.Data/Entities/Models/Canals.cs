using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternshipChat.Data.Entities.Models {
	public class Canal {
		public int Id { get; set; }
		public ICollection<UserCanal> UserCanals { get; set; } = new List<UserCanal>();
		public ICollection<Message> Messages { get; set; } = new List<Message>();

	}
}
