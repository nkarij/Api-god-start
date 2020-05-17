using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GodStartAPI.Models
{
    public class Location
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int PostNumberId { get; set; }
        public PostNumber PostNumber { get; set; }
        
    }
}
