using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;

namespace DAL
{
    public class MovieReviewsDb
    {
        private MovieVaultEntities db;

        public MovieReviewsDb()
        {
            db = new MovieVaultEntities();
        }

        public IEnumerable<MovieReview> GetAll()
        {
            return db.MovieReviews.ToList();
        }

        public MovieReview GetById(int id)
        {
            return db.MovieReviews.Find(id);
        }

        public void Insert(MovieReview review)
        {
            db.MovieReviews.Add(review);
            Save();
        }

        public void Delete(int id)
        {
            var review = db.MovieReviews.Find(id);
            db.MovieReviews.Remove(review);
            Save();
        }

        public void Update(MovieReview review)
        {
            db.Entry(review).State = EntityState.Modified;
            Save();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
