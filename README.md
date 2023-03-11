# MindBoxNewTestTask
<h1>Задание№1</h1>
<h3>Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:<h3>

- Юнит-тесты :heavy_check_mark:
- Легкость добавления других фигур :heavy_check_mark: ( С примером прямоугольника )
- Вычисление площади фигуры без знания типа фигуры в compile-time :heavy_check_mark:
- Проверку на то, является ли треугольник прямоугольным :heavy_check_mark:


<h1>Задание№2</h1>
<h3>В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.<h3>

У нас имеются 3 таблицы (Две таблицы по условию и связующая таблица "Linking"). Тогда получим:

Создадим таблицу Linking
````
CREATE TABLE Linking 
(
	ProductID INT FOREIGN KEY REFERENCES Products(Id),
	CategoryID INT FOREIGN KEY REFERENCES Categories(Id),
	PRIMARY KEY (ProductId, CategoryId)
);
````
Сделаем выборку
````
SELECT p.ProductName AS Product, c.CategoryName AS Category FROM Products AS p
FULL JOIN Linking AS l ON p.Id = l.ProductID
LEFT JOIN Categories AS c ON c.ID = l.CategoryID
ORDER BY Product;
````
