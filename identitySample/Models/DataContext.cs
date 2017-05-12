using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace identitySample.Models
{
    public class DataContext : IdentityDbContext<Kullanici>
    {
        public DataContext() : base("DefaultCS")
        {
        }
    }
}