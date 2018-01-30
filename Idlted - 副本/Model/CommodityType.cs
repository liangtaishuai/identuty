using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CommodityType
    {
        /*CommodityTypeID int primary key identity(1,1),--ID
	CommodityTypeName varchar(16) not null,		--分类名称
	[State] int default(0)		--状态*/
        public int CommodityTypeID { get; set; }
        public string CommodityTypeName { get; set; }
        public int State { get; set; }
    }
}
