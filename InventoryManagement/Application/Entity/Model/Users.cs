using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Entity.Model
{
    public class Users
    {
        [Key]
        public int Id { get; set; }

        public string? Username { get; set; }

        public string? Email { get; set; }

        public DateTime? CreatedAt { get; set; }
    }
}
