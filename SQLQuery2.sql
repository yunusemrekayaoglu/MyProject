--select
--ANSII 
--case insensitive 
--select ContactName Adi, CompanyName SirketAdi, City Sehir from Customers

--select * from Customers where City = 'Berlin'

--select * from Products where CategoryID = 1 or CategoryID = 3 

--select * from products where CategoryID = 1 and UnitPrice >= 10

--select * from products where categoryid = 1 order by UnitPrice desc 

--select count(*) from products where CategoryID = 2

--select CategoryID, count (*) from products group by CategoryID

--select CategoryID, count (*) from products where unitprice > 20 group by  CategoryID having count(*) < 10

--select products.ProductID, products.ProductName, products.UnitPrice, categories.CategoryName
--from products inner join Categories
--on products.CategoryID = Categories.CategoryID
--where products.UnitPrice > 10

--DTO data transformation object

--select * from Products  p left join [Order Details] od
--on p.ProductID = od.ProductID

--select * from customers c left join orders o
--on c.CustomerID = o.CustomerID
--where o.CustomerID is null
