using System.Collections.Generic;
using System.Linq;
using Lab5.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab5.Repositories
{
    public class EfRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private readonly ApplicationContext _context;

        protected DbSet<T> Entities { get; set; }

        public EfRepository(ApplicationContext context)
        {
            _context = context;

            Entities = context.Set<T>();
        }

        public void Add(T entity)
        {
            entity.Id = GetLastId() + 1;
            Entities.Add(entity);

            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            var item = Entities.Find(entity.Id);

            if (item == null) return;

            _context.Entry(item).CurrentValues.SetValues(entity);

            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            var item = Entities.Find(entity.Id);

            Entities.Remove(item);
            _context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return Entities.ToList();
        }

        private int GetLastId()
        {
            var last = Entities.LastOrDefault();
            return last?.Id ?? 1;
        }
    }
}
