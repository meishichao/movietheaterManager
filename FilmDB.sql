USE master
go

--�������ݿ�

IF EXISTS(SELECT * FROM sysdatabases where name='FilmDB')
DROP DATABASE FilmDB
GO
CREATE DATABASE FilmDB
GO

--��λ��ǰ���ݿ�ΪFilmDB

USE FilmDB
GO

--�����û���
CREATE TABLE UserInfo
(
    U_Id int PRIMARY KEY IDENTITY(1,1), --PK�û����
	U_Name varchar(20),				    --�û���	
	U_Pwd char(6),                      --����
	U_Type varchar(8),                  --�û�����
	
)
--�����������
INSERT INTO UserInfo VALUES('���츻','123456','��ƱԱ')
INSERT INTO UserInfo VALUES('÷����','111111','��ƱԱ')
INSERT INTO UserInfo VALUES('����','123456','��ƱԱ')
INSERT INTO UserInfo VALUES('ltf','123456','����Ա')

--����Ӱ����Ϣ��
CREATE TABLE RoomInfo
(
    R_Id int PRIMARY KEY IDENTITY(1,1), --PKӰ�����
	R_Name varchar(20),                 --Ӱ����
	R_Type bit,                         --�Ƿ�3D                  
	R_Scount int,                       --��λ��
	
)
--�����������
--INSERT INTO RoomInfo VALUES('һ����',1,30)
--INSERT INTO RoomInfo VALUES('������',0,40)
--INSERT INTO RoomInfo VALUES('������',1,50)


--��Ӱ��Ϣ��
CREATE TABLE FilmInfo
(
    F_Id int PRIMARY KEY IDENTITY(1,1), --PK��Ӱ���
	F_Name varchar(20),                 --��Ӱ��
	F_Arter varchar(50),                --��Ա
	F_Type bit,                         --����3D,2D
	F_Long int,                         --ӰƬʱ����

)
--�����������
--INSERT INTO FilmInfo VALUES('�ٶ��뼤��','����������',1,130)
--INSERT INTO FilmInfo VALUES('ŭ����','��ɭ��˹̹ɭ',0,140)
--INSERT INTO FilmInfo VALUES('������ʿ','�����˹������',1,160)
--INSERT INTO FilmInfo VALUES('�ս���','˹������',0,150)

--��Ӱ���α�
CREATE TABLE DigtalInfo
(
    D_Id int PRIMARY KEY IDENTITY(1,1),             --PK���α��
	R_Id int FOREIGN KEY REFERENCES RoomInfo(R_Id), --FKӰ�����
	F_Id int FOREIGN KEY REFERENCES FilmInfo(F_Id), --FK��Ӱ���
	F_StartTime Datetime,                           --��ʼʱ��
	
)
--�����������
--INSERT INTO DigtalInfo VALUES(1,2,'2014-05-08 21:00:00')

--������λ��
CREATE TABLE SeatInfo
(
    S_Id int PRIMARY KEY IDENTITY(1,1),               --PK��λ��
	S_Rname varchar(10),                              --��λ��
	D_Id int FOREIGN KEY REFERENCES DigtalInfo(D_Id), --FK���α��
	S_State bit,                                      --�Ƿ���ѡ
	
)
--�����������
--INSERT INTO SeatInfo VALUES('1��1��',1,0)
--INSERT INTO SeatInfo VALUES('1��2��',1,0)
--INSERT INTO SeatInfo VALUES('1��3��',1,0)
--INSERT INTO SeatInfo VALUES('1��4��',1,0)
--INSERT INTO SeatInfo VALUES('1��5��',1,0)
--INSERT INTO SeatInfo VALUES('1��6��',1,0)
--
--INSERT INTO SeatInfo VALUES('2��1��',1,0)
--INSERT INTO SeatInfo VALUES('2��2��',1,0)
--INSERT INTO SeatInfo VALUES('2��3��',1,0)
--INSERT INTO SeatInfo VALUES('2��4��',1,0)
--INSERT INTO SeatInfo VALUES('2��5��',1,0)
--INSERT INTO SeatInfo VALUES('2��6��',1,0)
--
--INSERT INTO SeatInfo VALUES('3��1��',1,0)
--INSERT INTO SeatInfo VALUES('3��2��',1,0)
--INSERT INTO SeatInfo VALUES('3��3��',1,0)
--INSERT INTO SeatInfo VALUES('3��4��',1,0)
--INSERT INTO SeatInfo VALUES('3��5��',1,0)
--INSERT INTO SeatInfo VALUES('3��6��',1,0)
--
--INSERT INTO SeatInfo VALUES('4��1��',1,0)
--INSERT INTO SeatInfo VALUES('4��2��',1,0)
--INSERT INTO SeatInfo VALUES('4��3��',1,0)
--INSERT INTO SeatInfo VALUES('4��4��',1,0)
--INSERT INTO SeatInfo VALUES('4��5��',1,0)
--INSERT INTO SeatInfo VALUES('4��6��',1,0)
--
--INSERT INTO SeatInfo VALUES('5��1��',1,0)
--INSERT INTO SeatInfo VALUES('5��2��',1,0)
--INSERT INTO SeatInfo VALUES('5��3��',1,0)
--INSERT INTO SeatInfo VALUES('5��4��',1,0)
--INSERT INTO SeatInfo VALUES('5��5��',1,0)
--INSERT INTO SeatInfo VALUES('5��6��',1,0)


--��ѯ�û����е�������Ϣ
SELECT * FROM UserInfo
SELECT * FROM RoomInfo
SELECT * FROM FilmInfo
SELECT * FROM DigtalInfo
SELECT * FROM SeatInfo


