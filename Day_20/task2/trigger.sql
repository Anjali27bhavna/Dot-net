create table cust_log(logid numeric identity,custid numeric,operation nvarchar(20),updatedate datetime)

select * from cust_log

create trigger custinsert
on customer_details
for insert
as
insert into cust_log(custid,operation,updatedate)
select custid,'Data inserted',GETDATE()
from inserted

create trigger custupdate
on customer_details
after update
as
insert into cust_log(custid,operation,updatedate)
select custid,'Data updated',GETDATE()
from deleted

create trigger custdelete
on customer_details
after delete
as
insert into cust_log(custid,operation,updatedate)
select custid,'Data deleted',GETDATE()
from deleted


