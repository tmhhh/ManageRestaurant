create database RestaurantManagement;

use RestaurantManagement;


create table Users
(
	userID int identity(1,1) primary key,
	userName varchar(20) NOT NULL,
	userNameID varchar(20) NOT NULL,
	userPassword varchar(20) NOT NULL,
	userType int NOT NULL,
	userStatus int NOT NULL,
)
alter table Users drop column userCheckOut
select * from Users
alter table Users add  userCheckOut DateTime
insert into  Users values('Hoang','admin','ab10','1','0','1-1-1')
insert into  Users values('Huy','huy','1','1','0','1-1-1')
insert into  Users values('a','a','1','0','0','1-1-1')
insert into  Users values('b','b','1','0','0','1-1-1')
insert into  Users values('c','c','1','0','0','1-1-1')
insert into  Users values('d','d','1','0','0','1-1-1')


select * from Users where userNameID=''  and userPassword='' UNION select * from Users where userID=1  


update Users set userPassword=100 where userID=1 



create table Working
(
	workingID int primary key identity(1,1),
	userID int foreign key references Users(userID),
	workingCheckIn DateTime Default Null,
	workingCheckOut DateTime Default Null  ,
	workingTime float  Default null,
	workingDate Date NOT NULL Default getDate(),
	workingShift int default null
)
drop table Working
INSERT INTO Working VALUES(1,'1-1-1',DEFAULT,DEFAULT)
INSERT INTO Working(userIDm VALUES(1,'1-1-1')


drop trigger TG_WorkingTime
create trigger TG_WorkingTime on Working after update
as
begin
	 declare @workingID int ,@userID int,@workingCheckOut DateTime ,@workingCheckIn DateTime
	 select @workingID= INSERTED.workingID,@workingCheckOut=INSERTED.workingCheckOut ,@userID=Inserted.userID
	 ,@workingCheckIn=INSERTED.workingCheckIn
	 from INSERTED
	 	
	 update Working set workingTime=Cast(DATEDIFF(SECOND,@workingCheckIn,@workingCheckOut) as float)/3600 
	 where workingID = @workingID
	 
	 
	 declare @sum float,@currentDate Date=GetDate()
	 select @sum=sum(w.workingTime)
	 from Working w
	 where w.userID=@userID and w.workingDate=@currentDate

	 if exists (select 1 from DailyWave where DailyWave.userID=@userID and DailyWave.waveDate=@currentDate)
		begin
			update DailyWave set  totalWorkingTime=@sum where DailyWave.userID=@userID and DailyWave.waveDate=@currentDate
		end
	 else
		begin 
			insert into DailyWave values(@userID,@currentDate,default,@sum) 
		end
end


select * from Working 
select * from Users

update Working set workingCheckOut='1-1-1' where workingCheckIn='2021-05-01 14:49:42.123'
INSERT INTO Working VALUES(1,'1-1-1',DEFAULT,DEFAULT)

update Working set workingTime=Cast(DATEDIFF(SECOND,workingCheckIn,workingCheckOut) as float)/3600



create table DailyWave(
 waveID int identity(1,1),
 userID int,
 waveDate Date default getdate(), 
 wave float default 0,
 totalWorkingTime float default 0,
 primary key (waveID),
 foreign key (userID) references Users(userID)

)

drop table DailyWave
truncate table DailyWave
select * from DailyWave

 select sum(w.workingTime)
	 from Working w
	 where w.userID=1 and w.workingDate='2021-05-01'

alter Procedure USP_WaveCalculate
as
	begin
	update DailyWave set wave=(0.1*50)+((totalWorkingTime-0.1)*100)  where totalWorkingTime>=0.1
	update DailyWave set wave=(totalWorkingTime*50)-((0.1-totalWorkingTime)*100)  where totalWorkingTime <0.1
	end


print 0.1077*50
Exec USP_WaveCalculate
select * from DailyWave
select * from Working
select * from Users
truncate table Working
select w.userID,userName,w.workingShift,w.workingDate from Working w,Users u where w.userID=u.userID order by 1

select count(userID) from Working where userID=2








-----period 2-------
create table Category
(
	catID int primary key identity(1,1) ,
	catName varchar(20) NOT NULL

)
drop table Category 
insert into Category values('Boiled')
create table Food
(
	foodID int primary key identity(1,1),
	foodName varchar(20) NOT NULL,
	foodQuantity int NOT NULL,
	foodPrice float NOT NULL,
	catID int foreign key references Category(catID) ON DELETE CASCADE,
	foodPic image 
)
drop table Food
truncate table Food
alter Procedure USP_AddFood @foodName varchar(20), @foodQuantity int, @foodPrice float, @catID int, @foodPic image
as
insert into Food values (@foodName, @foodQuantity, @foodPrice, @catID, @foodPic)
select * from Food




create table TableFood(
	tableID int primary key identity(1,1),
	tableStatus int Default 0	
)

insert into TableFood values(0)
select * from TableFood


CREATE TABLE Bill
(
	billID INT IDENTITY PRIMARY KEY,
	DateCheckIn DATE NOT NULL DEFAULT GETDATE(),
	DateCheckOut DATE,
	tableID INT NOT NULL,
	billStatus INT NOT NULL DEFAULT 0 -- 1: đã thanh toán && 0: chưa thanh toán
	FOREIGN KEY (tableID) REFERENCES dbo.TableFood(tableID)
)
GO

CREATE TABLE BillInfo
(
	billInfoID INT IDENTITY PRIMARY KEY,
	billID INT NOT NULL,
	foodID INT NOT NULL,
	billQuantity INT NOT NULL DEFAULT 0
	
	FOREIGN KEY (billID) REFERENCES Bill(billID),
	FOREIGN KEY (foodID) REFERENCES Food(foodID)
)