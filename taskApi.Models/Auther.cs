using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication10.Models;

namespace taskApi.Models
{
    class Auther
    {
        public int Id { get; set; }
        
        public String fullname { get; set; }
        public string city { get; set; }
        public ICollection<todo> todos { get; set; } = new List<todo>();
       
    }

}
