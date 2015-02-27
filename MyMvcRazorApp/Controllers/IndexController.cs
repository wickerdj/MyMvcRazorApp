using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMvcRazorApp.Controllers
{
    public class IndexController : Controller
    {
        public ActionResult Index()
        {
			List<IndexModel> newList = new List<IndexModel> ();

			IndexModel newIndexModel = new IndexModel {
				ID = 1,
				Description = "First Item",
				Comments = "This is the first instance of the Model"
			};

			IndexModel newIndexModel2 = new IndexModel {
				ID = 2,
				Description = "Second Item",
				Comments = "This is the second instance of the Model"
			};

			newList.Add (newIndexModel);
			newList.Add (newIndexModel2);

			return View (newList);
        }
    }
}
