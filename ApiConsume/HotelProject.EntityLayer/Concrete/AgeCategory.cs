using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.EntityLayer.Concrete
{
    public class AgeCategory
    {
        public int AgeCategoryID { get; set; }
        public string AgeCategoryNumber { get; set; }
        public List<Contact> Contacts { get; set; }
    }
}
