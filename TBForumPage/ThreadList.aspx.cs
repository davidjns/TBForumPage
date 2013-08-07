using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.ModelBinding;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TBForumPage.Models;

namespace TBForumPage
{
	public partial class ThreadList : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		public IQueryable<Thread> GetThreads([QueryString("id")] int? categoryID)
		{
			var _db = new TBForumPage.Models.ThreadContext();
			IQueryable<Thread> query = _db.Threads;

			if (categoryID.HasValue && categoryID > 0)
			{
				query = query.Where(p => p.CategoryID == categoryID);
			}
			return query;
		}
	}
}