using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog_template_practice.Models;
using blog_template_practice.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace blog_template_practice.Controllers
{
    public class ColorController : Controller
    {

        IRepository<Color> colorRepo;

        public ColorController(IRepository<Color> colorRepo)
        {
            this.colorRepo = colorRepo;
        }
    }      
}
