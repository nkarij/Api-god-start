using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GodStartAPI.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Text { get; set; }
        public string ImageUrl { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ExpirationDate { get; set; }

        public bool selected { get; set; }
        public int CategoryId { get; set; }

        public int PostNumberId { get; set; }

        public int UserId { get; set; }
        public Category Category { get; set; }

        public PostNumber PostNumber { get; set; }

        public StoreUser User { get; set; }

        public ICollection<Tag> Tags { get; set; }
        

    }
}
