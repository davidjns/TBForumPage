using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TBForumPage.Models
{
	public class Category
	{
		[ScaffoldColumn(false)]
		public int CategoryID { get; set; }

		[Required, StringLength(60), Display(Name = "Category")]
		public string CategoryName { get; set; }

		[Display(Name = "Category Description")]
		public string Description { get; set; }

		public virtual ICollection<Thread> Threads { get; set; }
	}
}