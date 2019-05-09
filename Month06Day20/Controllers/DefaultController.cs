using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;
using BLL;

namespace Month06Day20.Controllers
{
    public class DefaultController : Controller
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; } = 2;
        public int PageCount { get; set; }
        Bllopt bl = new Bllopt();
        // GET: Default
        public ActionResult Index()
        {
            PageIndex =1;           
            int Count = bl.GetKqs().Count();
            ViewBag.sl = Count;
            PageCount = Convert.ToInt32(Math.Ceiling((1.0 * Count) / PageSize).ToString());
            var list = bl.GetKqs().Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
            return View(list);
        }
        public ActionResult Sy()
        {
            PageIndex = 1;
            var list = bl.GetKqs().Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
            return View(list);
        }
        public ActionResult Syy()
        {
            PageIndex = PageIndex- 1;
            if (PageIndex == 0)
            {
                return Content("当前为第一也");
            }
            var list = bl.GetKqs().Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
            return View(list);
        }
        public ActionResult Xyy()
        {
            PageIndex = PageIndex+1;
            if (PageIndex > PageCount)
            {
                return Content("当前为最后一页");
            }
            var list = bl.GetKqs().Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
            return View(list);
        }
        public ActionResult Wy()
        {
            PageIndex = PageCount;
            var list = bl.GetKqs().Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
            return View(list);
        }
    }
}