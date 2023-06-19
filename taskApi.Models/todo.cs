using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication10.Models
{
    public class todo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string description { get; set; }
        public status status { get; set; }
    }
}
