﻿using BOL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MovieBL
    {
        private MovieDb db;

        public MovieBL()
        {
            db = new MovieDb();
        }

        public IEnumerable<Movie> GetAll()
        {
            return db.GetAll();
        }

        public Movie GetById(int id)
        {
            return db.GetById(id);
        }

        public void Insert(Movie movie)
        {
            db.Insert(movie);
        }

        public void Delete(int id)
        {
            db.Delete(id);
        }

        public void Update(Movie movie)
        {
            db.Update(movie);
        }
    }
}
