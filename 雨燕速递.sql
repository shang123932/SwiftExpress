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
--�û���
create table UserInfo (
   UserId               int                  identity,  --�û�id
   UserPhone            varchar(50)          not null,  --�û��ֻ�����
   PassWord             varchar(50)          not null,     --����
   UserMailbox          varchar(50)          not  null,    --����
   constraint PK_USERINFO primary key (UserId)
)
go

if exists (select 1
            from  sysobjects
           where  id = object_id('WaybillLnquiry')
            and   type = 'U')
   drop table WaybillLnquiry
go
--�˵���ѯ
/*==============================================================*/
/* Table: WaybillLnquiry                                        */
/*==============================================================*/
create table WaybillLnquiry (
   WaybillId            int                  identity,    -- �˵�id
   FreightTotal        decimal(18,2)   not null,      --�˷�
   TrackingDate         datetime            not null,     --���ʱ��
   TrackingDetails      varchar(200)        not null,    --������飨����أ�
   
   TrackingState        int                 not null,    --��Ʒ״̬   1������ 2�ѷ���3������4������5ǩ��
   TrackingRemark                   varchar(200)         null,   --�˵���ע   ��������
   CreateTime           datetime             null,--����ʱ��
   UpdateTime           datetime             null,--�޸�ʱ��
   CreateId             int                  null,--������id
   UpdateId            int                  null,--�޸���id
   Status              int                  null,--״̬
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
--����
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
--Υ��Ʒ��ѯ
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
/* Table: �ļ���Ϣ��                                                 */
/*==============================================================*/
create table ShippingInfor(
   ShippingId                int                           not null, --���
   ShippingOrder              varchar(50)           not null,  --��ݵ���
   ShippingName                 varchar(20)        not null, --�ļ�����
   ShippingPhone               varchar(20)         not null,  --�ļ���ϵ��ʽ
   ShippingAddress                 varchar(50)     not null,  --�ļ���ַ
   ReceiveName                 varchar(20)          not null,      --�ռ�������
   ReceivePhone                 int                      not null,         --�ռ���ϵ��ʽ
   ReceiveAddress                 varchar(50)       not  null,   --�ռ���ַ
   constraint PK_ShippingInfor primary key (ShippingId)
)
go


---------------------------------------------------------��̨
/*==============================================================*/
/* Table: Administrator  ����Ա��                               */
/*==============================================================*/
create table Administrator (
   AdminId              int                  not null,  --����Աid     AdminId
   AdminName            varchar(50)          not null,  --����Ա���� AdminName
   AdminPassword        varchar(50)          not null,  --����Ա���� AdminPassword
   AdminPhone           varchar(13)          not null,  --����Ա�绰 AdminPhone

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
/* Table: Cargo                     ������Ϣ��                  */
/*==============================================================*/
create table Cargo (
   CargoId              int                  not null,  --����id
   CargoName            varchar(50)          not null,  --�������� 
   CargoType            varchar(50)          not null,  --��������
   CargoWeight          int                  not null,  --��������
   ShippingOrder        varchar(50)         not null,  --��ݵ���
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
/* Table: Staff             Ա����Ϣ��                          */
/*==============================================================*/
create table Staff (
   StaffId              int                  not null,--Ա��id
   StaffName            varchar(50)         not null, --Ա������
   StaffSex             int                 not null, --Ա���Ա�  
   StaffAge             int                 not null, --Ա������ 
   StaffPhone           varchar(13)         not null, --Ա���绰
   StaffDuty            int                 not null, --Ա��ְ�����Ա������Ա��
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
/* Table: Distribution        ������Ϣ��                        */
/*==============================================================*/
create table Distribution (
   DistributionId       int                  not null,   -- ����id
   ShippingOrder        varchar(50)         not null,  --��ݵ���
   StaffId              int                 not null,   --Ա��id
   WareHouseId          int                 not null,   -- �ֿ�id
   PickTime             datetime            not null,   --�ӻ�ʱ�� 
   SendTime             datetime            not null,   --����ʱ��
   SendType             varchar(50)         not null,   --���ͷ�ʽ
   Status               int                 not null,   --״̬
   Remark               varchar(200)         null,      --��ע
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
/* Table: Storage            �洢��Ϣ��                         */
/*==============================================================*/
create table Storage (
   StorageId            int primary key identity                  not null,	  -- �洢id 
   CargoId              int                 not null,	  -- ����id
   WareHouseId          int                 not null,	  -- �ֿ�id
   StaffId              int                 not null,	  -- Ա��id
   InStorageTime        datetime            not null,	  -- ���ʱ��
   InStorageNumber      int                 not null,	  -- �������
   OutStorageTime       datetime            not null,	  -- ����ʱ��
   OutStorageNumber     int                 not null,	  -- ��������
   CreateTime           datetime             null,--����ʱ��
   UpdateTime           datetime             null,--�޸�ʱ��
   CreateId             int                  null,--������id
   UpdateId            int                  null,--�޸���id
   Status              int                  null,--״̬
   Remark               varchar(200)        not null,     -- ��ע
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
/* Table: WareHouse         �ֿ���Ϣ��                          */
/*==============================================================*/
create table WareHouse (
   WareHouseId          int                  not null,  --�ֿ�id 
   WareHouseName        varchar(50)        not  null,   --�ֿ�����
   WareHouseCapacity    int                not  null,   --�ֿ����� 
   constraint PK_WAREHOUSE primary key (WareHouseId)
)
go
select * from ShippingInfor  s join Cargo c on s.ShippingOrder=c.ShippingOrder where s.ShippingOrder='1'
select * from ShippingInfor  s join Cargo c on s.ShippingOrder=c.ShippingOrder where s.ShippingOrder='lq'
