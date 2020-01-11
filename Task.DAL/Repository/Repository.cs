using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Task.DAL.Entities;

namespace Task.DAL.Repository
{
    /// <summary>
    /// Repository fo work with database
    /// </summary>
    public class Repository
    {
        protected TaskContext Context;

        public Repository()
        {
            Context = new TaskContext();
        }
        /// <summary>
        /// Add new object in our database
        /// </summary>
        /// <param name="entity"> new entity to add in table</param>
        public void Add(Item entity)
        {
            Context.Set<Item>().Add(entity);
            Context.SaveChanges();
        }
        /// <summary>
        /// Get List all Entities in our database
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Item> GetAll()
        {
            return Context.Set<Item>().ToList();
        }
        /// <summary>
        /// Deleting an object by id
        /// </summary>
        /// <param name="id"></param>
        public void Remove(int id)
        {
            Context.Set<Item>().Remove(Context.Set<Item>().Find(id));
            Context.SaveChanges();
        }
        /// <summary>
        /// Update entity 
        /// </summary>
        /// <param name="entity"></param>
        public void Update(Item entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            Context.SaveChanges();
        }
        /// <summary>
        /// Return entity from database by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Item FindItemById(int id)
        {
            return Context.Set<Item>().Find(id);
        }


    }
}
