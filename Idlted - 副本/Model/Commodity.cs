using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Commodity
    {
        /*ID int primary key identity(1,1),
	Commodityname varchar(108) not null,--商品名称
	assignor int foreign key (assignor) references customer(ID),--转让人ID
	CommodityTypeID int foreign key (CommodityTypeID) references CommodityType(CommodityTypeID) not null,--商品类型	
	CommtypesID int  foreign key (CommtypesID) references Commtypes(CommtypesID),
	transferprice money not null, --转让价
	originalprice money not null, --原价
	colour int not null,			--成色
	Adress varchar(36) not null,  --所在地
	contact varchar(11) ,			--联系方式
	commintroduce varchar(256) ,	--废品介绍
	EditTime date default(getdate()),--最后编辑时间
	browsenum int default(0),		--浏览次数
	[State] int default(0)			--状态*/
        public int ID { get; set; }
        public string Commodityname { get; set; }
        public int assignor { get; set; }
        public int CommodityTypeID { get; set; }
        public string Imageurl { get; set; }
        public double transferprice { get; set; }
        public double originalprice { get; set; }
        public string colour { get; set; }
        public string Adress { get; set; }
        public string contact { get; set; }
        public string commintroduce { get; set; }
        public string EditTime { get; set; }
        public int browsenum { get; set; }
        public int State { get; set; }
        public string Name { get; set; }
    }
}
