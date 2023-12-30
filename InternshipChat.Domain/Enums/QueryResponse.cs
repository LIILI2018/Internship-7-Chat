using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternshipChat.Domain.Enums {
	public enum QueryResponse {
		Success,
		NotFound,
		AlreadyExists,
		NoChanges,
		ValidationError
	}
}
