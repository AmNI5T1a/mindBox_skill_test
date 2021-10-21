CREATE TABLE ProductWithCategories(
    ProductID int FOREIGN KEY REFERENCES Products(ID),
    CategoryID int FOREIGN KEY REFERENCES Categories(ID),
    PRIMARY KEY(ProductID, CategoryID)
);