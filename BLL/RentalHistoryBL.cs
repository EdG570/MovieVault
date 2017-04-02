using BOL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class RentalHistoryBL
    {
        private RentalHistoryDb db;

        public RentalHistoryBL()
        {
            db = new RentalHistoryDb();
        }

        public IEnumerable<RentalHistory> GetAll()
        {
            return db.GetAll();
        }

        public RentalHistory GetById(int id)
        {
            return db.GetById(id);
        }

        public void Insert(RentalHistory history)
        {
            db.Insert(history);
        }
    }
}
