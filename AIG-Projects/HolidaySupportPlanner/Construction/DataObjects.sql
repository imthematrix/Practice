--create table Applications(
--gear_id int primary key,
--application_name varchar(150) unique,
--asm_id int foreign key references resources(resource_id),
--psm_id int foreign key references resources(resource_id),
--bundle_name varchar(50) default 'Global Claims NA',
--supported_by varchar(10) default 'Onsite',
--support_mode varchar(15) default 'In-Office',
----support_team_id int 
--)


--create table Support_Teams(
--team_id int identity(100, 1) primary key,
--team_name varchar(100) unique,
--team_email varchar(100) default 'Team email unavailable',
--application_supported int foreign key references Applications(gear_id)
--)
--create table Resources(
--resource_id int identity(100, 1) primary key,
--resource_name varchar(200),
--contact_number varchar(15),
--email_id varchar(100) unique not null ,
--associate_app_id int default null,
--resource_status int default 1
--)
--create table Team_Mapping(
--team_id int foreign key references Support_teams(team_id),
--member_id int foreign key references Resources(resource_id),
--is_Lead int default 0
--)

--https://www.fourthbottle.com/2015/03/how-to-create-searchable-dropdown-list.html


select * from  Resources where is_support_personnel=1

