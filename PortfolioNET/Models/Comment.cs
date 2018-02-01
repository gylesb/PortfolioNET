using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PortfolioNET.Models
{
	[Table("Comments")]
	public class Comment
	{
		public Comment(string thisAuthor, string thisNote, int thisId)
		{
			id = thisId;
			Author = thisAuthor;
			Note = thisNote;
		}

		public Comment()
		{

		}

		[Key]
		public int id { get; set; }
		public string Author { get; set; }
		public string Note { get; set; }
		public int PostId { get; set; }
		public virtual Post Posts { get; set; }

	}
}