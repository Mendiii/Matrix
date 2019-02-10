using MatrixProj.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MatrixProj.Controllers
{
    public class HomeController : Controller
    {
        //welcome page
        public ActionResult Index()
        {
            return View();
        }

        //searching page
        public ActionResult SearchingRepositories()
        {
            return View();
        }

        //Bookmark page
        public ActionResult DisplayBookmarks()
        {
            List<ItemModel> BookmarkList = new List<ItemModel>();
            if (Session["Bookmarks"] != null)
            {
                BookmarkList = (List<ItemModel>)Session["Bookmarks"];
            }
            return View(BookmarkList);
        }


        //saving result to user session
        public void SaveBookmarkToSession(ItemModel bookmarkItem)
        {
            List<ItemModel> BookmarkList = new List<ItemModel>();

            if (Session["Bookmarks"] != null)
            {
                var elements = (List<ItemModel>)Session["Bookmarks"];
                foreach (var e in elements)
                {
                    if (e.id == bookmarkItem.id)
                    {
                        return;
                    }
                    BookmarkList.Add(e);
                }
                BookmarkList.Add(bookmarkItem);
                Session["Bookmarks"] = BookmarkList;
            }
            else
            {
                BookmarkList.Add(bookmarkItem);
                Session["Bookmarks"] = BookmarkList;
            }
        }

    }
}