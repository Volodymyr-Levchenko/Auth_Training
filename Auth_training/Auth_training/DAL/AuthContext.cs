using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Auth_training.DAL
{
    public class AuthContext:IdentityDbContext<IdentityUser>
    {
        public AuthContext()
            : base("AuthContext")
        {
        }
    }
}