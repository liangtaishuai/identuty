using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlClient;

namespace DAL
{
    public class CommodityTypeDAL
    {
        public List<Model.CommodityType> GetCommodityType()
        {
            List<Model.CommodityType> books = new List<Model.CommodityType>();
            CommodityType book = null;
            if (DBHerpel.OpenConnection())
            {
                SqlDataReader dr = DBHerpel.ExecReader("select * from CommodityType where State=0");

                if (dr != null)
                {
                    while (dr.Read())
                    {
                        book = new CommodityType();
                        book.CommodityTypeID = (int)dr["CommodityTypeID"];
                        book.CommodityTypeName = dr["CommodityTypeName"] as string;
                        book.State = (int)dr["State"];
                        books.Add(book);
                    }
                }

                DBHerpel.CloseConnection();
            }

            return books;
        }
    }
}
