using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog_template_practice.Models;
using blog_template_practice.Repositories;
using Microsoft.AspNetCore.Mvc;


namespace blog_template_practice.Controllers
{
    public class ContentController : Controller
    {
        IRepository<Content> contentRepo;

        public ContentController(IRepository<Content> contentRepo)
        {
            this.contentRepo = contentRepo;
        }

        public ViewResult Index()
        {
            var contentList = contentRepo.GetAll();
            return View(contentList);
        }

        public ViewResult Details(int id)
        {
            var content = contentRepo.GetById(id);
            return View(content);
        }
        public ViewResult Create()
        {
            var colors = contentRepo.PopulateColorList();
            var categories = contentRepo.PopulateCategoryList();

            ViewBag.Colors = colors;
            ViewBag.Categories = categories;

            return View(new Content());
        }

        [HttpPost]
        public ViewResult Create(Content model)
        {
            var colors = contentRepo.PopulateColorList();
            var categories = contentRepo.PopulateCategoryList();

            ViewBag.Colors = colors;
            ViewBag.Categories = categories;

            if (contentRepo.GetContentByTitle(model.Title) == null)
            {
                contentRepo.Create(model);
                ViewBag.Result = "You have successfully created this blog post!";
            }
            else
            {
                ViewBag.Error = "That title already exists and cannot be added.";
            }

            ModelState.Clear();

            return View();
        }

        public ViewResult CreateByCategoryId(int id)
        {
            var colors = contentRepo.PopulateColorList();
            var categories = contentRepo.PopulateCategoryList();

            ViewBag.Colors = colors;
            ViewBag.Categories = categories;


            return View(new Content() { CategoryId = id });
        }

        public ViewResult Update(int id)
        {
            var colors = contentRepo.PopulateColorList();
            var categories = contentRepo.PopulateCategoryList();

            ViewBag.Colors = colors;
            ViewBag.Categories = categories;

            var content = contentRepo.GetById(id);


            return View(content);
        }

        [HttpPost]
        public ViewResult Update(Content model)
        {

            var colors = contentRepo.PopulateColorList();
            var categories = contentRepo.PopulateCategoryList();

            ViewBag.Colors = colors;
            ViewBag.Categories = categories;

            contentRepo.Update(model);
            ViewBag.Result = "You have successfully updated this blog post!";

            return View(model);
        }
        public ViewResult Delete(int id)
        {
            var content = contentRepo.GetById(id);
            
            return View(content);
        }
        [HttpPost]
        public ActionResult Delete(Content model)
        {
            
            contentRepo.Delete(model);

            return RedirectToAction("Index");
        }
    }
}
