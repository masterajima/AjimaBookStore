using Azima1Books.DataAccess.Data;
using System;
using Azima1Books.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Azima1Books.DataAccess.Repository.IRepository;

namespace Azima1Books.DataAccess.Repository
{
    class CategoryRepository: Repository<Data.Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;

        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Data.Category category)
        {
            var objFromDb = _db.Categories.FirstOrDefault(s => s.Id == category.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = category.Name;

            }
        }
    }
}

