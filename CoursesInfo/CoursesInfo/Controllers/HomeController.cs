using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CoursesInfo.Models;
using CoursesInfo.Core.Entities;

namespace CoursesInfo.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var news = GetNews();  
            return View(news);
        }

        // TODO :
        // Реализовать получение новостей из базы
        private List<NewsModel> GetNews()
        {
            List<NewsModel> news = new List<NewsModel>();
            news.Add(new NewsModel{
            Title = "Lorem ipsum dolor sit amet",
            Text = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
            Company = new Company 
                               {
                                   Name = "Lorem ipsum"
                               }
            });

            return news;
        }

        [ChildActionOnly]
        public ActionResult _TopCourses()
        {
            var courses = 1;//GetTopCourses();
            return PartialView(courses);
        }

        [ChildActionOnly]
        public ActionResult _Menu()
        {
            var menu = 1;//GetMenu();
            return PartialView(menu);
        }

    }
}
