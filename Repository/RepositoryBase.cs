using Microsoft.EntityFrameworkCore;
using PRNProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRNProject.Repository
{
    public class ReposistoryBase<T> where T : class
    {
        private readonly PRNProjectContext context;
        private readonly DbSet<T> dbSet;

        public ReposistoryBase()
        {
            context = new PRNProjectContext();
            dbSet = context.Set<T>();
        }

        public List<T> GetAll()
        {
            return dbSet.ToList();
        }

        public bool Add(T item)
        {
            dbSet.Add(item);
            context.SaveChanges();
            return true;
        }
        public void Delete(T entity)
        {
            dbSet.Remove(entity);
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            var tracker = context.Attach(entity);
            tracker.State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
