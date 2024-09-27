using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EfAppUserDal : GenericRepository<AppUser>, IAppUserDal
    {
        public EfAppUserDal(DataContext context) : base(context)
        {
        }

        public int AppUserCount()
        {
            var context = new DataContext();
            var value = context.Users.Count();
            return value;
        }

        public List<AppUser> UserListWithWorkLocation()
        {
            var context = new DataContext();
            return context.Users.Include(x => x.WorkLocation).ToList();
        }

        public List<AppUser> UsersListWithWorkLocations()
        {
            var context = new DataContext();
            var values = context.Users.Include(x =>x.WorkLocation).ToList();
            return values;
        }
    }
}
