using GodStartAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GodStartAPI.Repositories
{
    public interface IPostNumberRepository
    {
        public ICollection<PostNumber> GetAllPostNumbers();

        public void UpdatePostNumber(PostNumber model);

    }
}