select Products.ProductName [Ürün Adı], sum([Order Details].UnitPrice * [Order Details].Quantity) [Kazanılan Miktar]
from products
inner join [Order Details] on Products.ProductID = [Order Details].ProductID
inner join Orders on Orders.OrderID = [Order Details].OrderID
group by ProductName
order by ProductName asc