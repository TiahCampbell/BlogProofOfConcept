using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog_template_practice.Models
{
    public class Content
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string Author { get; set; }
        public string PublishDate { get; set; }
        public string Image { get; set; }
        public int CategoryId { get; set; }
        public virtual Category category { get; set; }
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
