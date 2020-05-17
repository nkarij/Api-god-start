using GodStartAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GodStartAPI.Repositories
{
    public interface IJobRepository
    {
        public ICollection<Job> GetAllJobs();
        public ICollection<Job> GetJobsByCategory(int categoryId);

    }
}
