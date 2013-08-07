using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TBForumPage.Models
{
	public class Thread
	{
		[ScaffoldColumn(false)]
		public int ThreadID { get; set; }

		[Required, StringLength(140), Display(Name = "Thread Title")]
		public string ThreadName { get; set; }

		[Required, StringLength(10000), Display(Name = "Body"), DataType(DataType.MultilineText)]
		public string MainBody { get; set; }

		public string ImagePath { get; set; }

		public DateTime Timestamp { get; set; }

		public int? CategoryID { get; set; }

		public virtual Category Category { get; set; }
	}
}