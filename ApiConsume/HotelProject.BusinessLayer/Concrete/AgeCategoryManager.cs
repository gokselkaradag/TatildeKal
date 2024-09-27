using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class AgeCategoryManager : IAgeCategoryService
    {
        private readonly IAgeCategoryDal _ageCategoryDal;

        public AgeCategoryManager(IAgeCategoryDal ageCategoryDal)
        {
            _ageCategoryDal = ageCategoryDal;
        }

        public void TDelete(AgeCategory t)
        {
            _ageCategoryDal.Delete(t);
        }

        public AgeCategory TGetByID(int id)
        {
            return _ageCategoryDal.GetByID(id);
        }

        public List<AgeCategory> TGetList()
        {
            return _ageCategoryDal.GetList();
        }

        public void TInsert(AgeCategory t)
        {
            _ageCategoryDal.Insert(t);
        }

        public void TUpdate(AgeCategory t)
        {
            _ageCategoryDal.Update(t);
        }
    }
}
