namespace InternshipChat.Data.Entities.Models {
	public class UserCanal {
		public int UserId { get; set; }
		public int CanalId { get; set; }
        public User User { get; set; } = null!;
        public Canal Canal { get; set; } = null!;
        public UserCanal(int userId, int canalId)
        {
            UserId = userId;
            CanalId = canalId;
        }
	}
}
