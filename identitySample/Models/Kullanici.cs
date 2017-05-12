using Microsoft.AspNet.Identity.EntityFramework;

namespace identitySample.Models
{
    public class Kullanici:IdentityUser
    {
        public string Ad { get; set; }

    }
}