SELECT Products.Name AS "Именование продукта", Categories.Name AS "Категория" FROM Products 
LEFT JOIN ProductsCategories ON Products.Id = ProductsCategories.Product_Id 
LEFT JOIN Categories ON ProductsCategories.Category_Id = Categories.Id