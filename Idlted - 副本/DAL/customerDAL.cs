using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlClient;

namespace DAL
{
    public class customerDAL
    {
        /// <summary>
        /// 查询学生信息
        /// </summary>
        /// <param name="cu">学生信息</param>
        /// <returns></returns>
        public List<customer> selcustomer(string where)
        {
            List<Model.customer> cus = new List<Model.customer>();
            customer sut = null;
            if (DBHerpel.OpenConnection())
            {
                SqlDataReader dr = DBHerpel.ExecReader("select * from customer where State=0 "+where);

                if (dr != null)
                {
                    while (dr.Read())
                    {
                        sut = new customer();
                        sut.ID = (int)dr["ID"];
                        sut.Name = dr["Name"] as string;
                        sut.Account = dr["Account"] as string;
                        sut.Pssword = dr["password"].ToString();
                        sut.Headportrait = dr["Headportrait"] as string;
                        sut.Phone = dr["Phone"] as string;
                        sut.Email = dr["Email"] as string;
                        sut.Adress = dr["Adress"] as string;
                        sut.State = (int)dr["State"];
                        cus.Add(sut);
                    }
                }
                if(cus.Count == 0)
                {
                    sut = new customer();
                    sut.ID = -1;
                    cus.Add(sut);
                }

                DBHerpel.CloseConnection();
            }

            return cus;
        }
        /// <summary>
        /// 修改用户信息
        /// </summary>
        /// <param name="cu"></param>
        /// <returns></returns>
        public int updatecustomer(customer cu)
        {
            string sql = "update customer set State=0";
            if(!string.IsNullOrEmpty(cu.Pssword))
                sql += ",[Password]='" + cu.Pssword + "'";

            if (!string.IsNullOrEmpty(cu.Name))
                sql += ",Name='" + cu.Name + "'";

            if (!string.IsNullOrEmpty(cu.Phone))
                sql += ",Phone='" + cu.Phone + "'";

            if (!string.IsNullOrEmpty(cu.Email))
                sql += ",Email='" + cu.Email + "'";

            if (!string.IsNullOrEmpty(cu.Adress))
                sql += ",Adress='" + cu.Adress + "'";

            sql += " where ID=" +cu.ID;

            return DBHerpel.ExecQuery(sql);
        }

    }
}
