using BOL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MovieReviewBL
    {
        private MovieReviewsDb db;

        public MovieReviewBL()
        {
            db = new MovieReviewsDb();
        }

        public IEnumerable<MovieReview> GetAll()
        {
            return db.GetAll();
        }

        public MovieReview GetById(int id)
        {
            return db.GetById(id);
        }

        public void Insert(MovieReview review)
        {
            db.Insert(review);
        }

        public void Delete(int id)
        {
            db.Delete(id);
        }

        public void Update(MovieReview review)
        {
            db.Update(review);
        }
    }
}
