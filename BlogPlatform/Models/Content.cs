using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace blog_template_practice.Models
{
    public class Content
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string Author { get; set; }
        [Display(Name = "Posted on:")]
        public string PublishDate { get; set; } = Convert.ToString(DateTime.Now);
        public string Image { get; set; } = "Images/Default.jpg";
        [Display(Name = "Category")]
        public int CategoryId { get; set; }
        public virtual Category category { get; set; }
        [Display(Name = "Color Theme")]
        public int ColorId { get; set; }
        public virtual Color color { get; set; }

        public Content()
        {

        }

        public Content(int id, string title, string body, string author, string publishDate, string image, int categoryId, int colorId)
        {
            Id = id;
            Title = title;
            Body = body;
            Author = author;
            Image = image;
            PublishDate = publishDate;
            CategoryId = categoryId;
            ColorId = colorId;
        }
    }
}
