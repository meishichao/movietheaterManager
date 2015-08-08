USE master
go

--创建数据库

IF EXISTS(SELECT * FROM sysdatabases where name='FilmDB')
DROP DATABASE FilmDB
GO
CREATE DATABASE FilmDB
GO

--定位当前数据库为FilmDB

USE FilmDB
GO

--创建用户表
CREATE TABLE UserInfo
(
    U_Id int PRIMARY KEY IDENTITY(1,1), --PK用户编号
	U_Name varchar(20),				    --用户名	
	U_Pwd char(6),                      --密码
	U_Type varchar(8),                  --用户类型
	
)
--插入测试数据
INSERT INTO UserInfo VALUES('罗天富','123456','售票员')
INSERT INTO UserInfo VALUES('梅世超','111111','售票员')
INSERT INTO UserInfo VALUES('明浩','123456','售票员')
INSERT INTO UserInfo VALUES('ltf','123456','管理员')

--创建影厅信息表
CREATE TABLE RoomInfo
(
    R_Id int PRIMARY KEY IDENTITY(1,1), --PK影厅编号
	R_Name varchar(20),                 --影厅名
	R_Type bit,                         --是否3D                  
	R_Scount int,                       --座位数
	
)
--插入测试数据
--INSERT INTO RoomInfo VALUES('一号厅',1,30)
--INSERT INTO RoomInfo VALUES('二号厅',0,40)
--INSERT INTO RoomInfo VALUES('三号厅',1,50)


--电影信息表
CREATE TABLE FilmInfo
(
    F_Id int PRIMARY KEY IDENTITY(1,1), --PK电影编号
	F_Name varchar(20),                 --电影名
	F_Arter varchar(50),                --演员
	F_Type bit,                         --类型3D,2D
	F_Long int,                         --影片时长分

)
--插入测试数据
--INSERT INTO FilmInfo VALUES('速度与激情','范·迪塞尔',1,130)
--INSERT INTO FilmInfo VALUES('怒火攻心','杰森·斯坦森',0,140)
--INSERT INTO FilmInfo VALUES('死灵骑士','尼古拉斯·凯奇',1,160)
--INSERT INTO FilmInfo VALUES('终结者','斯瓦辛格',0,150)

--电影场次表
CREATE TABLE DigtalInfo
(
    D_Id int PRIMARY KEY IDENTITY(1,1),             --PK场次编号
	R_Id int FOREIGN KEY REFERENCES RoomInfo(R_Id), --FK影厅编号
	F_Id int FOREIGN KEY REFERENCES FilmInfo(F_Id), --FK电影编号
	F_StartTime Datetime,                           --开始时间
	
)
--插入测试数据
--INSERT INTO DigtalInfo VALUES(1,2,'2014-05-08 21:00:00')

--创建座位表
CREATE TABLE SeatInfo
(
    S_Id int PRIMARY KEY IDENTITY(1,1),               --PK座位号
	S_Rname varchar(10),                              --座位号
	D_Id int FOREIGN KEY REFERENCES DigtalInfo(D_Id), --FK场次编号
	S_State bit,                                      --是否已选
	
)
--插入测试数据
--INSERT INTO SeatInfo VALUES('1排1号',1,0)
--INSERT INTO SeatInfo VALUES('1排2号',1,0)
--INSERT INTO SeatInfo VALUES('1排3号',1,0)
--INSERT INTO SeatInfo VALUES('1排4号',1,0)
--INSERT INTO SeatInfo VALUES('1排5号',1,0)
--INSERT INTO SeatInfo VALUES('1排6号',1,0)
--
--INSERT INTO SeatInfo VALUES('2排1号',1,0)
--INSERT INTO SeatInfo VALUES('2排2号',1,0)
--INSERT INTO SeatInfo VALUES('2排3号',1,0)
--INSERT INTO SeatInfo VALUES('2排4号',1,0)
--INSERT INTO SeatInfo VALUES('2排5号',1,0)
--INSERT INTO SeatInfo VALUES('2排6号',1,0)
--
--INSERT INTO SeatInfo VALUES('3排1号',1,0)
--INSERT INTO SeatInfo VALUES('3排2号',1,0)
--INSERT INTO SeatInfo VALUES('3排3号',1,0)
--INSERT INTO SeatInfo VALUES('3排4号',1,0)
--INSERT INTO SeatInfo VALUES('3排5号',1,0)
--INSERT INTO SeatInfo VALUES('3排6号',1,0)
--
--INSERT INTO SeatInfo VALUES('4排1号',1,0)
--INSERT INTO SeatInfo VALUES('4排2号',1,0)
--INSERT INTO SeatInfo VALUES('4排3号',1,0)
--INSERT INTO SeatInfo VALUES('4排4号',1,0)
--INSERT INTO SeatInfo VALUES('4排5号',1,0)
--INSERT INTO SeatInfo VALUES('4排6号',1,0)
--
--INSERT INTO SeatInfo VALUES('5排1号',1,0)
--INSERT INTO SeatInfo VALUES('5排2号',1,0)
--INSERT INTO SeatInfo VALUES('5排3号',1,0)
--INSERT INTO SeatInfo VALUES('5排4号',1,0)
--INSERT INTO SeatInfo VALUES('5排5号',1,0)
--INSERT INTO SeatInfo VALUES('5排6号',1,0)


--查询用户表中的所有信息
SELECT * FROM UserInfo
SELECT * FROM RoomInfo
SELECT * FROM FilmInfo
SELECT * FROM DigtalInfo
SELECT * FROM SeatInfo


