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
            CourseService topCoursesService = new CourseService();
            
            MainPageModel model = new MainPageModel();
            model.News = newsService.GetAllNews();
            model.Courses = topCoursesService.GetTopCourses();
            
            model.Categories = categoryService.GetAllCategory();
            return View(model);
        }

        public ActionResult News(int id)
        {
            CategoryService categoryService = new CategoryService();
            NewsService newsService = new NewsService();
            CourseService CoursesService = new CourseService();

            NewsModel model = new NewsModel();
            model.News = newsService.GetAllNews();
            model.Courses = CoursesService.GetTopCourses();
            model.CurrentNews = newsService.GetNews(id);
            model.Categories = categoryService.GetAllCategory();
            return View(model);
        
        }

        public ActionResult AllNews(string mode)
        {
            CategoryService categoryService = new CategoryService();
            NewsService newsService = new NewsService();
            CourseService topCoursesService = new CourseService();

            MainPageModel model = new MainPageModel();
            model.News = newsService.GetAllNews();
            model.Courses = topCoursesService.GetTopCourses();

            model.Categories = categoryService.GetAllCategory();
            return View(model);

        }

        public ActionResult Categories(int id)
        {
            CategoryService categoryService = new CategoryService();
            NewsService newsService = new NewsService();
            CourseService topCoursesService = new CourseService();

            CategoriesModel model = new CategoriesModel();
            model.News = newsService.GetAllNews();
            model.Courses = topCoursesService.GetTopCourses();
            model.Categories = categoryService.GetAllCategory();
            model.CurentCategory = categoryService.GetCategory(id);
            return View(model);

        }
   }
}
