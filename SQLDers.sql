--Select
--ANSII

Select * from Customers --customers' ın bütün(*) kolonlarını seç
Select ContactName, CompanyName, City from Customers

Select * from Customers where City = 'London'  

--case insensitive = büyük küçük harf duyarsızdır
select * from Products where CategoryID = 1 or categoryID = 3

select * from Products where CategoryID = 1 and unitprice >= 10

select * from Products order by UnitPrice asc --ascending = artan
select * from Products order by UnitPrice desc --descending = azalan, düşen

select * from Products order by CategoryId, ProductName  --önce categoryId ye göre daha sonra bunları kendi içinde productName e göre sırala

select * from Products where categoryId = 1 order by UnitPrice desc

select count(*) from Products --count = adet bütün product tablosunda kaç tane ürün olduğunu saydırmaya yarar

--hangi kategoride kaç farklı ürün var?

select categoryId from products group by CategoryId --bir kategorideki ürünlerin categoryId lerine göre tekrarlamaksızın grupla

select categoryId, count(*) from products group by categoryId --kategorideki ürünlerin categoryId lerinde birbirinden farklı kaç tane ürün olduğunu sayarak gruplar şeklinde yaz

--karar destek sistemlerinde (kds) yoğun olarak kullanılan yöntemlerdir

select categoryId, count(*) from products group by categoryId having count(*)<10 --10 dan az ürün çeşidi olanları gruplayarak göster

select categoryId, count(*) from products where unitprice>20 group by categoryId having count(*)<10 --10 dan az olan ve unitprice 20 den büyük olanları göster



--inner join = farklı tablolardaki aynı girdileri kullnarak bir araya getirmek için kullanılır
select * 
from Products inner join Categories 
on Products.CategoryID = Categories.CategoryID --categories ve products daki categoryId leri bir araya getir

--göstermek istediğimiz ve birleştirmek istediğimiz kolonları aşağıdaki gibi yazabiliriz
select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories 
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice>10

--inner join yalnızca farklı tablolarda eşleşen verileri(örn CategoryID gibi) birleştirmemize yarar. Ancak eşleşmeyen verileri birleştirmek istediğimizde "left join" kullanmamız gerekir.
--left join = sola yazılan kategoride olup sağ da olmayanları birleştir anlamındadır.
--right join = sağa yazılan kategoride olup sol da olmayanları birleştir anlamındadır.
select * from Products p left join [Order Details] od
on p.ProductID = od.ProductID

select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID  --customers da olup orders da olmayanları(is null) göster
where o.CustomerID is null