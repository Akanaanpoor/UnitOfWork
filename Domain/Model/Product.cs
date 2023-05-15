using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Product : BaseEntity
    {
        public int Id { get; set; }
        public int P_Price { get; set; }
        public int P_Stock { get; set; }
        public string P_Name { get; set; }
        public string P_Description { get; set; }
    }
}
