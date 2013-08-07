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
			var threads = new List<Thread>();

			//TODO: add code to populate forum from server?
			
			//TEMPLATE FROM TUTORIAL EXAMPLE
			//var threads = new List<Thread> {
			//	new Thread
			//	{
			//		ThreadID = 1,
			//		ThreadName = "Convertible Car",
			//		Description = "This convertible car is fast! The engine is powered by a neutrino based battery (not included)." + 
			//					  "Power it up and let it go!", 
			//		ImagePath="carconvert.png",
			//		UnitPrice = 22.50,
			//		CategoryID = 1
			//   },
			//	new Thread 
			//	{
			//		ProductID = 2,
			//		ProductName = "Old-time Car",
			//		Description = "There's nothing old about this toy car, except it's looks. Compatible with other old toy cars.",
			//		ImagePath="carearly.png",
			//		UnitPrice = 15.95,
			//		 CategoryID = 1
			//   }
			//};

            return threads;
        }
    }
}
