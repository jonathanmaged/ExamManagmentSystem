using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Common;

namespace Domain.Entities
{
    public class RefreshToken : AuditableEntity
    {
        public string Token { get; set; } = string.Empty;
        public DateTime Expires { get; set; }
        public bool IsUsed { get; set; } = false;
        public bool IsRevoked { get; set; } = false;
        public bool IsActive { get; set; } = true;

        public bool IsExpired => DateTime.UtcNow >= Expires;

        public string UserId { get; set; }
    }
}
