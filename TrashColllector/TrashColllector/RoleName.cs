using Microsoft.AspNet.Identity.EntityFramework;
using TrashColllector.Models;

namespace TrashColllector
{
    internal class RoleName<T>
    {
        //public RoleName roleName;
        private ApplicationDbContext context;
        private RoleName<IdentityRole> roleName1;

        //public RoleName(RoleName roleName)
        //{
        //    this.roleName = roleName;
        //}

        public RoleName(ApplicationDbContext context)
        {
            this.context = context;
        }

        public RoleName(RoleName<IdentityRole> roleName1)
        {
            this.roleName1 = roleName1;
        }
    }
}