using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog_template_practice.Models;

namespace blog_template_practice.Repositories
{
    public class Repository<T> where T : class
    {
        private DbContext db;

        public Repository(DbContext db)
        {
            this.db = db;
        }

        public void Create(T entity)
        {
            db.Set<T>().Add(entity);
            db.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return db.Set<T>();
        }

        public T GetById(int id)
        {
            return db.Set<T>().Find(id);
        }

        public List<Color> PopulateColorList()
        {
            var colors = db.Set<Color>().ToList();

            if (colors.Count == 0)
            {
                return new List<Color>();
            }

            return colors;
        }
        public List<Category> PopulateCategoryList()
        {
            var categories = db.Set<Category>().ToList();

            if (categories.Count == 0)
            {
                return new List<Category>();
            }

            return categories;
        }
        public Content GetContentByTitle(string title)
        {
            var content = db.Set<Content>().Where(c => c.Title == title).FirstOrDefault();
            return content;
        }

        public void Update(T entity)
        {
            db.Set<T>().Update(entity);
            db.SaveChanges();
        }

        public void Delete(T entity)
        {
            db.Set<T>().Remove(entity);
            db.SaveChanges();
        }
    }
}
