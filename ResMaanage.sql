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
alter table Users column userAvatar image
alter table Users drop column userCheckOut
select * from Users
alter table Users add  userCheckOut DateTime
insert into  Users values('Hoang','admin','ab10','1','0','1-1-1')
insert into  Users values('Huy','huy','1','1','0')
insert into  Users values('a','a','1','0','0','1-1-1')
insert into  Users values('b','b','1','0','0','1-1-1')
insert into  Users values('c','c','1','0','0','1-1-1')
insert into  Users values('d','d','1','0','0','1-1-1')
insert into  Users values('KhangHoang','admin2','1','1','1',GETDATE(),0x12311546)
insert into Users values 
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
INSERT INTO Working VALUES(1,2,DEFAULT,DEFAULT,DEFAULT,DEFAULT,DEFAULT)
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


INSERT INTO Working VALUES(1,2,DEFAULT,DEFAULT,DEFAULT,DEFAULT,DEFAULT)





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

Create Procedure USP_AddFood 
@foodName varchar(20), 
@foodQuantity int, 
@foodPrice float, 
@catID int, 
@foodPic image
as
begin
insert into Food(foodName,foodQuantity,foodPrice,catID,foodPic	) 
values (@foodName, @foodQuantity, @foodPrice, @catID, @foodPic)
end
select * from Food




create table TableFood(
	tableID int primary key identity(1,1),
	tableStatus int Default 0	
)

insert into TableFood values(0)
select * from TableFood

declare @i int = 0

while (@i<11)
begin
 update TableFood set tableStatus=0
 set @i=@i+1
end


CREATE TABLE Bill
(
	billID INT PRIMARY KEY identity(1,1),
	DateCheckIn DATE NOT NULL DEFAULT GETDATE(),
	DateCheckOut DATE ,
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
--Thêm category--

Insert dbo.Category values ('Beverage');
Insert dbo.Category values ('Grilled');
Insert dbo.Category values ('Dessert');
Insert dbo.Category values ('Alcohol');
Insert dbo.Category values ('Noodles');

--Thêm bill---
Insert into Bill values (GETDATE(),null,1,0)
Insert into Bill values (GETDATE(),null,2,0)
Insert into Bill values (GETDATE(),GETDATE(),3,1)

--thêm bill info--
Insert into BillInfo values (1,1,2)
Insert into BillInfo values (1,2,1)
Insert into BillInfo values (2,3,2)
Insert into BillInfo values (2,7,2)
Insert into BillInfo values (3,8,2)
Insert into BillInfo values (3,5,1)
 select * from BillInfo
 select * from Bill
 select * from Food where catID=2
 select * from Category	
 go
 alter proc USP_InsertBill
 @idTable Int
 as
 Begin
	
	insert Bill (DateCheckIn,DateCheckOut,tableID,billStatus,discount)
	values(GETDATE(),null,@idTable,0,0)
 end
 go


alter proc USP_InsertBillInfo
 @billID int, @foodID int, @quantity int
 as
 Begin
	declare @isExistBillInfo int 
	declare @foodCount int =1
	Select @isExistBillInfo=billInfoID, @foodCount=billQuantity from BillInfo where billID=@billID and foodID=@foodID
	if(@isExistBillInfo>0)
	Begin
		declare @newQuantity int = @foodCount+@quantity 
		if(@newQuantity>0)
			 Update BillInfo set billQuantity= @foodCount+@quantity where billID=@billID and foodID=@foodID
		else
			Delete BillInfo where billID=@billID and foodID=@foodID
	end
	else
	begin
		insert BillInfo (billID,foodID,billQuantity)
		values(@billID,@foodID,@quantity)
	end
 end
 go	
 
 UPDATE Bill SET Bill.billStatus=1  WHERE Bill.billID=1

alter trigger UTG_UpdateBillInfo
 on dbo.BillInfo for insert, update
 as
 begin
		declare @billID int
		select @billID=billID from inserted
		declare @tableID int
		select @tableID=tableID from dbo.Bill where billID=@billID and billStatus=0
		declare @count int 
		select @count=count(*) from dbo.BillInfo where billID=@billID
		if(@count>0)
			update dbo.TableFood set tableStatus= 1 where tableID=@tableID
		else 
			update dbo.TableFood set tableStatus= 0 where tableID=@tableID
 end
 go
	

 alter trigger UTG_UpdateBill
 on dbo.Bill for update
 as
 begin
		Declare @billID int
		select @billID=billID from inserted
		declare @tableID int
		select @tableID=tableID from dbo.Bill where billID=@billID
		declare @count int = 0
		select @count= Count(*) from dbo.Bill where  tableID=@tableID and billStatus = 0
		if (@count = 0)
			update dbo.TableFood set tableStatus= 0 where tableID= @tableID;
 end
 go
alter Trigger UTG_UpdateTable 
 on dbo.TableFood for update
 as
 begin
	declare	@tableID int
	declare @tableStatus int
	select @tableID=tableID,@tableStatus= inserted.tableStatus from inserted
	declare @billID int
	select @billID= billID from Bill where tableID=@tableID and billStatus=0
	declare @countBillInfo int
	select @countBillInfo=count(*) from dbo.BillInfo where billID=@billID
	if(@countBillInfo>0 and @tableStatus<>1)
		update TableFood set tableStatus = 1 where tableID=@tableID
	else if(@countBillInfo<=0 and @tableStatus<>0)
		update TableFood set tableStatus = 0 where tableID=@tableID
		
 end
 go
 update TableFood set tableStatus=0
 delete BillInfo
 delete Bill
select * from  Bill
 alter table Bill add discount int
  
	select * from Bill
alter Proc USP_SwitchTable
@idTable1 int, @idTable2 int
As begin
	declare @idFirstBill int
	declare @idSecondBill int
	declare @isFirstTableEmpty int = 1
	declare @isSecondTableEmpty int = 1
	SELECT @idSecondBill = billID FROM dbo.BILL WHERE tableID=@idTable2 and billStatus=0
	SELECT @idFirstBill = billID FROM dbo.BILL WHERE tableID=@idTable1 and billStatus=0
	if(@idFirstBill is null)
	begin
		insert into Bill (DateCheckIn,DateCheckOut,tableID,billStatus)
		values (getdate(),null,@idTable1,0)
		select @idFirstBill=max(billID) from Bill where tableID=@idTable1 and billStatus=0
			
	end
	select @isFirstTableEmpty=count(*) from BillInfo where billID=@idFirstBill
	if(@idSecondBill is null)
	begin
		insert into Bill (DateCheckIn,DateCheckOut,tableID,billStatus)
		values (getdate(),null,@idTable2,0)
		select @idSecondBill=max(billID) from Bill where tableID=@idTable2 and billStatus=0
		
	end
	select billInfoID from BillInfo where billID=@idSecondBill
	select bi.billInfoID into IDBilInfoTable from BillInfo as bi where bi.billID = @idSecondBill
	update BillInfo set BillInfo.billID=@idSecondBill where BillInfo.billID=@idFirstBill
	update BillInfo set BillInfo.billID=@idFirstBill where billInfoID in ( Select * from IDBilInfoTable)
	delete Bill where tableID=@idTable1 
	drop table IDBilInfoTable
	if(@isFirstTableEmpty=1)
		update TableFood set tableStatus=0 where tableID=@idTable2
		if(@isSecondTableEmpty=1)
		update TableFood set tableStatus=0 where tableID=@idTable1 
end
go

exec  USP_SwitchTable 1, 2
alter table Bill add totalBill float

alter proc USP_getBillByDate
@dateCheckIn date, @dateCheckOut date
as
begin
select t.tableID as [Table No.], b.DateCheckIn as [Date Checkin], b.DateCheckOut as [Date Checkout], b.discount as [Discount], b.totalBill as [Total]
from TableFood as t, Bill as b
where b.DateCheckIn>=@dateCheckIn and b.DateCheckOut<=@dateCheckOut and b.billStatus=1
and t.tableID=b.tableID 
end
go