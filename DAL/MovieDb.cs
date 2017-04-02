using BOL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MovieDb
    {
        private MovieVaultEntities db;

        public MovieDb()
        {
            db = new MovieVaultEntities();
        }

        public IEnumerable<Movie> GetAll()
        {
            return db.Movies.ToList();
        }

        public Movie GetById(int id)
        {
            return db.Movies.Find(id);
        }

        public void Insert(Movie movie)
        {
            db.Movies.Add(movie);
            Save();
        }

        public void Delete(int id)
        {
            var movie = db.Movies.Find(id);
            db.Movies.Remove(movie);
            Save();
        }

        public void Update(Movie movie)
        {
            db.Entry(movie).State = EntityState.Modified;
            Save();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
