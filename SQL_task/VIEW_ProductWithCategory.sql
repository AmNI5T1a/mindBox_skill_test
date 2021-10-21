CREATE VIEW ProductWithCategory AS SELECT products.Name AS ProductName, categoriesOfProducts.Name AS CategoryName FROM Products products
	LEFT JOIN ProductWithCategories productAndCategories ON products.ID = productAndCategories.ProductID
	LEFT JOIN Categories categoriesOfProducts ON productAndCategories.CategoryID = categoriesOfProducts.ID;

SELECT * FROM ProductWithCategory;