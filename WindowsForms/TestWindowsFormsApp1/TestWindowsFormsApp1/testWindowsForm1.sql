create database register;
use register;
create table registerUser(
	id int primary key identity(1,1),
	name varchar(30),
	password varchar(30),
	email varchar(30),
	role varchar(30),
	question varchar(250),
	answer varchar(250)
);



select * from registerUser;
