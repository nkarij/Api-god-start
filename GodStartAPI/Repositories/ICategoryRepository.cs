using GodStartAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GodStartAPI.Repositories
{
    public interface ICategoryRepository
    {
        public ICollection<Category> GetAllCategories();

    }
}
