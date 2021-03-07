using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog_template_practice.Models;

namespace blog_template_practice.Extensions
{
    public interface ISelectList
    {

        List<Color> PopulateColorList();
        List<Category> PopulateCategoryList();
        Content GetContentByTitle(string title);
    }
}
