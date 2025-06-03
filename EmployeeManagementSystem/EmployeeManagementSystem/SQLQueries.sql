create table users
(
	id int primary key identity(1,1),
	username varchar(max) null,
	password varchar(max) null,
	date_register date null
);

select * from users;

create table employees
(
	id int primary key identity(1,1),
	employee_id varchar(max) null,
	full_name varchar(max) null,
	gender varchar(max) null,
	contact_number varchar(max) null,
	position varchar(max) null,
	image varchar(max) null,
	salary int null,
	insert_date date null,
	update_date date null,
	delete_date date null
);


SELECT name FROM sys.key_constraints WHERE parent_object_id = OBJECT_ID('employees');
ALTER TABLE employees
DROP CONSTRAINT PK__employee__3213E83FB7F4B136;
select * from employees;
ALTER TABLE employees
DROP COLUMN id;
ALTER TABLE employees
ALTER COLUMN employee_id varchar(255) NOT NULL;

ALTER TABLE employees
ADD CONSTRAINT PK_employees_employee_id PRIMARY KEY (employee_id);


CREATE TABLE Bonus (
    bonus_id INT PRIMARY KEY IDENTITY(1,1),
    employee_id varchar(255) NOT NULL,
    basic_salary DECIMAL(10,2),
    bonus DECIMAL(10,2),
    total_salary AS (basic_salary + bonus) PERSISTED,
    FOREIGN KEY (employee_id) REFERENCES Employees(employee_id)
	on Delete cascade
	on Update cascade
);
select * from Users;
select * from employees;
alter table employees add  status varchar(max) null;
