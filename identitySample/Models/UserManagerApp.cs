﻿using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace identitySample.Models
{
    public class UserManagerApp : UserManager<Kullanici>
    {
        public UserManagerApp(IUserStore<Kullanici> store) : base(store)
        {
            
        }



      
    }
}