/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2017                    */
/* Created on:     09/06/2024 22:56:15                          */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DETALLEFACTURA') and o.name = 'FK_DETALLEF_FK_PRODUC_PRODUCTO')
alter table DETALLEFACTURA
   drop constraint FK_DETALLEF_FK_PRODUC_PRODUCTO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DETALLEFACTURA') and o.name = 'FK_DETALLEF_RELATIONS_FACTURA')
alter table DETALLEFACTURA
   drop constraint FK_DETALLEF_RELATIONS_FACTURA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('FACTURA') and o.name = 'FK_FACTURA_RELATIONS_CLIENTE')
alter table FACTURA
   drop constraint FK_FACTURA_RELATIONS_CLIENTE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CLIENTE')
            and   type = 'U')
   drop table CLIENTE
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('DETALLEFACTURA')
            and   name  = 'RELATIONSHIP_3_FK'
            and   indid > 0
            and   indid < 255)
   drop index DETALLEFACTURA.RELATIONSHIP_3_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DETALLEFACTURA')
            and   type = 'U')
   drop table DETALLEFACTURA
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('FACTURA')
            and   name  = 'RELATIONSHIP_2_FK'
            and   indid > 0
            and   indid < 255)
   drop index FACTURA.RELATIONSHIP_2_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('FACTURA')
            and   type = 'U')
   drop table FACTURA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PRODUCTO')
            and   type = 'U')
   drop table PRODUCTO
go

/*==============================================================*/
/* Table: CLIENTE                                               */
/*==============================================================*/
create table CLIENTE (
   ID_CLIENTE           nchar(10)            not null,
   NOMBRES              nchar(100)           null,
   APELLIDOS            nchar(100)           null,
   constraint PK_CLIENTE primary key (ID_CLIENTE)
)
go

/*==============================================================*/
/* Table: DETALLEFACTURA                                        */
/*==============================================================*/
create table DETALLEFACTURA (
   ID_DETALLE_FACTURA   bigint               not null,
   ID_FACTURA           bigint               null,
   PRECIO_UNITARIO_DETALLE decimal(14,4)        null,
   IVA_DETALLE          decimal(5,2)         null,
   CANTIDAD             decimal(8,2)         null,
   SUBTOTAL_DETALLE     decimal(18,4)        null,
   TOTAL_DETALLE        decimal(18,4)        null,
   ID_PRODUCTO          bigint               null,
   constraint PK_DETALLEFACTURA primary key (ID_DETALLE_FACTURA)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_3_FK                                     */
/*==============================================================*/




create nonclustered index RELATIONSHIP_3_FK on DETALLEFACTURA (ID_FACTURA ASC)
go

/*==============================================================*/
/* Table: FACTURA                                               */
/*==============================================================*/
create table FACTURA (
   ID_FACTURA           bigint               not null,
   ID_CLIENTE           nchar(10)            null,
   FECHA_FACTURA        datetime             null,
   TOTAL_FACTURA        decimal(18,4)        null,
   SUBTOTAL_FACTURA     decimal(18,4)        null,
   constraint PK_FACTURA primary key (ID_FACTURA)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_2_FK                                     */
/*==============================================================*/




create nonclustered index RELATIONSHIP_2_FK on FACTURA (ID_CLIENTE ASC)
go

/*==============================================================*/
/* Table: PRODUCTO                                              */
/*==============================================================*/
create table PRODUCTO (
   ID_PRODUCTO          bigint               not null,
   NOMBRE_PRODUCTO      nchar(30)            null,
   PRECIO_UNITARIO      decimal(14,4)        null,
   IVA_PRODUCTO         decimal(5,2)         null,
   constraint PK_PRODUCTO primary key (ID_PRODUCTO)
)
go

alter table DETALLEFACTURA
   add constraint FK_DETALLEF_FK_PRODUC_PRODUCTO foreign key (ID_PRODUCTO)
      references PRODUCTO (ID_PRODUCTO)
go

alter table DETALLEFACTURA
   add constraint FK_DETALLEF_RELATIONS_FACTURA foreign key (ID_FACTURA)
      references FACTURA (ID_FACTURA)
go

alter table FACTURA
   add constraint FK_FACTURA_RELATIONS_CLIENTE foreign key (ID_CLIENTE)
      references CLIENTE (ID_CLIENTE)
go

