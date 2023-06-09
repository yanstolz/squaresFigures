# SQL Запрос для выбора пар "Имя продукта - Имя категории"
Предположим, у нас есть две таблицы: "Продукты" (Products) с полями "Идентификатор продукта" (ProductID) и "Имя продукта" (ProductName), и "Категории" (Categories) с полями "Идентификатор категории" (CategoryID) и "Имя категории" (CategoryName). Связующая таблица "Продукты-Категории" (ProductCategories) содержит отношение между продуктами и категориями с полями "Идентификатор продукта" (ProductID) и "Идентификатор категории" (CategoryID).

___

SELECT P.ProductName, C.CategoryName  
FROM Products P  
LEFT JOIN ProductCategories PC ON P.ProductID = PC.ProductID  
LEFT JOIN Categories C ON C.CategoryID = PC.CategoryID;  
