using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICommerce.Domain.Entities
{
    public class Department : Entity
    {
        public string Name { get; set; }
        public ICollection<Category> Categories { get; set; }
    }
}
