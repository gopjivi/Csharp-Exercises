SELECT * from Suppliers;

--List all category data

select * from Categories

--List category id and category name of all categories sorted by id

select CategoryID,CategoryName from Categories order by CategoryID asc

--List the id, product name, and unit price of all products

select ProductID,ProductName,UnitPrice from Products

--List the id, product name, and unit price of all products that cost less that $10.00

select ProductID,ProductName,UnitPrice from Products where UnitPrice<10.00

--Do a join between categories and products so that you can list the id, product name, unit price, and category name of all products

select c.CategoryName ,p.ProductID,p.ProductName,p.UnitPrice from Products p join Categories c on c.CategoryID=p.CategoryID


--List the product id, product name, unit price, category name, and  supplier name of all products that cost between %5.00 and $20.00
select c.CategoryName ,p.ProductID,p.ProductName,p.UnitPrice,s.CompanyName from Products p join Categories c  on c.CategoryID=p.CategoryID join Suppliers s on  p.SupplierID=s.SupplierID
where p.UnitPrice  between 5.00 and 20.00


	