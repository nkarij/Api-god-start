using GodStartAPI.Context;
using GodStartAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GodStartAPI.Repositories
{
    public class JobRepository : IJobRepository
    {
        private readonly AppDbContext _context;

        public JobRepository(AppDbContext context)
        {
            _context = context;
        }

        public ICollection<Job> GetAllJobs()
        {

            var result = _context.Jobs.OrderByDescending(j => j.CreationDate).ToList();
            return result;
        }

        public ICollection<Job> GetJobsByCategory(int categoryId)
        {
            var result = _context.Jobs.Where(j => j.CategoryId == categoryId).ToList();
            return result;
        }

    }
}
