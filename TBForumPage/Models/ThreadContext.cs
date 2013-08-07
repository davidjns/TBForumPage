using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TBForumPage.Models
{
	public class ThreadContext : DbContext
	{
		public ThreadContext()
			: base("TBForum")
		{
		}
		public DbSet<Category> Categories { get; set; }
		public DbSet<Thread> Threads { get; set; }
	}
}