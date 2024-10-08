using Learn.DataAccess.Data;
using Learn.Entities.Models;
using Learn.Entities.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn.DataAccess.Implementaions
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        private readonly AppDbContext _context;
        public CategoryRepository(AppDbContext context) :base(context)
        {
            _context = context;   
        }
        public void Update(Category category)
        {
            var categoryInDb = _context.Categories.FirstOrDefault(x => x.Id == category.Id);
            if (categoryInDb != null)
            {
                categoryInDb.Name = category.Name;
                categoryInDb.Description = category.Description;
                categoryInDb.CreatedDate = DateTime.Now;
            }
        }
    }
}
