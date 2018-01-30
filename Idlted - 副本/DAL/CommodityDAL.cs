using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlClient;

namespace DAL
{
    public class CommodityDAL
    {
        public List<Commodity> selCommodity( int id)
        {
            List<Model.Commodity> cus = new List<Model.Commodity>();
            Commodity sut = null;
            SqlParameter[] p = { new SqlParameter("@id", id) };
            if (DBHerpel.OpenConnection())
            {
                SqlDataReader dr = DBHerpel.Commodity("proc_Commodity", p);
                if (dr != null)
                {
                    while (dr.Read())
                    {
                        sut = new Commodity();
                        sut.ID = (int)dr["ID"];
                        sut.Commodityname = dr["Commodityname"] as string;
                        sut.assignor = (int)dr["assignor"];
                        sut.CommodityTypeID = (int)dr["CommodityTypeID"];
                        sut.Imageurl = dr["Imageurl"].ToString();
                        sut.transferprice =Convert.ToDouble(dr["transferprice"]);
                        sut.originalprice = Convert.ToDouble(dr["originalprice"]);
                        sut.colour = dr["colour"] as string;
                        sut.Adress = dr["Adress"] as string;
                        sut.contact = dr["contact"] as string;
                        sut.commintroduce = dr["commintroduce"] as string;
                        sut.EditTime = dr["EditTime"].ToString();
                        sut.browsenum = (int)dr["browsenum"];
                        sut.State = (int)dr["State"];
                        sut.Name = dr["Name"] as string;
                        cus.Add(sut);
                    }
                }
                DBHerpel.CloseConnection();
            }
            return cus;
        }
    }
}
