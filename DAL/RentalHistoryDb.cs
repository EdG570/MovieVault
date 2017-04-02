using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;

namespace DAL
{
    public class RentalHistoryDb
    {
        private MovieVaultEntities db;

        public RentalHistoryDb()
        {
            db = new MovieVaultEntities();
        }

        public IEnumerable<RentalHistory> GetAll()
        {
            return db.RentalHistories.ToList();
        }

        public RentalHistory GetById(int id)
        {
            return db.RentalHistories.Find(id);
        }

        public void Insert(RentalHistory history)
        {
            db.RentalHistories.Add(history);
            Save();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
