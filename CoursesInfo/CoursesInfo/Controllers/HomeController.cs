using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CoursesInfo.Models;
using CoursesInfo.Core.Entities;
using CoursesInfo.Business.Services;

namespace CoursesInfo.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            CategoryService categoryService = new CategoryService();
            NewsService newsService = new NewsService();
            TopCoursesService topCoursesService = new TopCoursesService();
            
            MainPageModel model = new MainPageModel();
            model.News = newsService.GetAllNews();
            model.Courses = topCoursesService.GetTopCourses();
            
            model.Categories = categoryService.GetAllCategory();
            return View(model);
        }

       
   }
}
