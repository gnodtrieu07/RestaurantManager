create database QuanLiNhaHang
go
use QuanLiNhaHang
go 

create table FoodTable
(
	id int identity primary key,
	nameTable nvarchar(100) not null default N'Chưa có tên' unique,
	statusTable nvarchar(100) not null default N'Trống'-- || Có người 
)
go 
create table Account
(
	UserName nvarchar(100) primary key,
	DisplayName nvarchar(100) not null default N'Nhân viên',
	PassWord nvarchar(1000) not null,
	WorkHour varchar(100) default null,
	TypeAccount int default 0--staff || 1 -- Quản lí
)
go
create table FoodCategory
(
	id int identity primary key,
	nameCategory nvarchar(100) not null default N'Chưa đặt tên' unique
)
go 
create table Food
(
	id int identity primary key,
	nameFood nvarchar(100) not null default N'Chưa đặt tên' unique,
	idCategory int not null,
	priceFood float not null default 0
	foreign key (idCategory) references FoodCategory(id)
)
go
create table Promotion
(
	id int identity primary key,
	idCategory int not null unique,
	amount int default 1,
	per int default 0,
	foreign key (idCategory) references FoodCategory(id)
)
go
CREATE table Bill
(
	id int identity primary key,
	DateCheckIn DATETIME not null default GetDate(),
	DateCheckOut DATETIME,
	idTable int not null,
	statusBill int not null default 0,--Đã thanh toán:1, chưa thanh toán:0
	discount int not null default 0,
	totalPrice float
	foreign key (idTable) references FoodTable(id)
)
GO 

create table BillInfo
(
	id int identity primary key,
	idBill int not null,
	idFood int not null,
	count int not null default 0
	foreign key(idBill) references Bill(id),
	foreign key(idFood) references Food(id)
)

GO
INSERT into Account(UserName, DisplayName, PassWord, TypeAccount) VALUES (N'root', N'Hà Nguyễn Hải Đăng', N'root', 1)
GO
INSERT into Account(UserName, DisplayName, PassWord, WorkHour, TypeAccount) VALUES (N'staff', N'Hà Đăng', N'staff',4,0)
GO


GO

go
CREATE PROC GetTableList 
AS SELECT * FROM FoodTable
GO

INSERT INTO FoodTable(nameTable) VALUES (N'Bàn 1')
go
INSERT INTO FoodTable(nameTable) VALUES (N'Bàn 2')
go
INSERT INTO FoodTable(nameTable) VALUES (N'Bàn 3')
go
INSERT INTO FoodTable(nameTable) VALUES (N'Bàn 4')
go
INSERT INTO FoodTable(nameTable) VALUES (N'Bàn 5')
go
INSERT INTO FoodTable(nameTable) VALUES (N'Bàn 6')
go
INSERT INTO FoodTable(nameTable) VALUES (N'Bàn 7')
go
INSERT INTO FoodTable(nameTable) VALUES (N'Bàn 8')
go
INSERT INTO FoodTable(nameTable) VALUES (N'Bàn 9')
go
INSERT INTO FoodTable(nameTable) VALUES (N'Bàn 10')
go
INSERT INTO FoodTable(nameTable) VALUES (N'Bàn 11')
go
INSERT INTO FoodTable(nameTable) VALUES (N'Bàn 12')
go
INSERT INTO FoodTable(nameTable) VALUES (N'Bàn 13')
go
INSERT INTO FoodTable(nameTable) VALUES (N'Bàn 14')
go
INSERT INTO FoodTable(nameTable) VALUES (N'Bàn 15')
go
INSERT INTO FoodTable(nameTable) VALUES (N'Bàn 16')
go
INSERT INTO FoodTable(nameTable)VALUES (N'Bàn 17')
go
INSERT INTO FoodTable(nameTable) VALUES (N'Bàn 18')
go
INSERT INTO FoodTable(nameTable) VALUES (N'Bàn 19')
go
INSERT INTO FoodTable(nameTable)VALUES (N'Bàn 20')
go
INSERT INTO FoodTable(nameTable) VALUES (N'Bàn 21')
go
INSERT INTO FoodTable(nameTable) VALUES (N'Bàn 22')
go
INSERT INTO FoodTable(nameTable) VALUES (N'Bàn 23')
go
INSERT INTO FoodTable(nameTable) VALUES (N'Bàn 24')
go
INSERT INTO FoodTable(nameTable) VALUES (N'Bàn 25')
go
INSERT INTO FoodTable(nameTable) VALUES (N'Bàn 26')
go
INSERT INTO FoodTable(nameTable) VALUES (N'Bàn 27')
go
INSERT INTO FoodTable(nameTable) VALUES (N'Bàn 28')
go
INSERT INTO FoodTable(nameTable) VALUES (N'Bàn 29')
go
INSERT INTO FoodTable(nameTable) VALUES (N'Bàn 30')
go
INSERT INTO FoodTable(nameTable) VALUES (N'Bàn 31')
go
INSERT INTO FoodTable(nameTable) VALUES (N'Bàn 32')
go
INSERT INTO FoodTable(nameTable) VALUES (N'Bàn 33')
go
INSERT INTO FoodTable(nameTable) VALUES (N'Bàn 34')
go
INSERT INTO FoodTable(nameTable) VALUES (N'Bàn 35')
go


-- thêm dnah mục món ăn
INSERT INTO FoodCategory(nameCategory) VALUES (N'Món chính')
go 
INSERT INTO FoodCategory(nameCategory) VALUES (N'Món tráng miệng')
go 
INSERT INTO FoodCategory(nameCategory) VALUES (N'Món khai vị')
go 
INSERT INTO FoodCategory(nameCategory) VALUES (N'Lẩu')
go 
INSERT INTO FoodCategory(nameCategory) VALUES (N'Cơm')
go 
INSERT INTO FoodCategory(nameCategory) VALUES (N'Gỏi')
go 
INSERT INTO FoodCategory(nameCategory) VALUES (N'Nước uống')
go 
-- thêm món ăn
INSERT INTO Food(nameFood, idCategory, priceFood) VALUES (N'Gà hấp lá chanh', 1, 250000)
go
INSERT INTO Food(nameFood, idCategory, priceFood) VALUES (N'Bánh mì nướng kiểu Pháp', 2, 30000)
go
INSERT INTO Food(nameFood, idCategory, priceFood) VALUES (N'Salad Caesar tôm hùm', 3, 70000)
go
INSERT INTO Food(nameFood, idCategory, priceFood) VALUES (N'Lẩu thái', 4, 270000)
go
INSERT INTO Food(nameFood, idCategory, priceFood) VALUES (N'Cơm chiên hải sản', 5, 50000)
go
INSERT INTO Food(nameFood, idCategory, priceFood) VALUES (N'Gỏi ngó sen tôm thịt', 6, 55000)
go
INSERT INTO Food(nameFood, idCategory, priceFood) VALUES (N'Nước suối', 7, 15000)
go
INSERT INTO Food(nameFood, idCategory, priceFood) VALUES (N'Trà đào', 7, 30000)
go
INSERT INTO Food(nameFood, idCategory, priceFood) VALUES (N'Trà dâu', 7, 25000)
go

-- thêm khuyến mãi
INSERT INTO Promotion(idCategory) VALUES (1)
INSERT INTO Promotion(idCategory) VALUES (2)
INSERT INTO Promotion(idCategory) VALUES (3)
INSERT INTO Promotion(idCategory) VALUES (4)
INSERT INTO Promotion(idCategory) VALUES (5)
INSERT INTO Promotion(idCategory) VALUES (6)
INSERT INTO Promotion(idCategory) VALUES (7)
go

---- thêm bill


---- thêm billinfo


GO
CREATE PROC InsertBill
@idTable INT
AS
BEGIN
	INSERT Bill(DateCheckIn, DateCheckOut, idTable, statusBill, discount)
	VALUES (GETDATE(), NULL, @idTable, 0, 0)
END


GO
CREATE PROCEDURE InsertBillInfo
@idBill INT, @idFood INT, @countFood INT
AS
BEGIN
	
	DECLARE @hasBillInfo INT
	DECLARE @foodCount INT = 1
	
	SELECT @hasBillInfo = id, @foodCount = BillInfo.count FROM BillInfo WHERE idBill = @idBill AND idFood = @idFood

	IF (@hasBillInfo > 0)
	BEGIN
		DECLARE @newCount INT = @foodCount + @countFood
		IF (@newCount > 0)
			UPDATE dbo.BillInfo SET count = @foodCount + @countFood WHERE idBill = @idBill and idFood = @idFood
		ELSE
			DELETE BillInfo WHERE idBill = @idBill AND idFood = @idFood
	END
	ELSE
	BEGIN 
		INSERT BillInfo (idBill, idFood, count) VALUES ( @idBill, @idFood, @countFood)
	END
END


GO
CREATE TRIGGER UpdateBillInfo
ON BillInfo
FOR UPDATE,INSERT
AS
BEGIN
	DECLARE @idBill INT
	SELECT @idBill=idBill FROM Inserted

	DECLARE @idTable INT
	SELECT @idTable=idTable FROM Bill WHERE id=@idBill AND statusBill = 0

	DECLARE @count int
	SELECT @count =  count(*)  from BillInfo where idBill= @idBill
	if (@count > 0)
		UPDATE FoodTable SET statusTable=N'Có người' WHERE id=@idTable
	else 
		UPDATE FoodTable SET statusTable=N'Trống' WHERE id=@idTable
END

GO

/*
CREATE TRIGGER UpdateTable ON FoodTable FOR UPDATE
AS
BEGIN
	DECLARE @idTable int
	DECLARE @status NVARCHAR(50)
	select  @idTable = id, @status=inserted.statusTable from inserted
	
	DECLARE @idBill int
	select @idBill = id from Bill Where idTable=@idTable and statusBill=0

	DECLARE @countBillInfo int
	select @countBillInfo = count(*) from BillInfo where idBill=@idBill

	if (@countBillInfo > 0 and @status <> N'Có người')
		UPDATE FoodTable SET statusTable=N'Có người' WHERE id=@idTable
	ELSE if (@countBillInfo <= 0 and @status <> N'Trống')
		UPDATE FoodTable SET statusTable=N'Trống' WHERE id=@idTable
END
*/


GO
CREATE TRIGGER UpdateBill ON Bill FOR UPDATE 
AS
BEGIN
	DECLARE @idBill INT
	SELECT @idBill=id FROM Inserted

	DECLARE @idTable INT
	SELECT @idTable=idTable FROM dbo.Bill WHERE id=@idBill

	DECLARE @count int = 0
	SELECT @count = COUNT(*) FROM Bill WHERE idTable = @idTable AND statusBill = 0

	IF(@count = 0) 
		UPDATE FoodTable SET statusTable = N'Trống' WHERE id=@idTable

END
GO

CREATE PROC swapTable
@idTable1 INT,@idTable2 INT
AS
BEGIN
	DECLARE @idBill1 INT,@idBill2 INT,@countBillInfo1 INT,@countBillInfo2 INT

	DECLARE @TEMP1 INT  = 1
	DECLARE @TEMP2 INT  = 1

	SELECT @idBill1=id FROM dbo.Bill WHERE idTable=@idTable1 AND statusBill=0
	SELECT @idBill2=id FROM dbo.Bill WHERE idTable=@idTable2 AND statusBill=0

	if(@idBill1 IS NULL) 
	BEGIN
		INSERT Bill(DateCheckIn,DateCheckOut,idTable,statusBill) VALUES (GETDATE(), NULL, @idTable1, 0)
		select @idBill1=MAX(id) FROM Bill WHERE idTable=@idTable1 AND statusBill=0
	END

	SELECT @TEMP1 = count(*) from  BillInfo where idBill=@idBill1

	if(@idBill2 IS NULL) 
	BEGIN
		INSERT Bill(DateCheckIn,DateCheckOut,idTable,statusBill) VALUES (GETDATE(), NULL, @idTable2, 0)
		select @idBill2=MAX(id) FROM Bill WHERE idTable=@idTable2 AND statusBill=0
		SET @TEMP2 = 1
	END

	SELECT @TEMP2 = count(*) from  BillInfo where idBill=@idBill2

	SELECT id INTO  IDBIllInfoTable FROM BillInfo WHERE idBill=@idBill2

	UPDATE BillInfo SET idBill=@idBill2 WHERE idBill=@idBill1

	UPDATE BillInfo SET idBill=@idBill1 WHERE id in (select * from IDBIllInfoTable)

	DROP TABLE IDBIllInfoTable

	if (@TEMP1 = 0)
		UPDATE FoodTable SET statusTable = N'Trống' where id=@idTable2

	if (@TEMP2 = 0)
		UPDATE FoodTable SET statusTable = N'Trống' where id=@idTable1
	--SELECT @countBillInfo1=COUNT(*) FROM dbo.BillInfo WHERE idBill=@idBill1
	--SELECT @countBillInfo2=COUNT(*) FROM dbo.BillInfo WHERE idBill=@idBill2
		--UPDATE dbo.Bill SET idTable=@idTable2 WHERE id=@idBill1
		--UPDATE dbo.Bill SET idTable=@idTable1 WHERE id=@idBill2
    --IF(@countBillInfo1=0) UPDATE FoodTable SET statusTable=N'Trống' WHERE id=@idTable2
	--IF(@countBillInfo2=0) UPDATE FoodTable SET statusTable=N'Trống' WHERE id=@idTable1
END

GO
CREATE PROC ShowBill
@checkIn date, @checkOut date AS
BEGIN
select FoodTable.nameTable as N'Tên bàn', Bill.totalPrice as N'Tổng tiền', DateCheckIn as N'Thời gian vào', DateCheckOut as N'Thời gian ra', discount as N'Giảm giá (%)' from Bill, FoodTable
where DateCheckIn >= @checkIn and DateCheckOut <= @checkOut and Bill.statusBill = 1 and FoodTable.id = Bill.idTable
END

GO
CREATE PROC Login @username nvarchar(50), @password nvarchar(50)
AS
BEGIN
	select * from Account where UserName = @username and PassWord = @password
END
GO

CREATE PROC UpdateAccount
@username nvarchar(100), @displayname nvarchar(100),@password nvarchar(100), @newpassword nvarchar(100)
AS 
BEGIN
	DECLARE	@rightPass int = 0
	SELECT @rightPass = count(*) from Account where UserName = @username and PassWord = @password
	
	if (@rightPass = 1)
	BEGIN
		IF (@newpassword = NULL or @newpassword = '')
		BEGIN
			UPDATE Account set DisplayName = @displayname where UserName = @username
		END
		ELSE 
			UPDATE Account set DisplayName = @displayname, PassWord = @newpassword where UserName = @username
	END
END

GO
CREATE TRIGGER deleteBillInfo ON BillInfo FOR DELETE
AS
BEGIN
	DECLARE @idBillinfo int
	declare @idBill int
	select @idBillinfo = id, @idBill = deleted.idBill from deleted

	declare @idTable int
	select @idTable = idTable from Bill where id = @idBill

	declare @count int
	select @count = count(*) from BillInfo, Bill where Bill.id = BillInfo.idBill and Bill.id = @idBill and Bill.statusBill = 0

	if (@count = 0)
		update FoodTable set statusTable = N'Trống' where id = @idTable
END

select * from Account


----------------------------------------------------------------------------------------------------------------------------------
