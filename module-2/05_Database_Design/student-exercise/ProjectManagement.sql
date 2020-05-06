USE master
GO

DROP DATABASE IF EXISTS ProjectOrganizer

CREATE DATABASE ProjectOrganizer
GO

USE ProjectOrganizer

BEGIN TRANSACTION;

CREATE TABLE Employee
(
	employee_number int identity(1,1),
	job_title varchar (15) NOT NULL,
	first_name varchar(25) NOT NULL,
	last_name varchar(25) NOT NULL,
	gender char NOT NULL,
	date_of_birth date NOT NULL,
	date_of_hire date NOT NULL,
	department_id int NOT NULL,

	constraint pk_employee_number primary key(employee_number) 
);

CREATE TABLE departments
(
	dept_number int identity(10, 1),
	dept_name varchar(20) NOT NULL,


	constraint pk_dept_number primary key(dept_number)
);

CREATE TABLE project
(
	project_number int identity(100,1),
	name varchar(50)  NOT NULL,
	project_start_date date NOT NULL,

	constraint pk_project_number primary key(project_number),
);
CREATE TABLE Employee_Project
(
	employee_number int NOT NULL,
	project_number int NOT NULL,

	constraint pk_employee_number_project_number primary key(employee_number, project_number)

);

SET IDENTITY_INSERT departments ON;

INSERT INTO departments (dept_name, dept_number) VALUES('Management',10)
INSERT INTO departments (dept_name, dept_number) VALUES('IT',11)
INSERT INTO departments (dept_name, dept_number) VALUES('Sales',12)

SET IDENTITY_INSERT departments OFF;


SET IDENTITY_INSERT project ON;

INSERT INTO project (project_number, name,project_start_date) VALUES(100,'Database Upgrade','20200417')
INSERT INTO project (project_number, name,project_start_date) VALUES(101, 'Fiber Installation', '20200417')
INSERT INTO project (project_number, name,project_start_date) VALUES(102, 'Telecommunication Upgrade', '20200515')
INSERT INTO project (project_number, name,project_start_date) VALUES(103, 'Laptop Upgrade', '20200701')

SET IDENTITY_INSERT project OFF;


INSERT INTO Employee (job_title,first_name,last_name,gender,date_of_birth,date_of_hire,department_id)
VALUES('ceo','bill','smith','m','19700101', '20010101',10)
INSERT INTO Employee (job_title,first_name,last_name,gender,date_of_birth,date_of_hire,department_id)
VALUES('cfo','joe','shaw','m','19780101', '20010101',10)
INSERT INTO Employee (job_title,first_name,last_name,gender,date_of_birth,date_of_hire,department_id)
VALUES('junior dev','brian','woods','m','19780914', '20200420',11)
INSERT INTO Employee (job_title,first_name,last_name,gender,date_of_birth,date_of_hire,department_id)
VALUES('senior dev','beth','woods','f','19800717', '20180101',11)
INSERT INTO Employee (job_title,first_name,last_name,gender,date_of_birth,date_of_hire,department_id)
VALUES('sales','morgan','woods','f','20080229', '20200217',12)
INSERT INTO Employee (job_title,first_name,last_name,gender,date_of_birth,date_of_hire,department_id)
VALUES('sales','eric','woods','m','20110203', '20200220',12)
INSERT INTO Employee (job_title,first_name,last_name,gender,date_of_birth,date_of_hire,department_id)
VALUES('sales','james','pennington','m','19800723', '20190101',12)
INSERT INTO Employee (job_title,first_name,last_name,gender,date_of_birth,date_of_hire,department_id)
VALUES('sales','mike','smith','m','19910820', '20010101',10)


ALTER TABLE employee
ADD FOREIGN KEY(department_id)
REFERENCES departments(dept_number)



COMMIT TRANSACTION;
