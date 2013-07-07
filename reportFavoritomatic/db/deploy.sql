use dwade 
go

if object_id(N'dbo.category') is not null
begin
	drop table dbo.category
end
create table dbo.category
(
	category_id int identity primary key
	,parent_category_id int
	,category_name varchar(150)
	,creation_date datetime
)
go

if object_id(N'dbo.report') is not null
begin
	drop table dbo.report
end
create table dbo.report
(
	report_id varchar(128) primary key
	,report_name varchar(256)
	,creation_date datetime
	,last_updated_date datetime
)

if object_id(N'dbo.end_user') is not null
begin
	drop table dbo.end_user
end
create table dbo.end_user
(
	domain_id varchar(256) primary key
	,user_name varchar(256)
	,is_supervisor bit
	,supervisor_id varchar(256)
)


if object_id(N'dbo.favorite') is not null
begin
	drop table dbo.favorite
end
create table dbo.favorite
(
	favorite_id int identity primary key
	,favorite_name varchar(256)
	,report_id varchar(128) references dbo.report
	,report_path varchar(256)
	,user_id varchar(256) references dbo.end_user
	,created_by_id varchar(128)
	,creation_date datetime
	,next_reminder_date datetime
)