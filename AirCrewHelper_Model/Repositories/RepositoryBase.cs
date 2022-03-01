using AirCrewHelper_Model.Entities;
using AirCrewHelper_Model.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirCrewHelper_Model.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        public Context _context = new Context();

        public void edit(T obj)
        {
            _context.Entry(obj).State = EntityState.Modified;
            saveChanges();
        }

        public T find(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void insert(T obj)
        {
            _context.Set<T>().Add(obj);
            saveChanges();
        }

        public IQueryable<T> list()
        {
            return _context.Set<T>();
        }

        public void remove(T obj)
        {
            _context.Set<T>().Remove(obj);
            saveChanges();
        }

        public void saveChanges()
        {
            _context.SaveChanges();
        }
    }
}
