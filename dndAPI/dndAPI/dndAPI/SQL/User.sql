use dnd;

create table user(
id varchar(200) not null primary key,
nickName varchar(100) not null,
email varchar(100) not null,
password varchar (100) not null,
createdAt timestamp not null default current_timestamp,
updatedAt timestamp on update current_timestamp,
deleted boolean
)engine=INNODB;

select * from user

drop table user