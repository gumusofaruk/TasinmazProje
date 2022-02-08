using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Core.Entities;

namespace Entities.Concrete
{
    public class User : IEntity
    {
        public long UserId { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public DateTime LastSignIn { get; set; } = DateTime.UtcNow;
        public DateTime SignUpDate { get; set; } = DateTime.UtcNow;
    }
}
