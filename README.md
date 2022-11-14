# MindBoxTestTask
#
## MS SQL task
#
#### Создание таблиц 
#
```sh
CREATE TABLE Product(
    Product_ID		    INTEGER      NOT NULL,
    Product_Name	    VARCHAR(20)  NOT NULL
CONSTRAINT Product_PK PRIMARY KEY (Product_ID));

CREATE TABLE Category(
    Category_ID         INTEGER         NOT NULL,
    Category_Name	    VARCHAR(20)     NOT NULL
CONSTRAINT Category_PK PRIMARY KEY (Category_ID));

CREATE TABLE Category_Product(
    Category_ID         INTEGER         NOT NULL,
	Product_ID	        INTEGER         NOT NULL);
```
#
#### Заполнение таблиц
#
```sh
INSERT INTO Product VALUES (1, 'Nuts');
INSERT INTO Product VALUES (2, 'Сrisps');
INSERT INTO Product VALUES (3, 'Juice');
INSERT INTO Product VALUES (4, 'Beer');
INSERT INTO Product VALUES (5, 'Energy drink');
INSERT INTO Product VALUES (6, 'Milk');
INSERT INTO Product VALUES (7, 'Cheese');
INSERT INTO Product VALUES (8, 'Cake');

INSERT INTO Category VALUES (1, 'Dairy');
INSERT INTO Category VALUES (2, 'Healthy eating');
INSERT INTO Category VALUES (3, 'Snacks');
INSERT INTO Category VALUES (4, 'Drinks');
INSERT INTO Category VALUES (5, 'Empty');

INSERT INTO Category_Product VALUES (1, 6);
INSERT INTO Category_Product VALUES (1, 7);
INSERT INTO Category_Product VALUES (2, 1);
INSERT INTO Category_Product VALUES (2, 3);
INSERT INTO Category_Product VALUES (2, 6);
INSERT INTO Category_Product VALUES (2, 7);
INSERT INTO Category_Product VALUES (3, 1);
INSERT INTO Category_Product VALUES (3, 2);
INSERT INTO Category_Product VALUES (4, 3);
INSERT INTO Category_Product VALUES (4, 4);
INSERT INTO Category_Product VALUES (4, 5);
INSERT INTO Category_Product VALUES (4, 6);
```

#
#### SQL запрос:
#

```sh
SELECT Product_Name, Category_Name 
FROM Product 
LEFT JOIN Category_Product ON Product.Product_ID = Category_Product.Product_ID
LEFT JOIN Category ON Category_Product.Category_ID = Category.Category_ID
```
