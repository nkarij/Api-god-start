using GodStartAPI.Context;
using GodStartAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GodStartAPI.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _context;

        public CategoryRepository(AppDbContext context)
        {
            _context = context;
        }

        public ICollection<Category> GetAllCategories()
        {
            var result = _context.Categories.ToList();
            return result;
        }

    }
}
