using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskApi.services.Models
{
    public class Tododto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string description { get; set; }

        public static void Add(Tododto tododto)
        {
            throw new NotImplementedException();
        }
    }
}
