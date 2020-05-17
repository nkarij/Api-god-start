using GodStartAPI.Context;
using GodStartAPI.Models;
using GodStartAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GodStartAPI.Repositories
{
    public class PostNumberRepository : IPostNumberRepository
    {
        private readonly AppDbContext _context;

        public PostNumberRepository(AppDbContext context)
        {
            _context = context;
        }


        public ICollection<PostNumber> GetAllPostNumbers()
        {
            var result = _context.PostNumbers.ToList();
            return result;
        }

        public void UpdatePostNumber(PostNumber model)
        {
            //update syntax here
            var result = _context.PostNumbers.SingleOrDefault(l => l.Id == model.Id);
            if (result != null)
            {
                result.selected = model.selected;
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Update Tag failed");
            }
        }

    }
}