﻿using InternshipChat.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternshipChat.Data.Entities.Models {
	public class Canal {
		public int Id { get; set; }
        public string Name { get; set; } = null!;
        public CanalType CanalType { get; set; }
		public ICollection<UserCanal> UserCanals { get; set; } = new List<UserCanal>();
		public ICollection<Message> Messages { get; set; } = new List<Message>();
        public Canal(int id, CanalType canalType, string name)
        {
            Id = id;
            CanalType = canalType;
            Name = name;
        }
    }
}
