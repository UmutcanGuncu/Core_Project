using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Reference
    {
        [Key]
        public int Id { get; set; } 
        public string CustomerName { get; set; }
        public string CustomerCompany { get; set; }
        public string CustomerComment { get; set; }

        public string  ImageUrl{ get; set; }
    }
}
