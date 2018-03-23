using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tolooco.Entity.Models
{
    public class User : BaseEntity<string>
    {
        public User()
        {
            Id = Guid.NewGuid().ToString();
        }

        public string Address { get; set; }
        public string FullName { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }

    }
}
