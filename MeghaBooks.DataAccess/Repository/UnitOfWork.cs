using MeghaBooks.DataAccess.Repository.IRepository;
using MeghaBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MeghaBooks.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork  // make the method public to access the class
    {
        private readonly ApplicationDbContext _db;  // the using statement 

        public UnitOfWork(ApplicationDbContext db)  // constructor  to use DI and inject to the repository
        {
            _db = db;
            Category = new CategoryRepository(_db);
            SP_Call = new SP_Call(_db);
        }

        public ICategoryRepository Category { get; private set; }

        public ISP_Call SP_Call { get; private set; }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()  //all chnages will be saved when the Save method is call at the 'parent' level
        {
            _db.SaveChanges();
        }
    }
}