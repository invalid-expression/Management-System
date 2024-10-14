using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Entity.Model
{
	public class Comment
	{
		[Key]
		public int Id { get; set; }
		
		public int? PostID { get; set; }

		public int? AuthorID { get; set; }

		public string? Content { get; set; }
		
		public DateTime CreatedAt { get; set; } = DateTime.Now;

	}
}
