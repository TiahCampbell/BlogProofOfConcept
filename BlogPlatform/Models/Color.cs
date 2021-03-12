using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog_template_practice.Models
{
    public class Color
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Content> Contents { get; set; }

        public Color()
        {

        }
        public Color(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
