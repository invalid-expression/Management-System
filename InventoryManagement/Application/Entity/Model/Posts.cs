using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Entity.Model
{
	public class Posts
	{
		[Key]
		public int Id { get; set; }

		public string? Title { get; set; }
	
		public string? Content {get; set; }

		public int AuthorID { get; set; }

		public DateTime CreatedAt { get; set; } = DateTime.Now;
	}
}
