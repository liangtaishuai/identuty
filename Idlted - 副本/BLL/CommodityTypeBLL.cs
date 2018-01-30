using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace BLL
{
    public class CommodityTypeBLL
    {
        public List<Model.CommodityType> GetCommodityType()
        {
            return new DAL.CommodityTypeDAL().GetCommodityType();
        }
    }
}
