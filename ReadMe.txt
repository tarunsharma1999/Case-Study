*********First run this query in sql server:**********************

create table menu_item(
id		int,
name	varchar(15),
price	float,
active	varchar(15) ,
dateofLaunch	Datetime,
category	varchar(15),
freeDelivery	varchar(15)
);

insert into menu_item values(1, 'Sandwich', 99, 'Yes', '20210530', 'Starter', 'No');
insert into menu_item values(2, 'Burger', 99, 'Yes', '20210530', 'Starter', 'No');
insert into menu_item values(3, 'Pizza', 199, 'Yes', '20210530', 'Main-course', 'Yes');
insert into menu_item values(4, 'Pasta', 199, 'No', '20210530', 'Main-course', 'No');
insert into menu_item values(5, 'MilkShake', 99, 'Yes', '20210530', 'Drinks', 'No');
insert into menu_item values(6, 'Cold-drink', 99, 'No', '20210530', 'Drinks', 'No');

create table cart( 
userId	int, 
itemId	int 
);

*********************************************************************
NOW OPEN VS > Open Project > Select TruYum Console > choose .sln file
Now Add Connection String to app.confing in both TruyumConsole and DAO Class
Add references of System.Data , if not added automatically.
