using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagazineFlowers.Data
{
    public class User : IdentityUser
    {
        public string LastName { get; set; }
        public string FullName { get; set; }

        public string DataReg { get; set; }
        public EnumRoles Role { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

    }
}
