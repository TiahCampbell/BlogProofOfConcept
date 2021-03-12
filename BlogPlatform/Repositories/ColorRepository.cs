using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog_template_practice.Models;

namespace blog_template_practice.Repositories
{
    public class ColorRepository : Repository<Color>, IRepository<Color>
    {
        public ColorRepository(BlogContext db) : base(db)
        {

        }
    }
}
