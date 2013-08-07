using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TBForumPage.Models
{
	public class ThreadDatabaseInitializer : DropCreateDatabaseIfModelChanges<ThreadContext>
    {
        protected override void Seed(ThreadContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetThreads().ForEach(p => context.Threads.Add(p));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Regular Post"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Question"
                }
            };

            return categories;
        }

        private static List<Thread> GetThreads()
        {
			var threads = new List<Thread> {
				new Thread
				{
					ThreadID = 1,
					ThreadName = "Test thread",
					MainBody = "Here is the body of this test thread. It has words and stuff in it!",
					ImagePath = "BearPaw.jpg",
					CategoryID = 1
			   },
			   new Thread
				{
					ThreadID = 2,
					ThreadName = "Test thread a",
					MainBody = "Here is the body of this test thread. It has words and stuff in it!",
					ImagePath = "BearPaw.jpg",
					CategoryID = 1
			   },
			   new Thread
				{
					ThreadID = 3,
					ThreadName = "Test thread2",
					MainBody = "Here is the body of this test thread. It has words and stuff in it!",
					ImagePath = "BearPaw.jpg",
					CategoryID = 2
			   }
			};

            return threads;
        }
    }
}
