using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EfSendMessageDal : GenericRepository<SendMessage>, ISendMessageDal
    {
        public EfSendMessageDal(DataContext context) : base(context)
        {
        }

        public int GetSendCount()
        {
            var context = new DataContext();
            return context.SendMessages.Count();
        }
    }
}
