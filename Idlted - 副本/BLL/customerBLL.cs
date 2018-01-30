using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace BLL
{
    public class customerBLL
    {
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="cu"></param>
        /// <returns></returns>
        public customer selcustomer(customer cu)
        {
            string sql = " and Account = '" + cu.Account + "' and [password] = '" + cu.Pssword + "'";
            return new customerDAL().selcustomer(sql)[0];
        }
        public customer query(customer cu)
        {
            string sql = " and ID="+cu.ID;
            return new customerDAL().selcustomer(sql)[0];
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="cu"></param>
        /// <returns></returns>
        public int updatecustomer(customer cu)
        {
            return new customerDAL().updatecustomer(cu);
        }
    }
}
