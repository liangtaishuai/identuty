using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace BLL
{
    public class CommodityBLL
    {
        public List<Commodity> selCommodity(int id)
        {
            return new CommodityDAL().selCommodity(id);
        }
    }
}
