using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tolooco.Entity.Models
{
    public class BaseEntity<T>
    {
        [Key]
        [Required]
        public T Id { get; set; }
    }
}
