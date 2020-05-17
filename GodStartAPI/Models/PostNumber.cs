using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GodStartAPI.Models
{
    public class PostNumber
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public bool selected { get; set; }
        public ICollection<Job> JobList { get; set; }
        public ICollection<Location> Locations { get; set; }
        public int UserId { get; set; }
        public StoreUser User { get; set; }
    }
}
