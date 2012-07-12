using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CompanySite.Models;
using System.Data.Entity;
using CompanySite.Settings;
using Utility;

namespace CompanySite.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/
        CompanyEntities db = new CompanyEntities();

        public ActionResult Index()
        {
            return View();
        }


        public ActionResult CKEditor()
        {
            return View();
        }

        public ActionResult CreateNews()
        {
            NewsModel model = new NewsModel();
            var selectList = db.NewsClasses.ToList<NewsClass>().Select(a => new SelectListItem(){ Text = a.ClassName, Value = a.ClassId.ToString()});
            model.NewsClassList = selectList;  
            return View(model);
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult CreateNews(NewsModel vmNews)
        {
            var selectList = db.NewsClasses.ToList<NewsClass>().Select(a => new SelectListItem() { Text = a.ClassName, Value = a.ClassId.ToString() });
            vmNews.NewsClassList = selectList;
            vmNews.News.PostTime = DateTime.Now;
            db.News.Add(vmNews.News);
            db.SaveChanges();
            return View(vmNews);
        }

        public ActionResult NewsList2(int pageNo)
        {
            NewsModel model = new NewsModel();
            int page = pageNo == 0 ? 1 : pageNo;
            int total;
            //db.News.OrderByDescending(m => m.PostTime).Skip(ApplicationSettings.PageSize * (pageNo - 1)).Take(ApplicationSettings.PageSize);
            model.NewsList = db.News.AsQueryable().Page(pageNo,ApplicationSettings.PageSize,m=>m.PostTime,false,out total);
            model.Page = new Pagination()
            {
                Total = total,
                PageSize = ApplicationSettings.PageSize,
                CurrentPage = page,
                HasNext = pageNo * ApplicationSettings.PageSize < total,
                HasPrevious = (pageNo - 1) > 0,
                PageGroup = ApplicationSettings.PageGroup,
                BaseUrl = "NewsList2"
            };  
            return View(model);
        }

        public ActionResult ShowPagination(int pageNo)
        {
            int pageSize = 2;
            NewsModel model = new NewsModel();
            var selectList = db.NewsClasses.ToList<NewsClass>().Select(a => new SelectListItem() { Text = a.ClassName, Value = a.ClassId.ToString() });
            model.NewsClassList = selectList;
            int page = pageNo == 0 ? 1 : pageNo;
            int total = db.News.Count();
            model.Page = new Pagination()
            {
                Total = total,
                PageSize = pageSize,
                CurrentPage = page,
                HasNext = pageNo  * pageSize < total,
                HasPrevious = (pageNo - 1) > 0,
                PageGroup = 6

            };
            return View(model);
        }

    }
}
