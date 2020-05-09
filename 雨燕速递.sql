create database SwiftExpress
go
use SwiftExpress

if exists (select 1
            from  sysobjects
           where  id = object_id('UserInfo')
            and   type = 'U')
   drop table UserInfo
go

/*==============================================================*/
/* Table: UserInfo                                              */
/*==============================================================*/
--用户表
create table UserInfo (
   UserId               int                  identity,  --用户id
   UserPhone            varchar(50)          not null,  --用户手机号码
   PassWord             varchar(50)          not null,     --密码
   UserMailbox          varchar(50)          not  null,    --邮箱
   constraint PK_USERINFO primary key (UserId)
)
go

if exists (select 1
            from  sysobjects
           where  id = object_id('WaybillLnquiry')
            and   type = 'U')
   drop table WaybillLnquiry
go
--运单查询
/*==============================================================*/
/* Table: WaybillLnquiry                                        */
/*==============================================================*/
create table WaybillLnquiry (
   WaybillId            int                  identity,    -- 运单id
   FreightTotal        decimal(18,2)   not null,      --运费
   TrackingDate         datetime            not null,     --快递时间
   TrackingDetails      varchar(200)        not null,    --快递详情（到达地）
   
   TrackingState        int                 not null,    --物品状态   1待发货 2已发货3运输中4派送中5签收
   TrackingRemark                   varchar(200)         null,   --运单备注   （新增）
   CreateTime           datetime             null,--创建时间
   UpdateTime           datetime             null,--修改时间
   CreateId             int                  null,--创建人id
   UpdateId            int                  null,--修改人id
   Status              int                  null,--状态
   constraint PK_WAYBILLLNQUIRY primary key (WaybillId)
)
go


drop table WaybillLnquiry

if exists (select 1
            from  sysobjects
           where  id = object_id('Areatable')
            and   type = 'U')
   drop table Areatable
go
--地区
/*==============================================================*/
/* Table: Areatable                                             */
/*==============================================================*/
create table Areatable (
   SId                  int                  identity,
   SName                varchar(50)          not null,
   PId                  int                  not null,
   constraint PK_AREATABLE primary key (SId)
)
go


if exists (select 1
            from  sysobjects
           where  id = object_id('Contraband')
            and   type = 'U')
   drop table Contraband
go
--违禁品查询
/*==============================================================*/
/* Table: Contraband                                            */
/*==============================================================*/
create table Contraband (
   ContrabandId         int                  identity,
   ItemName             varchar(50)          not  null,
   constraint PK_CONTRABAND primary key (ContrabandId)
)
go

select * from Contraband
go



/*==============================================================*/
/* Table: 寄件信息表                                                 */
/*==============================================================*/
create table ShippingInfor(
   ShippingId                int                           not null, --编号
   ShippingOrder              varchar(50)           not null,  --快递单号
   ShippingName                 varchar(20)        not null, --寄件姓名
   ShippingPhone               varchar(20)         not null,  --寄件联系方式
   ShippingAddress                 varchar(50)     not null,  --寄件地址
   ReceiveName                 varchar(20)          not null,      --收件人姓名
   ReceivePhone                 int                      not null,         --收件联系方式
   ReceiveAddress                 varchar(50)       not  null,   --收件地址
   constraint PK_ShippingInfor primary key (ShippingId)
)
go


---------------------------------------------------------后台
/*==============================================================*/
/* Table: Administrator  管理员表                               */
/*==============================================================*/
create table Administrator (
   AdminId              int                  not null,  --管理员id     AdminId
   AdminName            varchar(50)          not null,  --管理员姓名 AdminName
   AdminPassword        varchar(50)          not null,  --管理员密码 AdminPassword
   AdminPhone           varchar(13)          not null,  --管理员电话 AdminPhone

   constraint PK_ADMINISTRATOR primary key (AdminId)     
)
go


if exists (select 1
            from  sysobjects
           where  id = object_id('Cargo')
            and   type = 'U')
   drop table Cargo
go

/*==============================================================*/
/* Table: Cargo                     货物信息表                  */
/*==============================================================*/
create table Cargo (
   CargoId              int                  not null,  --货物id
   CargoName            varchar(50)          not null,  --货物名称 
   CargoType            varchar(50)          not null,  --货物类型
   CargoWeight          int                  not null,  --货物重量
   ShippingOrder        varchar(50)         not null,  --快递单号
   constraint PK_CARGO primary key (CargoId)
)
go


if exists (select 1
            from  sysobjects
           where  id = object_id('Staff')
            and   type = 'U')
   drop table Staff
go

/*==============================================================*/
/* Table: Staff             员工信息表                          */
/*==============================================================*/
create table Staff (
   StaffId              int                  not null,--员工id
   StaffName            varchar(50)         not null, --员工姓名
   StaffSex             int                 not null, --员工性别  
   StaffAge             int                 not null, --员工年龄 
   StaffPhone           varchar(13)         not null, --员工电话
   StaffDuty            int                 not null, --员工职务（理货员，配送员）
   constraint PK_STAFF primary key (StaffId)
)
go


if exists (select 1
            from  sysobjects
           where  id = object_id('Distribution')
            and   type = 'U')
   drop table Distribution
go

/*==============================================================*/
/* Table: Distribution        配送信息表                        */
/*==============================================================*/
create table Distribution (
   DistributionId       int                  not null,   -- 配送id
   ShippingOrder        varchar(50)         not null,  --快递单号
   StaffId              int                 not null,   --员工id
   WareHouseId          int                 not null,   -- 仓库id
   PickTime             datetime            not null,   --接货时间 
   SendTime             datetime            not null,   --发货时间
   SendType             varchar(50)         not null,   --配送方式
   Status               int                 not null,   --状态
   Remark               varchar(200)         null,      --备注
   constraint PK_DISTRIBUTION primary key (DistributionId)
)
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Storage')
            and   type = 'U')
   drop table Storage
go

/*==============================================================*/
/* Table: Storage            存储信息表                         */
/*==============================================================*/
create table Storage (
   StorageId            int primary key identity                  not null,	  -- 存储id 
   CargoId              int                 not null,	  -- 货物id
   WareHouseId          int                 not null,	  -- 仓库id
   StaffId              int                 not null,	  -- 员工id
   InStorageTime        datetime            not null,	  -- 入库时间
   InStorageNumber      int                 not null,	  -- 入库数量
   OutStorageTime       datetime            not null,	  -- 出库时间
   OutStorageNumber     int                 not null,	  -- 出库数量
   CreateTime           datetime             null,--创建时间
   UpdateTime           datetime             null,--修改时间
   CreateId             int                  null,--创建人id
   UpdateId            int                  null,--修改人id
   Status              int                  null,--状态
   Remark               varchar(200)        not null,     -- 备注
)
go

select * from Storage
select * from Storage where Status=0
select * from Storage s where s.Status=1
select * from Storage where Status=1
select * from Contraband
Update Storage set Status=0 where StorageId=6

if exists (select 1
            from  sysobjects
           where  id = object_id('WareHouse')
            and   type = 'U')
   drop table WareHouse
go

/*==============================================================*/
/* Table: WareHouse         仓库信息表                          */
/*==============================================================*/
create table WareHouse (
   WareHouseId          int                  not null,  --仓库id 
   WareHouseName        varchar(50)        not  null,   --仓库名称
   WareHouseCapacity    int                not  null,   --仓库容量 
   constraint PK_WAREHOUSE primary key (WareHouseId)
)
go
select * from ShippingInfor  s join Cargo c on s.ShippingOrder=c.ShippingOrder where s.ShippingOrder='1'
select * from ShippingInfor  s join Cargo c on s.ShippingOrder=c.ShippingOrder where s.ShippingOrder='lq'
